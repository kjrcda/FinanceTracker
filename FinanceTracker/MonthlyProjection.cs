using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FinanceTracker
{
    public partial class MonthlyProjection : Form
    {
        protected internal List<double> ProjData;
        private readonly List<TextBox> _boxes = new List<TextBox>();

        public MonthlyProjection(List<double> data)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;

            ProjData = data;
            _boxes.Add(txtRent);
            _boxes.Add(txtPhoneBill);
            _boxes.Add(txtEntertainment);
            _boxes.Add(txtGrocery);
            _boxes.Add(txtTransportation);
            _boxes.Add(txtEatOut);
            _boxes.Add(txtOther);

            var i=0;
            foreach(var box in _boxes)
            {
                box.Text = ProjData[i++].ToString("N2");
            }

            UpdateTotal(null,null);
            CenterToParent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(ValidInput())
            {
                var i = 0;
                foreach(var box in _boxes)
                {
                    ProjData[i++] = Convert.ToDouble(box.Text);
                }
                DialogResult = DialogResult.OK;
                Dispose();
            }
        }

        private bool ValidInput()
        {
            var valid = false;
            try
            {
                foreach(var box in _boxes)
                {
                    if (String.IsNullOrWhiteSpace(box.Text))
                        box.Text = "0";
                    Convert.ToDouble(box.Text);
                }
                valid = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number");
            }
            return valid;
        }

        private void UpdateTotal(object sender, EventArgs e)
        {
            double total = 0;

            foreach(var box in _boxes)
            {
                try
                {
                    if (!String.IsNullOrWhiteSpace(box.Text))
                        total += Convert.ToDouble(box.Text);
                }
                catch (Exception)
                {
                    // ignored
                }
            }
            
            lblTotal.Text = "$" + total;
        }

        private void CheckKeyPress(object sender, KeyEventArgs e)
        {
            Utilities.CheckEscape(this, sender, e);
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
                btnOK_Click(sender, e);
        }
    }
}
