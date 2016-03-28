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

        public MainData()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var diag = new OpenFileDialog { Filter = "XML File (*.xml)|*.xml", Title = "Open" };
            var result = diag.ShowDialog();

            if (result != DialogResult.OK || diag.FileName == "")
                return;

            lblFile.Text = diag.SafeFileName;
            _filename = diag.FileName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (_filename == "")
            {
                MessageBox.Show("There is no file selected!");
                return;
            }

            var namePath = _filename.Split('.')[0] + ".ftf";
            if (File.Exists(namePath))
            {
                var result = MessageBox.Show(lblFile.Text.Replace("xml", "ftf") + " already exists.\nDo you want to overwrite it?", "Overwrite", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;
            }

            try
            {
                var doc = new XmlDocument();
                doc.Load(_filename);
                var exml = Encryption.Encrypt(doc.OuterXml);
                File.WriteAllText(namePath, exml);

                lblFile.Text = _filename = "";
                MessageBox.Show("Conversion Successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}