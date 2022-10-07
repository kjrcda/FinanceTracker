using System.Collections.Generic;

namespace FinanceTracker.DataObjects
{
    public class ArchiveMonth : Month
    {
        public double MonthProjTotal;
        public double MonthInfoTotal;

        public ArchiveMonth() { }

        public ArchiveMonth(string name, List<double> proj, double projTotal, List<FinanceEntry> list, double listTotal)
            : base(name, proj, list)
        {
            MonthProjTotal = projTotal;
            MonthInfoTotal = listTotal;
        }
    }
}
