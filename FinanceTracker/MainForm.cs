using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FinanceTracker
{
    public partial class MainForm : Form
    {
        private List<FinanceEntry> _listFinances = new List<FinanceEntry>();
        private List<ArchiveMonth> _archived = new List<ArchiveMonth>();
        private List<double> _projData = new List<double>();
        private List<double> _currData = new List<double>();
        private readonly List<Label> _labels = new List<Label>();
        private int _currColumn = -1;

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
                    Utilities.LoadItem(lstItems, entry);
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
                        row.SubItems[1].Text = Utilities.CATEGORIES[form.Entry.Category];
                        row.SubItems[2].Text = form.Entry.Amount.ToString("N2");
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

        private void Recalculate()
        {
            var i = 0;
            foreach (var label in _labels)
                Utilities.LabelColor(_projData[i] - _currData[i++], label);
        }

        private void ReadArchives()
        {
            var archReader = new XmlSerializer(typeof(List<ArchiveMonth>));
            StreamReader archFile = null;

            //load archives
            try
            {
                archFile = new StreamReader("archFile.xml");
                var list = archReader.Deserialize(archFile);
                _archived = (List<ArchiveMonth>)list;
            }
            catch (FileNotFoundException)
            {
                //keep going the file hasnt been created yet
            }
            catch (Exception e)
            {
                MessageBox.Show("Error reading file\n" + e.Message, "Error Reading File");
            }
            finally
            {
                if (archFile != null)
                    archFile.Close();
            }
        }

        private void WriteArchives()
        {
            var archiveWriter = new XmlSerializer(typeof(List<ArchiveMonth>));
            StreamWriter archFile = null;

            //write projection
            try
            {
                archFile = new StreamWriter("archFile.xml", false);
                archiveWriter.Serialize(archFile, _archived);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error writing to file\n" + e.Message, "Error Saving File");
            }
            finally
            {
                if (archFile != null)
                    archFile.Close();
            }
        }
        
        private void ReadXML()
        {
            var reader = new XmlSerializer(typeof(List<FinanceEntry>));
            var projReader = new XmlSerializer(typeof(List<double>));
            StreamReader file = null;
            StreamReader projFile = null;

            //load entries
            try
            {
                file = new StreamReader("file.xml");
                var list = reader.Deserialize(file);
                _listFinances = (List<FinanceEntry>)list;
            }
            catch (FileNotFoundException)
            {
                //keep going the file hasnt been created yet
            }
            catch (Exception e)
            {
                MessageBox.Show("Error reading file\n" + e.Message,"Error Reading File");
            }
            finally
            {
                if (file != null)
                    file.Close();
            }

            //load prpjection
            try
            {
                projFile = new StreamReader("projFile.xml");
                var list = projReader.Deserialize(projFile);
                _projData = (List<double>)list;
            }
            catch (FileNotFoundException)
            {
                //keep going the file hasnt been created yet
            }
            catch (Exception e)
            {
                MessageBox.Show("Error reading file\n" + e.Message, "Error Reading File");
            }
            finally
            {
                if (projFile != null)
                    projFile.Close();
            }
        }

        private void WriteXML()
        {
            var writer = new XmlSerializer(typeof(List<FinanceEntry>));
            var projWriter = new XmlSerializer(typeof(List<double>));
            StreamWriter file = null;
            StreamWriter projFile = null;

            //write entries
            try
            {
                file = new StreamWriter("file.xml", false);
                writer.Serialize(file, _listFinances);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error writing to file\n" + e.Message, "Error Saving File");
            }
            finally
            {
                if (file != null)
                    file.Close();
            }

            //write projection
            try
            {
                projFile = new StreamWriter("projFile.xml", false);
                projWriter.Serialize(projFile, _projData);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error writing to file\n" + e.Message, "Error Saving File");
            }
            finally
            {
                if (projFile != null)
                    projFile.Close();
            }
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

            if (result != DialogResult.OK || diag.FileName == "") 
                return;

            var zipFile = new FileStream(diag.FileName, FileMode.Create);
            using (var archive = new ZipArchive(zipFile, ZipArchiveMode.Create))
            {
                foreach (var name in Utilities.FILE_NAMES)
                {
                    try
                    {
                        archive.CreateEntryFromFile(name, name);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No file " + name + " generated to backup yet. Continuing...", "File Not Backed Up");
                    }
                }
            }
        }

        private void archiveMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var input = new InputBox("Enter a Month", "Please enter the month you are archiving"))
            {
                if (input.ShowDialog() != DialogResult.OK) 
                    return;

                ReadArchives();
                var exists = _archived.Where(item => String.Compare(item.MonthName.ToUpper(), input.InputText.ToUpper(), StringComparison.Ordinal) == 0);

                if (!exists.Any())
                {
                    double projTotal = _projData.Sum();
                    double currTotal = _currData.Sum();
                    _archived.Add(new ArchiveMonth(input.InputText, _projData, projTotal, _listFinances, currTotal));
                    WriteArchives();

                    Utilities.ClearList(lstItems);
                    _listFinances = new List<FinanceEntry>();
                    _currData = new List<double>();
                    InitProjectionData();
                    Utilities.LoadID(_listFinances);
                    WriteXML();
                    Recalculate();
                    MessageBox.Show("Your total spending for the month left you with: " + (projTotal - currTotal).ToString("N2"), "Monthly Total");
                }
                else
                    MessageBox.Show("Error: There is already an entry with the same name","Error");
            }
        }

        private void InitProjectionData()
        {
            if (_projData.Count == 0)
                for (var i = 0; i < Utilities.CATEGORIES.Length; i++)
                    _projData.Add(0);
            for (var i = 0; i < Utilities.CATEGORIES.Length; i++)
                _currData.Add(0);
        }

        private void PopulateList()
        {
            foreach (var item in _listFinances)
            {
                _currData[item.Category] += item.Amount;
                Utilities.LoadItem(lstItems, item);
            }
            Recalculate();
        }
        
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var diag = new OpenFileDialog {Filter = "ZIP File (*.zip)|*.zip", Title = "Open"};
            var result = diag.ShowDialog();

            if (result != DialogResult.OK || diag.FileName == "")
                return;

            //check to see if files are in the .zip, skip archFile though its not required
            var archive = ZipFile.OpenRead(diag.FileName);
            var hasAll = Utilities.FILE_NAMES.Where(name => name != Utilities.FILE_NAMES[2]).All(
                name => archive.Entries.Count(item => String.Equals(item.Name, name, StringComparison.CurrentCultureIgnoreCase)) == 1);

            if(!hasAll) //if file or projfile missing, cancel
            {
                MessageBox.Show("The selected file does not have the required files", "Required Files Missing");
                return;
            }

            //otherwise import files
            foreach (var name in Utilities.FILE_NAMES)
            {
                var archiveEntry = archive.Entries.Where(item => String.Equals(item.Name, name, StringComparison.CurrentCultureIgnoreCase));
                if (!archiveEntry.Any()) //will only ever be archives
                {
                    MessageBox.Show("No file " + name + " to be found. It will not be imported.\nThe current archive file will be deleted.", "File Not Found");
                    if(File.Exists("archFile.xml"))
                        File.Delete("archFile.xml");
                    _archived = new List<ArchiveMonth>();
                }
                else
                    archiveEntry.First().ExtractToFile(name, true);
            }

            //now need to update the prorgam
            Utilities.ClearList(lstItems);
            _currData = new List<double>();
            ReadXML();
            Utilities.LoadID(_listFinances);
            InitProjectionData();
            PopulateList();
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadArchives();
            if(_archived.Count() !=0)
            {
                using (var form = new ArchiveViewer(_archived))
                {
                    form.ShowDialog();
                }
            }
            else
                MessageBox.Show("There is no information archived", "No Archive");
        }

        private void totalsAcrossMonthsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadArchives();
            if(_archived.Count() !=0)
            {
                using(var form = new TotalsForm(_archived))
                {
                    form.ShowDialog();
                }
            }
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
                Utilities.LoadItem(lstItems, entry);
                _currData[entry.Category] += entry.Amount;
                Recalculate();
            }
        }
    }
}
