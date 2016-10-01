using System;
using System.Windows.Forms;
using FinanceTracker.DataObjects;

namespace FinanceTracker
{
    public sealed partial class NewForm : Form
    {
        internal FinanceEntry Entry;
        public NewForm(String title)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            Text = title;
            CenterToParent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                if(Entry == null)
                    Entry = new FinanceEntry(cmbCategory.SelectedIndex, Convert.ToDouble(txtAmount.Text), txtPlace.Text, txtDescription.Text);
                else
                    Entry.Set(cmbCategory.SelectedIndex, Convert.ToDouble(txtAmount.Text), txtPlace.Text, txtDescription.Text);
                DialogResult = DialogResult.OK;
                Dispose();
            }
        }

        private bool ValidInput()
        {
            var valid = false;

            if (cmbCategory.SelectedIndex == -1)
                MessageBox.Show("Please select a category");
            else if (String.IsNullOrWhiteSpace(txtAmount.Text))
                MessageBox.Show("Plese enter an amount");
            else if (String.IsNullOrWhiteSpace(txtPlace.Text))
                MessageBox.Show("Please enter a place");
            else
            {
                double variable;
                valid = Double.TryParse(txtAmount.Text, out variable);
                if(!valid)
                    MessageBox.Show("Please enter a valid number");
            }

            return valid;
        }

        private void NewForm_Load(object sender, EventArgs e)
        {
            if (Entry == null)
                return;

            cmbCategory.SelectedIndex = Entry.Category;
            txtAmount.Text = Entry.Amount.ToString("N2");
            txtPlace.Text = Entry.Place;
            txtDescription.Text = Entry.Description;
        }

        private void CheckKeyPress(object sender, KeyEventArgs e)
        {
            Utilities.CheckEscape(this, sender, e);
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
                btnOK_Click(sender, e);
        }
    }
}
