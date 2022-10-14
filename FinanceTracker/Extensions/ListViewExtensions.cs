using FinanceTracker.DataObjects;
using FinanceTracker.Resources;
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
    }
}
