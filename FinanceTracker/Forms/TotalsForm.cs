using System.Collections.Generic;
using System.Windows.Forms;
using FinanceTracker.DataObjects;
using FinanceTracker.Extensions;

namespace FinanceTracker.Forms
{
    public partial class TotalsForm : Form
    {
        private readonly List<ArchiveMonth> _totalsList;
        private double _total;

        public TotalsForm(List<ArchiveMonth> list)
        {
            InitializeComponent();
            

            _totalsList = list;
            foreach(var month in _totalsList)
                chklstItems.Items.Add(month.Name);
            chklstItems.ItemCheck += Calculate_Click;
            CenterToParent();
        }

        private void Calculate_Click(object sender, ItemCheckEventArgs e)
        {
            var entry = _totalsList.Find(item => item.Name == chklstItems.Items[e.Index].ToString());
            if (e.NewValue == CheckState.Checked)
                _total += entry.ProjectionTotal-entry.FinanceEntriesTotal;
            else
                _total -= entry.ProjectionTotal - entry.FinanceEntriesTotal;
            lblTotal.SetBalance(_total);
        }
    }
}
