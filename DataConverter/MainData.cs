﻿using System;
using System.Windows.Forms;
using System.Xml;
using FinanceTracker;
using System.IO;

namespace DataConverter
{
    public partial class MainData : Form
    {
        private string _filename = "";
        private const string FileFilter = "XML File (*." + FileExtensions.Xml + ")|*." + FileExtensions.Xml;
        private const string AdminFilter = "Finance Tracker File (*." + FileExtensions.Ftf + ")|*." + FileExtensions.Ftf;

        public MainData()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var filter = FileFilter;
            var mEvent = (MouseEventArgs) e;

            if(mEvent.Button == MouseButtons.Right)
            {
                filter += "|" + AdminFilter;
            }

            var diag = new OpenFileDialog { Filter = filter, Title = "Open" };
            var result = diag.ShowDialog();

            if (result != DialogResult.OK || diag.FileName == "")
                return;

            txtFile.Text = diag.SafeFileName;
            _filename = diag.FileName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var delete = chkDelete.Checked;

            if (_filename == "")
            {
                MessageBox.Show("There is no file selected!");
                return;
            }

            var nameParts = _filename.Split('.');
            var convertedFormat = nameParts[1] == FileExtensions.Xml ? FileExtensions.Ftf : FileExtensions.Xml;
            var namePath = nameParts[0] + "." + convertedFormat;

            if (File.Exists(namePath))
            {
                var message = txtFile.Text.Split('.')[0] + "." + convertedFormat + " already exists.\nDo you want to overwrite it?";
                var result = MessageBox.Show(message, "Overwrite", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;
            }

            try
            {
                var doc = new XmlDocument();
                doc.Load(_filename);
                var exml = Encryption.Encrypt(doc.OuterXml);
                File.WriteAllText(namePath, exml);

                if (delete)
                    try { File.Delete(_filename); }
                    catch (Exception fex) { MessageBox.Show(fex.Message); }

                txtFile.Text = _filename = "";
                chkDelete.Checked = false;
                MessageBox.Show("Conversion Successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
