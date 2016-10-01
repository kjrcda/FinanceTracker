using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using FinanceTracker.DataObjects;
using FinanceTracker.Resources;

namespace FinanceTracker.Forms
{
    public partial class MainForm : Form
    {
        private List<FinanceEntry> _listFinances;
        private List<ArchiveMonth> _archived;
        private List<double> _projData;
        private List<double> _currData = new List<double>();
        private int _currColumn = -1;

        private readonly List<Label> _labels = new List<Label>();
        private readonly Dictionary<string, Type> _fileNameType = new Dictionary<string, Type>();
        private static readonly string SavePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Finance Tracker");

        public MainForm()
        {
            InitializeComponent();
            Encryption.Initialize("@Why4Not8USE3A2funny0pasSworD%3T", "D#$rwfa24SGHdf4f");
            _fileNameType.Add(FileNames.SaveFile, typeof(List<FinanceEntry>));
            _fileNameType.Add(FileNames.ProjectionFile, typeof(List<double>));

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

        private void Recalculate()
        {
            var i = 0;
            foreach (var label in _labels)
                Utilities.LabelColor(_projData[i] - _currData[i++], label);
        }

#region FileLoadAndSave

        private void ReadXML()
        {
            foreach (var pair in _fileNameType)
            {
                if(pair.Key == FileNames.SaveFile)
                    _listFinances = ReadFile(pair.Key, pair.Value) ?? new List<FinanceEntry>();
                else if(pair.Key == FileNames.ProjectionFile)
                    _projData = ReadFile(pair.Key, pair.Value) ?? new List<double>();
            }
        }

        private void ReadArchives()
        {
            _archived = ReadFile(FileNames.ArchiveFile, typeof(List<ArchiveMonth>)) ?? new List<ArchiveMonth>();
        }

        private static dynamic ReadFile(string name, Type objType)
        {
            dynamic list = null;
            try
            {
                var exml = File.ReadAllText(Path.Combine(SavePath, name));
                var xml = Encryption.Decrypt(exml);

                using (var xreader = XmlReader.Create(new StringReader(xml)))
                {
                    xreader.MoveToContent();
                    list = new XmlSerializer(objType).Deserialize(xreader);
                }
            }
            catch (FileNotFoundException)
            {
                //keep going the file hasnt been created yet
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(SavePath);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error reading file\n" + e.Message, "Error Reading File");
            }

            return list;
        }

        private void WriteXML()
        {
            foreach (var pair in _fileNameType)
            {
                if(pair.Key == FileNames.SaveFile)
                    WriteFile(pair.Key, pair.Value, _listFinances);
                else if(pair.Key == FileNames.ProjectionFile)
                    WriteFile(pair.Key, pair.Value, _projData);
            }
        }

        private void WriteArchives()
        {
            WriteFile(FileNames.ArchiveFile, typeof(List<ArchiveMonth>), _archived);
        }

        private static void WriteFile(string name, Type objType, dynamic list)
        {
            try
            {
                using (var writer = new StringWriter())
                {
                    var serializer = new XmlSerializer(objType);
                    serializer.Serialize(writer, list);
                    var xml = writer.ToString();
                    var exml = Encryption.Encrypt(xml);
                    File.WriteAllText(Path.Combine(SavePath, name), exml);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error writing to file\n" + e.Message, "Error Saving File");
            }
        }

#endregion

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
                foreach (var name in FileNames.Members)
                {
                    try
                    {
                        archive.CreateEntryFromFile(Path.Combine(SavePath, name), name);
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

                    Utilities.ClearList(lstItems);
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

        private void InitProjectionData()
        {
            if (_projData.Count == 0)
                for (var i = 0; i < Categories.Length; i++)
                    _projData.Add(0);
            for (var i = 0; i < Categories.Length; i++)
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
            var hasAll = FileNames.Where(name => name != FileNames.ArchiveFile).All(
                name => archive.Entries.Count(item => String.Equals(item.Name, name, StringComparison.CurrentCultureIgnoreCase)) == 1);

            if(!hasAll) //if file or projfile missing, cancel
            {
                MessageBox.Show("The selected file does not have the required files", "Required Files Missing");
                return;
            }

            //otherwise import files
            foreach (var name in FileNames.Members)
            {
                var fName = name;
                var archiveEntry = archive.Entries.Where(item => String.Equals(item.Name, fName, StringComparison.CurrentCultureIgnoreCase));
                var fNamePath = Path.Combine(SavePath, fName);

                var zipArchiveEntries = archiveEntry.ToList();
                if (!zipArchiveEntries.Any()) //will only ever be archives
                {
                    MessageBox.Show("No file " + fName + " to be found. It will not be imported.\nThe current archive file will be deleted.", "File Not Found");
                    if (File.Exists(fNamePath))
                        File.Delete(fNamePath);
                    _archived = new List<ArchiveMonth>();
                }
                else
                    zipArchiveEntries.First().ExtractToFile(fNamePath, true);
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
            _archived = null;
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
                Utilities.LoadItem(lstItems, entry);
                _currData[entry.Category] += entry.Amount;
                Recalculate();
            }
        }
    }
}
