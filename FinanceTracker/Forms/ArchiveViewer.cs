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
        private readonly List<List<Label>> _labels = new();
        private List<double> _categorySums;
        private int _currColumn = -1;

        public ArchiveViewer(List<ArchiveMonth> archivedMonths)
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

            cboSelector.DisplayMember = nameof(ArchiveMonth.Name); // Needs to go before DataSource binding so that the select action executes properly
            cboSelector.DataSource = archivedMonths;

            CenterToParent();
        }

        private void PopulateList(ArchiveMonth month)
        {
            _categorySums = Enumerable.Repeat(0.0, Categories.Length).ToList();

            foreach (var entry in month.FinanceEntries)
            {
                _categorySums[entry.Category] += entry.Amount;
                lstItems.LoadItem(entry);
            }
        }

        private void Recalculate(ArchiveMonth month)
        {
            var j = 0;
            foreach (var list in _labels)
            {
                var i = 0;
                foreach (var label in list)
                {
                    label.Text = month.Projections[i++].ToString(Formats.MoneyFormat);

                    if (j == 1)
                    {
                        label.Text = _categorySums[i - 1].ToString(Formats.MoneyFormat);
                    }
                    else if (j == 2)
                    {
                        label.SetBalance(month.Projections[i - 1] - _categorySums[i - 1]);
                    }
                }
                j++;
            }

            lblPTotalAmt.Text = month.ProjectionTotal.ToString(Formats.MoneyFormat);
            lblCTotalAmt.Text = month.FinanceEntriesTotal.ToString(Formats.MoneyFormat);
            lblTotalAmt.SetBalance(month.GetSpendingTotal());
        }

        private void lstItems_ColumnSort(object sender, ColumnClickEventArgs e)
        {
            _currColumn = (sender as ListView).ColumnSort(_currColumn, e.Column);
        }

        private void cboSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            var month = cboSelector.SelectedItem as ArchiveMonth;

            lstItems.ClearList();
            PopulateList(month);
            Recalculate(month);
        }
    }
}
