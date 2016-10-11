using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FinanceTracker.Resources;

namespace FinanceTracker.Forms
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
                box.Text = ProjData[i++].ToString(Formats.MoneyFormat);
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
            var valid = true;

            foreach(var box in _boxes)
            {
                if (String.IsNullOrWhiteSpace(box.Text))
                    box.Text = "0";

                double num;
                if (!Double.TryParse(box.Text, out num))
                {
                    valid = false;
                    break;
                }
            }

            if(!valid)
                MessageBox.Show("Please enter a valid number");

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

        private void CheckKeyPressAction(object sender, KeyEventArgs e) { UIHelper.CheckKeyPress(sender, e, btnOK_Click); }
    }
}
