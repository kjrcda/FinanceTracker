using FinanceTracker.DataObjects;
using FinanceTracker.Resources;
using System;
using System.Collections;
using System.Windows.Forms;

namespace FinanceTracker.Extensions
{
    public static class ListViewExtensions
    {
        /// <summary>
        /// Remove items from a ListView programmatically by removing each item individually
        /// </summary>
        public static void ClearList(this ListView list)
        {
            foreach (ListViewItem item in list.Items)
            {
                list.Items.Remove(item);
            }
        }

        /// <summary>
        /// Load the FinanceEntry into the ListView so it appears in the list of items
        /// </summary>
        public static void LoadItem(this ListView list, FinanceEntry item)
        {
            var row = new ListViewItem(new[] { "" + item.ID, Categories.Get(item.Category), item.Amount.ToString(Formats.MoneyFormat), item.Place, item.Description });
            list.Items.Add(row);
            list.Items[^1].EnsureVisible();
        }

        /// <summary>
        /// Based on the currently sorted on column and the new column to sort by, sort the data according to new column for flip from ASC to DESC (or vice versa) if sorting on the same column
        /// </summary>
        /// /// <param name="currColumn">The current column being sorted on</param>
        /// <param name="newColumn">The new column to sort by</param>
        /// <returns>The column that will now be sorted on</returns>
        public static int ColumnSort(this ListView list, int currColumn, int newColumn)
        {
            if (currColumn != newColumn)
            {
                currColumn = newColumn;
                if (list.Sorting == SortOrder.None && currColumn == 0)
                {
                    list.Sorting = SortOrder.Descending;
                }
                else
                {
                    list.Sorting = SortOrder.Ascending;
                }
            }
            else
            {
                list.Sorting = list.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            }

            list.Sort();
            list.ListViewItemSorter = new ListViewItemComparer(currColumn, list.Sorting);
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
                {
                    returnVal = string.CompareOrdinal(xVal, yVal);
                }

                if (_order == SortOrder.Descending)
                {
                    returnVal *= -1;
                }

                return returnVal;
            }
        }
    }
}
