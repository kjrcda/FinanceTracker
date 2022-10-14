using FinanceTracker.Resources;
using System.Windows.Forms;

namespace FinanceTracker.Extensions
{
    public static class LabelExtensions
    {
        /// <summary>
        /// Set the value of the label as a dollar amount and color it green if positive, red if negative, and black if zero
        /// </summary>
        public static void SetBalance(this Label label, double balance)
        {
            label.Text = balance.ToString(Formats.MoneyFormat);

            if (balance < 0)
            {
                label.ForeColor = System.Drawing.Color.Red;
            }
            else if (balance > 0)
            {
                label.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label.ForeColor = System.Drawing.Color.Black;
            }
        }
    }
}
