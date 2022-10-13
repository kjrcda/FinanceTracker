using System;
using System.Windows.Forms;
using FinanceTracker.DataObjects;
using FinanceTracker.Resources;

namespace FinanceTracker
{
    public static  class UIHelper
    {

#region PublicFunctions

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

        public static void CloseWindow(object sender, EventArgs e)
        {
            ((Button)sender).Parent.Dispose();
        }

#endregion
    }
}
