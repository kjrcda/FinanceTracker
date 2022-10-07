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

        public Month(Month month)
        {
            Name = month.Name;
            Projections = month.Projections;
            FinanceEntries = month.FinanceEntries;
        }
    }
}
