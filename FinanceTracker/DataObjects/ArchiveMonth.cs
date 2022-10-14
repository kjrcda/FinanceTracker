using System.Collections.Generic;
using System.Linq;

namespace FinanceTracker.DataObjects
{
    public class ArchiveMonth : Month
    {
        public double ProjectionTotal;
        public double FinanceEntriesTotal;

        public ArchiveMonth() { }

        public ArchiveMonth(Month activeMonth) : base(activeMonth)
        {
            ProjectionTotal = Projections.Sum();
            FinanceEntriesTotal = FinanceEntries.Sum(e => e.Amount);
        }

        public double GetSpendingTotal() => ProjectionTotal - FinanceEntriesTotal;
    }
}
