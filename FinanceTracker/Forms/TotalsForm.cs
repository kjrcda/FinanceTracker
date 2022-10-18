using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FinanceTracker.DataObjects;
using FinanceTracker.Extensions;

namespace FinanceTracker.Forms
{
    public partial class TotalsForm : Form
    {
        private double _total;

        public TotalsForm(List<ArchiveMonth> archivedMonths)
        {
            InitializeComponent();

            chklstItems.DataSource = archivedMonths.Select(
                m => new DisplayItem<double>()
                {
                    Name = m.Name,
                    Value = m.GetSpendingTotal()
                }
            ).ToList();
            chklstItems.DisplayMember = nameof(DisplayItem<double>.Name); // Needs to go after DataSource binding... maybe because it's unsupported?
            chklstItems.ItemCheck += Calculate_Click;

            CenterToParent();
        }

        private void Calculate_Click(object sender, ItemCheckEventArgs e)
        {
            var monthTotal = (chklstItems.Items[e.Index] as DisplayItem<double>).Value;

            _total += monthTotal * (e.NewValue == CheckState.Checked ? 1 : -1);

            lblTotal.SetBalance(_total);
        }
    }
}
