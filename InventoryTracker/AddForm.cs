using System.Windows.Forms;
using FinanceTracker;

namespace InventoryTracker
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {

        }

        private void CheckKeyPressAction(object sender, KeyEventArgs e) { UIHelper.CheckKeyPress(sender, e, btnOK_Click); }
    }
}
