using System;
using System.Windows.Forms;
using FinanceTracker.DataObjects;
using FinanceTracker.Resources;

namespace FinanceTracker
{
    public static  class UIHelper
    {

#region PublicFunctions

        public static void LabelColor(double amt, Label lbl)
        {
            lbl.Text = amt.ToString(Formats.MoneyFormat);
            if (amt < 0)
                lbl.ForeColor = System.Drawing.Color.Red;
            else if (amt > 0)
                lbl.ForeColor = System.Drawing.Color.Green;
            else
                lbl.ForeColor = System.Drawing.Color.Black;
        }

        public static void CheckEscape(object sender, KeyEventArgs e)
        {
            var form = ((Control) sender).FindForm();

            if (e.KeyCode == Keys.Escape && form != null)
            {
                form.Dispose();
                e.Handled = true;
            }
        }

        public static void CheckReturn(object sender, KeyEventArgs e, Action<object, EventArgs> success)
        {
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
            {
                success(sender, e);
                e.Handled = true;
            }
        }

        public static void CheckKeyPress(object sender, KeyEventArgs e, Action<object, EventArgs> success)
        {
            CheckEscape(sender, e);
            CheckReturn(sender, e, success);
        }

        public static void LoadItem(ListView list, FinanceEntry item)
        {
            var row = new ListViewItem(new[] { "" + item.ID, Categories.Get(item.Category), item.Amount.ToString(Formats.MoneyFormat), item.Place, item.Description });
            list.Items.Add(row);
            list.Items[list.Items.Count - 1].EnsureVisible();
        }

        public static void ClearList(ListView list)
        {
            foreach (ListViewItem item in list.Items)
                list.Items.Remove(item);
        }

        public static void CloseWindow(object sender, EventArgs e)
        {
            ((Button)sender).Parent.Dispose();
        }

#endregion

#region PrivateFunctions

#endregion
    }
}
