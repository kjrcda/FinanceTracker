using System.Collections.Generic;
using System.Windows.Forms;
using FinanceTracker.DataObjects;

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
                chklstItems.Items.Add(month.MonthName);
            chklstItems.ItemCheck += Calculate_Click;
            CenterToParent();
        }

        private void Calculate_Click(object sender, ItemCheckEventArgs e)
        {
            var entry = _totalsList.Find(item => item.MonthName == chklstItems.Items[e.Index].ToString());
            if (e.NewValue == CheckState.Checked)
                _total += entry.MonthProjTotal-entry.MonthInfoTotal;
            else
                _total -= entry.MonthProjTotal - entry.MonthInfoTotal;
            UIHelper.LabelColor(_total, lblTotal);
        }
    }
}
