using System.Windows.Forms;

namespace InventoryTracker
{
    public partial class InventoryTracker : Form
    {
        public InventoryTracker()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
