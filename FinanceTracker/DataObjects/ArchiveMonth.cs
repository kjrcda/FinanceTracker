using System.Linq;

namespace FinanceTracker.DataObjects
{
    public class ArchiveMonth : Month
    {
        public double ProjectionTotal { get; set; }
        public double FinanceEntriesTotal { get; set; }

        public ArchiveMonth() { }

        public ArchiveMonth(Month activeMonth) : base(activeMonth)
        {
            ProjectionTotal = Projections.Sum();
            FinanceEntriesTotal = FinanceEntries.Sum(e => e.Amount);
        }

        public double GetSpendingTotal() => ProjectionTotal - FinanceEntriesTotal;
    }
}
