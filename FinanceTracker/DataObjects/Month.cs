using System;
using System.Collections.Generic;

namespace FinanceTracker.DataObjects
{
    public class Month
    {
        public Guid Identifier = Guid.NewGuid();
        public string Name = "";
        public List<double> Projections = new();
        public List<FinanceEntry> FinanceEntries = new();

        public Month() { }

        public Month(string name, List<double> proj, List<FinanceEntry> list)
        {
            Name = name;
            Projections = proj;
            FinanceEntries = list;
        }
    }
}
