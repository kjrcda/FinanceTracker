using System.Collections.Generic;
using System.Linq;

namespace FinanceTracker.DataObjects
{
    public class ArchiveMonth : Month
    {
        public double ProjectionTotal;
        public double FinanceEntriesTotal;

        public ArchiveMonth() { }

        public ArchiveMonth(string name, List<double> proj, List<FinanceEntry> list)
            : base(name, proj, list)
        {
            ProjectionTotal = proj.Sum();
            FinanceEntriesTotal = list.Sum(item => item.Amount);
        }

        public double GetSpending() => ProjectionTotal - FinanceEntriesTotal;
    }
}
