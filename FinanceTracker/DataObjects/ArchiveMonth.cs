using System.Collections.Generic;
using System.Linq;

namespace FinanceTracker.DataObjects
{
    public class ArchiveMonth : Month
    {
        public double MonthProjTotal;
        public double MonthInfoTotal;

        public ArchiveMonth() { }

        public ArchiveMonth(string name, List<double> proj, List<FinanceEntry> list)
            : base(name, proj, list)
        {
            MonthProjTotal = proj.Sum();
            MonthInfoTotal = list.Sum(item => item.Amount);
        }

        public double GetSpending() => MonthProjTotal - MonthInfoTotal;
    }
}
