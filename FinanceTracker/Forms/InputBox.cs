using System;
using System.Windows.Forms;

namespace FinanceTracker.Forms
{
    public sealed partial class InputBox : Form
    {
        public String InputText { get; set; }

        public InputBox(String caption, String text)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            lblText.Text = text;
            Text = caption;
            CenterToParent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtInput.Text))
            {
                InputText = txtInput.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("Please enter a valid input", "Invalid Input");
        }

        private void CheckKeyPress(object sender, KeyEventArgs e)
        {
            Utilities.CheckEscape(this, sender, e);
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
                btnOK_Click(sender, e);
        }
    }
}
