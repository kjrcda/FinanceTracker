using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FinanceTracker.DataObjects;
using FinanceTracker.Resources;

namespace FinanceTracker.Forms
{
    public partial class ArchiveViewer : Form
    {
        private readonly List<ArchiveMonth> _info;
        private readonly List<List<Label>> _labels = new List<List<Label>>();
        private List<double> _currData; 
        private List<double> _projData;
        private double _projTotal, _currTotal;
        private int _currColumn = -1;

        public ArchiveViewer(List<ArchiveMonth> arch)
        {
            InitializeComponent();

            var temp = new List<Label>
            {
                lblPRentAmt,
                lblPPhoneAmt,
                lblPEntertainmentAmt,
                lblPGroceryAmt,
                lblPTransportationAmt,
                lblPEatingAmt,
                lblPOtherAmt
            };
            _labels.Add(temp);
            temp = new List<Label>
            {
                lblCRentAmt,
                lblCPhoneAmt,
                lblCEntertainmentAmt,
                lblCGroceryAmt,
                lblCTransportationAmt,
                lblCEatingAmt,
                lblCOtherAmt
            };
            _labels.Add(temp);
            temp = new List<Label>
            {
                lblRentAmt,
                lblPhoneBillAmt,
                lblEntertainmentAmt,
                lblGroceryAmt,
                lblTransportationAmt,
                lblEatOutAmt,
                lblOtherAmt
            };
            _labels.Add(temp);

            _info = arch;
            foreach(var item in _info)
                cboSelector.Items.Add(item.MonthName);
            cboSelector.SelectedItem = cboSelector.Items[0];

            cboSelector_SelectedIndexChanged(null, null);

            CenterToParent();
        }

        private void PopulateList()
        {
            var month = _info.Find(item => item.MonthName == (String)cboSelector.SelectedItem);
            _projData = month.MonthProj;
            _projTotal = month.MonthProjTotal;
            _currTotal = month.MonthInfoTotal;
            foreach (var item in month.MonthInfo)
            {
                _currData[item.Category] += item.Amount;
                Utilities.LoadItem(lstItems, item);
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
                    label.Text = _projData[i++].ToString(Formats.MoneyFormat);
                    if (j == 1)
                        label.Text = _currData[i - 1].ToString(Formats.MoneyFormat);
                    else if (j == 2)
                        Utilities.LabelColor(_projData[i - 1] - _currData[i - 1], label);
                }
                j++;
            }
            lblPTotalAmt.Text = _projTotal.ToString(Formats.MoneyFormat);
            lblCTotalAmt.Text = _currTotal.ToString(Formats.MoneyFormat);
            Utilities.LabelColor(_projTotal - _currTotal, lblTotalAmt);
        }

        private void InitProjectionData()
        {
            _currData = new List<double>(Categories.Length);
            _projData = new List<double>(Categories.Length);
            for (var i = 0; i < Categories.Length; i++)
            {
                _projData.Add(0);
                _currData.Add(0);
            }
        }

        private void lstItems_ColumnSort(object sender, ColumnClickEventArgs e)
        {
            _currColumn = ListSorter.ColumnSort((ListView)sender, e, _currColumn);
        }

        private void cboSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utilities.ClearList(lstItems);
            InitProjectionData();
            PopulateList();
        }

        private void CheckEscape(object sender,KeyEventArgs e)
        {
            Utilities.CheckEscape(this, sender, e);
        }
    }
}
