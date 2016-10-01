using System;
using System.Collections;
using System.Windows.Forms;

namespace FinanceTracker
{
    public static class ListSorter
    {
        public static int ColumnSort(ListView list, ColumnClickEventArgs e, int currColumn)
        {
            if (e.Column != currColumn)
            {
                currColumn = e.Column;
                if (list.Sorting == SortOrder.None && currColumn == 0)
                    list.Sorting = SortOrder.Descending;
                else
                    list.Sorting = SortOrder.Ascending;
            }
            else
                list.Sorting = list.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;

            list.Sort();
            list.ListViewItemSorter = new ListViewItemComparer(e.Column, list.Sorting);
            return currColumn;
        }

        private class ListViewItemComparer : IComparer
        {
            private readonly int _col;
            private readonly SortOrder _order;

            public ListViewItemComparer(int column, SortOrder order)
            {
                _col = column;
                _order = order;
            }

            public int Compare(object x, object y)
            {
                int returnVal;
                var xVal = ((ListViewItem)x).SubItems[_col].Text;
                var yVal = ((ListViewItem)y).SubItems[_col].Text;
                if (_col == 0)
                {
                    if (Convert.ToInt32(xVal) == Convert.ToInt32(yVal))
                        returnVal = 0;
                    else
                        returnVal = Convert.ToInt32(xVal) > Convert.ToInt32(yVal) ? 1 : -1;
                }
                else if (_col == 2)
                {
                    if (Math.Abs(Convert.ToDouble(xVal) - Convert.ToDouble(yVal)) < .005)
                        returnVal = 0;
                    else
                        returnVal = Convert.ToDouble(xVal) > Convert.ToDouble(yVal) ? 1 : -1;
                }
                else
                    returnVal = String.CompareOrdinal(xVal, yVal);

                if (_order == SortOrder.Descending)
                    returnVal *= -1;
                return returnVal;
            }
        }
    }
}
