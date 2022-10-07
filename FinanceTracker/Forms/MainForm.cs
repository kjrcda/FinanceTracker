using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FinanceTracker.DataObjects;
using FinanceTracker.Resources;

namespace FinanceTracker.Forms
{
    public partial class MainForm : Form
    {
        private List<FinanceEntry> _listFinances;
        private List<ArchiveMonth> _archived;
        private List<double> _projData;
        private List<double> _currData = new();
        private int _currColumn = -1;

        private List<Label> _labels { get; } = new();

#region FormFunctions
        public MainForm()
        {
            InitializeComponent();

            ReadXML();

            _labels.Add(lblRentAmt);
            _labels.Add(lblPhoneBillAmt);
            _labels.Add(lblEntertainmentAmt);
            _labels.Add(lblGroceryAmt);
            _labels.Add(lblTransportationAmt);
            _labels.Add(lblEatOutAmt);
            _labels.Add(lblOtherAmt);

            InitProjectionData();
            Utilities.LoadID(_listFinances);
            PopulateList();

            CenterToScreen();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            WriteXML();
        }

        private void TabClicked(object sender, EventArgs e)
        {
            lstItems.SelectedItems.Clear();
            lstPayments.SelectedItems.Clear();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (var form = new NewForm("New"))
            {
                var result = form.ShowDialog();
                if(result == DialogResult.OK)
                {
                    var entry = form.Entry;
                    _listFinances.Add(entry);
                    UIHelper.LoadItem(lstItems, entry);
                    _currData[entry.Category] += entry.Amount;
                    Recalculate();
                }
            }
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count == 1)
            {
                using (var form = new NewForm("Edit"))
                {
                    var row = lstItems.SelectedItems[0];
                    var entry = _listFinances.Find(item => item.ID == Convert.ToInt32(row.SubItems[0].Text));
                    var index = _listFinances.IndexOf(entry);
                    _currData[entry.Category] -= entry.Amount;
                    form.Entry = entry;
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        _listFinances[index] = form.Entry;
                        row.SubItems[1].Text = Categories.Get(form.Entry.Category);
                        row.SubItems[2].Text = form.Entry.Amount.ToString(Formats.MoneyFormat);
                        row.SubItems[3].Text = form.Entry.Place;
                        row.SubItems[4].Text = form.Entry.Description;

                        _currData[form.Entry.Category] += form.Entry.Amount;
                        Recalculate();
                    }
                    lstItems.SelectedItems[0].Selected = false;
                }
            }
            else if (lstItems.SelectedItems.Count > 1)
            {
                MessageBox.Show("Please select only 1 entry to edit","Edit Error");
                foreach (ListViewItem row in lstItems.SelectedItems)
                    row.Selected = false;
            }
            else
                MessageBox.Show("Please select an entry to edit", "Edit Error");
        }

        private void btnProjection_Click(object sender, EventArgs e)
        {
            using (var form = new MonthlyProjection(_projData)) //Saves data (reference passed?)
            {
                var result = form.ShowDialog();
                if(result == DialogResult.OK)
                {
                    Recalculate();
                }
            }
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count != 0 )
            {
                DialogResult result = DialogResult.OK;
                if (lstItems.SelectedItems.Count > 1)
                    result = MessageBox.Show("Are you sure you want to perform multiple deletions?", "Multiple Deletions", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    foreach (ListViewItem row in lstItems.SelectedItems)
                    {
                        var deleteItem = _listFinances.Find(item => item.ID == Convert.ToInt32(row.SubItems[0].Text));
                        _listFinances.Remove(deleteItem);
                        lstItems.Items.Remove(row);
                        _currData[deleteItem.Category] -= deleteItem.Amount;
                    }
                    Recalculate();
                }
            }
            else
                MessageBox.Show("Please select an entry to delete", "Deletion Error");
        }

        private void lstItems_ColumnSort(object sender, ColumnClickEventArgs e)
        {
            _currColumn = ListSorter.ColumnSort((ListView)sender, e, _currColumn);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteXML();

            var diag = new SaveFileDialog {Filter = "ZIP File (*.zip)|*.zip", Title = "Save As", FilterIndex = 1};
            var result = diag.ShowDialog();

            if (result == DialogResult.OK && !String.IsNullOrEmpty(diag.FileName))
            {
                FileIO.BackupFiles(diag.FileName);
            }
        }

        private void archiveMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var input = new InputBox("Enter a Month", "Please enter the month you are archiving"))
            {
                string inputtxt;
                if (input.ShowDialog() == DialogResult.OK)
                    inputtxt = input.InputText.ToUpper();
                else
                    return;

                ReadArchives();
                var exists = _archived.Where(item => String.Compare(item.MonthName.ToUpper(), inputtxt, StringComparison.Ordinal) == 0);

                if (!exists.Any())
                {
                    double projTotal = _projData.Sum();
                    double currTotal = _currData.Sum();
                    _archived.Add(new ArchiveMonth(input.InputText, _projData, projTotal, _listFinances, currTotal));
                    WriteArchives();

                    UIHelper.ClearList(lstItems);
                    _listFinances = new List<FinanceEntry>();
                    _currData = new List<double>();
                    InitProjectionData();
                    Utilities.LoadID(_listFinances);
                    WriteXML();
                    Recalculate();
                    MessageBox.Show("Your total spending for the month left you with: " + (projTotal - currTotal).ToString(Formats.MoneyFormat), "Monthly Total");
                }
                else
                    MessageBox.Show("Error: There is already an entry with the same name","Error");
                _archived = null;
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var diag = new OpenFileDialog {Filter = "ZIP File (*.zip)|*.zip", Title = "Open"};
            var result = diag.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrEmpty(diag.FileName))
            {
                FileIO.ImportFiles(diag.FileName, ref _archived);

                //now need to update the prorgam
                UIHelper.ClearList(lstItems);
                _currData = new List<double>();
                ReadXML();
                Utilities.LoadID(_listFinances);
                InitProjectionData();
                PopulateList();
            }
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadArchives();
            if(_archived.Count != 0)
            {
                using (var form = new ArchiveViewer(_archived))
                {
                    form.ShowDialog();
                }
            }
            else
                MessageBox.Show("There is no information archived", "No Archive");
            _archived = null;
        }

        private void totalsAcrossMonthsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadArchives();
            if(_archived.Count != 0)
            {
                using(var form = new TotalsForm(_archived))
                {
                    form.ShowDialog();
                }
            }
            _archived = null;
        }

        private void lstItems_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var item = lstItems.SelectedItems[0];
                if (item != null)
                    lstViewContextMenu.Show(lstItems, e.Location);
            }
        }

        private void tlspCopy_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count > 1)
                MessageBox.Show("You can only copy one item at a time", "Too Many Selected");
            else if (lstItems.SelectedItems.Count < 1)
                MessageBox.Show("You must select and item to copy", "Select Item");
            else
            {
                var row = _listFinances.Find(item => item.ID == Convert.ToInt32(lstItems.SelectedItems[0].SubItems[0].Text));
                var entry = new FinanceEntry(row.Category, row.Amount, row.Place, row.Description);
                _listFinances.Add(entry);
                UIHelper.LoadItem(lstItems, entry);
                _currData[entry.Category] += entry.Amount;
                Recalculate();
            }
        }

         private void Recalculate()
        {
            var i = 0;
            foreach (var label in _labels)
                UIHelper.LabelColor(_projData[i] - _currData[i++], label);
        }

        private void InitProjectionData()
        {
            if (_projData.Count == 0)
                _projData = Enumerable.Repeat(0.0, Categories.Length).ToList();

            _currData = Enumerable.Repeat(0.0, Categories.Length).ToList();
        }

        private void PopulateList()
        {
            foreach (var item in _listFinances)
            {
                _currData[item.Category] += item.Amount;
                UIHelper.LoadItem(lstItems, item);
            }
            Recalculate();
        }

#endregion

#region FileLoadAndSave

        private void ReadXML()
        {
            foreach (var pair in FileNames.Pairs)
            {
                try
                {
                    if (pair.Key == FileNames.SaveFile.Name)
                    {
                        _listFinances = FileIO.ReadFile(pair.Key, pair.Value) ?? Activator.CreateInstance(pair.Value);
                    }
                    else if (pair.Key == FileNames.ProjectionFile.Name)
                    {
                        _projData = FileIO.ReadFile(pair.Key, pair.Value) ?? Activator.CreateInstance(pair.Value);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"{e.Message}\n\n{e.InnerException?.Message}" , "Error Reading File");
                }
            }
        }

        private void ReadArchives()
        {
            try
            {
                _archived = FileIO.ReadFile(
                    FileNames.ArchiveFile.Name, FileNames.ArchiveFile.DataType) ?? Activator.CreateInstance(FileNames.ArchiveFile.DataType
                );
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}\n\n{e.InnerException?.Message}", "Error Reading File");
            }
        }

        private void WriteXML()
        {
            foreach (var pair in FileNames.Pairs)
            {
                try
                {
                    if (pair.Key == FileNames.SaveFile.Name)
                    {
                        FileIO.WriteFile(pair.Key, pair.Value, _listFinances);
                    }
                    else if (pair.Key == FileNames.ProjectionFile.Name)
                    {
                        FileIO.WriteFile(pair.Key, pair.Value, _projData);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"{e.Message}\n\n{e.InnerException?.Message}", "Error Saving File");
                }
            }
        }

        private void WriteArchives()
        {
            try {
                FileIO.WriteFile(FileNames.ArchiveFile.Name, FileNames.ArchiveFile.DataType, _archived);
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}\n\n{e.InnerException?.Message}", "Error Saving File");
            }
        }

#endregion

    }
}
