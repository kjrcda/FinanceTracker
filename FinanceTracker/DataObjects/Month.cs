using System;
using System.Collections.Generic;

namespace FinanceTracker.DataObjects
{
    public class Month
    {
        public Guid Identifier = new();
        public string MonthName = "";
        public List<double> MonthProj = new();
        public List<FinanceEntry> MonthInfo = new();

        public Month() { }

        public Month(string name, List<double> proj, List<FinanceEntry> list)
        {
            MonthName = name;
            MonthProj = proj;
            MonthInfo = list;
        }
    }
}
