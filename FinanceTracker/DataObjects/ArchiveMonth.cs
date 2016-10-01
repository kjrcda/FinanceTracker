using System;
using System.Collections.Generic;

namespace FinanceTracker.DataObjects
{
    public class ArchiveMonth
    {
        public String MonthName="";
        public List<double> MonthProj = new List<double>();
        public List<FinanceEntry> MonthInfo = new List<FinanceEntry>();
        public double MonthProjTotal;
        public double MonthInfoTotal;

        public ArchiveMonth() { }

        public ArchiveMonth(String name, List<double> proj, double projTotal, List<FinanceEntry> list, double listTotal)
        {
            MonthName = name;
            MonthProj = proj;
            MonthProjTotal = projTotal;
            MonthInfo = list;
            MonthInfoTotal = listTotal;
        }
    }
}
