using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FinanceTracker.DataObjects;
using FinanceTracker.Extensions;
using FinanceTracker.Resources;

namespace FinanceTracker.Forms
{
    public partial class MainForm : Form
    {
        private Month _activeMonth { get; set; }
        private List<double> _currData { get; set; } = new();
        private int _currColumn { get; set; } = -1;
        private List<ArchiveMonth> _archived { get; set; }

        private List<Label> _labels { get; } = new();

#region FormFunctions
        public MainForm()
        {
            InitializeComponent();

            _labels.Add(lblRentAmt);
            _labels.Add(lblPhoneBillAmt);
            _labels.Add(lblEntertainmentAmt);
            _labels.Add(lblGroceryAmt);
            _labels.Add(lblTransportationAmt);
            _labels.Add(lblEatOutAmt);
            _labels.Add(lblOtherAmt);

            ReadActiveMonth();
            InitProjectionData();
            while (string.IsNullOrWhiteSpace(_activeMonth.Name))
            {
                GetMonthName();
            }
            PopulateList();

            CenterToScreen();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            WriteActiveMonth();
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
                    _activeMonth.FinanceEntries.Add(entry);
                    lstItems.LoadItem(entry);
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
                    var entry = _activeMonth.FinanceEntries.Find(item => item.ID == Convert.ToInt32(row.SubItems[0].Text));
                    var index = _activeMonth.FinanceEntries.IndexOf(entry);
                    _currData[entry.Category] -= entry.Amount;
                    form.Entry = entry;
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        _activeMonth.FinanceEntries[index] = form.Entry;
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
            using (var form = new MonthlyProjection(_activeMonth.Projections)) //Saves data (reference passed?)
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
                        var deleteItem = _activeMonth.FinanceEntries.Find(item => item.ID == Convert.ToInt32(row.SubItems[0].Text));
                        _activeMonth.FinanceEntries.Remove(deleteItem);
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
            _currColumn = (sender as ListView).ColumnSort(_currColumn, e.Column);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteActiveMonth();

            var diag = new SaveFileDialog {Filter = "ZIP File (*.zip)|*.zip", Title = "Save As", FilterIndex = 1};
            var result = diag.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrEmpty(diag.FileName))
            {
                var numFiles = FileIO.BackupFiles(diag.FileName);
                MessageBox.Show($"{numFiles} files were backed up successfully", "Backup Successful");
            }
        }

        private void archiveMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Are you sure you want to finish and archive {_activeMonth.Name}", "Confirm Archival", MessageBoxButtons.OKCancel);

            if (result != DialogResult.OK)
            {
                return;
            }

            ReadArchives();
            var exists = _archived.Where(item => string.Compare(item.Name, _activeMonth.Name, StringComparison.OrdinalIgnoreCase) == 0);

            if (!exists.Any())
            {
                var monthArchive = new ArchiveMonth(_activeMonth);
                MessageBox.Show($"Your total spending for the { monthArchive.Name } left you with: { monthArchive.GetSpendingTotal().ToString(Formats.MoneyFormat) }", "Monthly Total");

                _archived.Add(monthArchive);
                WriteArchives();

                lstItems.ClearList();
                _activeMonth = new Month();
                Utilities.LoadID(_activeMonth.FinanceEntries);

                _activeMonth.Projections = monthArchive.Projections;
                InitProjectionData();

                Recalculate();
                while (string.IsNullOrWhiteSpace(_activeMonth.Name))
                {
                    GetMonthName();
                }
                WriteActiveMonth();
            }
            else
            {
                MessageBox.Show("Error: There is already an entry with the same name", "Error");
            }

            _archived = null;
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var diag = new OpenFileDialog {Filter = "ZIP File (*.zip)|*.zip", Title = "Open"};
            var result = diag.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrEmpty(diag.FileName))
            {
                var numFiles = FileIO.ImportFiles(diag.FileName);
                MessageBox.Show($"{numFiles} files were imported successfully", "Import Successful");

                //now need to update the prorgam
                lstItems.ClearList();
                _currData = new List<double>();

                ReadActiveMonth();
                InitProjectionData();
                PopulateList();
            }
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadArchives();
            if (_archived.Count != 0)
            {
                using (var form = new ArchiveViewer(_archived))
                {
                    form.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("There is no information archived", "No Archive");
            }
            _archived = null;
        }

        private void changeMonthNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetMonthName();
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
                var row = _activeMonth.FinanceEntries.Find(item => item.ID == Convert.ToInt32(lstItems.SelectedItems[0].SubItems[0].Text));
                var entry = new FinanceEntry(row.Category, row.Amount, row.Place, row.Description);
                _activeMonth.FinanceEntries.Add(entry);
                lstItems.LoadItem(entry);
                _currData[entry.Category] += entry.Amount;
                Recalculate();
            }
        }

         private void Recalculate()
        {
            var i = 0;
            foreach (var label in _labels)
                label.SetBalance(_activeMonth.Projections[i] - _currData[i++]);
        }

        private void InitProjectionData()
        {
            if (_activeMonth.Projections.Count == 0)
                _activeMonth.Projections = Enumerable.Repeat(0.0, Categories.Length).ToList();

            _currData = Enumerable.Repeat(0.0, Categories.Length).ToList();
        }

        private void PopulateList()
        {
            foreach (var item in _activeMonth.FinanceEntries)
            {
                _currData[item.Category] += item.Amount;
                lstItems.LoadItem(item);
            }
            Recalculate();
        }

        private void GetMonthName()
        {
            using var input = new InputBox("Enter a Name", "Please enter a new name for the current budget");
            if (input.ShowDialog() == DialogResult.OK)
            {
                _activeMonth.Name = input.InputText;
                lblName.Text = _activeMonth.Name;
            }
        }

#endregion

#region FileLoadAndSave

        private void ReadActiveMonth()
        {
            try
            {
                _activeMonth = FileIO.ReadXmlFile<Month>(FileNames.SaveFile);
                lblName.Text = _activeMonth.Name;
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}\n\n{e.InnerException?.Message}" , "Error Reading File");
            }

            Utilities.LoadID(_activeMonth.FinanceEntries);
        }

        private void ReadArchives()
        {
            try
            {
                _archived = FileIO.ReadXmlFile<List<ArchiveMonth>>(FileNames.ArchiveFile);
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}\n\n{e.InnerException?.Message}", "Error Reading File");
            }
        }

        private void WriteActiveMonth()
        {
            try
            {
                FileIO.WriteXmlFile(FileNames.SaveFile, _activeMonth);
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}\n\n{e.InnerException?.Message}", "Error Saving File");
            }
        }

        private void WriteArchives()
        {
            try {
                FileIO.WriteXmlFile(FileNames.ArchiveFile, _archived);
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}\n\n{e.InnerException?.Message}", "Error Saving File");
            }
        }

#endregion

    }
}
