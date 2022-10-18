using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FinanceTracker.DataObjects;
using FinanceTracker.Extensions;
using FinanceTracker.Resources;

namespace FinanceTracker.Forms
{
    public partial class ArchiveViewer : Form
    {
        private readonly List<ArchiveMonth> _archivedMonths;
        private readonly List<List<Label>> _labels = new();
        private ArchiveMonth _selectedMonth;
        private List<double> _categorySums;
        private int _currColumn = -1;

        public ArchiveViewer(List<ArchiveMonth> arch)
        {
            InitializeComponent();

            _labels.Add(new List<Label>
            {
                lblPRentAmt,
                lblPPhoneAmt,
                lblPEntertainmentAmt,
                lblPGroceryAmt,
                lblPTransportationAmt,
                lblPEatingAmt,
                lblPOtherAmt
            });

            _labels.Add(new List<Label>
            {
                lblCRentAmt,
                lblCPhoneAmt,
                lblCEntertainmentAmt,
                lblCGroceryAmt,
                lblCTransportationAmt,
                lblCEatingAmt,
                lblCOtherAmt
            });

            _labels.Add(new List<Label>
            {
                lblRentAmt,
                lblPhoneBillAmt,
                lblEntertainmentAmt,
                lblGroceryAmt,
                lblTransportationAmt,
                lblEatOutAmt,
                lblOtherAmt
            });

            _archivedMonths = arch;

            cboSelector.DisplayMember = nameof(ArchiveMonth.Name);
            cboSelector.DataSource = _archivedMonths;

            CenterToParent();
        }

        private void PopulateList(Guid identifier)
        {
            _selectedMonth = _archivedMonths.Find(month => month.Identifier == identifier);
            _categorySums = Enumerable.Repeat(0.0, Categories.Length).ToList();

            foreach (var entry in _selectedMonth.FinanceEntries)
            {
                _categorySums[entry.Category] += entry.Amount;
                lstItems.LoadItem(entry);
            }

            Recalculate();
        }

        private void Recalculate()
        {
            var j = 0;
            foreach (var list in _labels)
            {
                var i = 0;
                foreach (var label in list)
                {
                    label.Text = _selectedMonth.Projections[i++].ToString(Formats.MoneyFormat);
                    if (j == 1)
                        label.Text = _categorySums[i - 1].ToString(Formats.MoneyFormat);
                    else if (j == 2)
                        label.SetBalance(_selectedMonth.Projections[i - 1] - _categorySums[i - 1]);
                }
                j++;
            }
            lblPTotalAmt.Text = _selectedMonth.ProjectionTotal.ToString(Formats.MoneyFormat);
            lblCTotalAmt.Text = _selectedMonth.FinanceEntriesTotal.ToString(Formats.MoneyFormat);
            lblTotalAmt.SetBalance(_selectedMonth.GetSpendingTotal());
        }

        private void lstItems_ColumnSort(object sender, ColumnClickEventArgs e)
        {
            _currColumn = (sender as ListView).ColumnSort(_currColumn, e.Column);
        }

        private void cboSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            var month = (ArchiveMonth)cboSelector.SelectedItem;

            lstItems.ClearList();
            PopulateList(month.Identifier);
        }
    }
}
