using System;

namespace FinanceTracker.DataObjects
{
    public class FinanceEntry
    {
        public int ID = -1;
        public int Category = -1;
        public double Amount = -1;
        public String Place = "";
        public String Description = "";

        public FinanceEntry(int cat, double amt, String pl, String desc)
        {
            ID = Utilities.GetNextID();
            Category = cat;
            Amount = amt;
            Place = pl;
            Description = desc;
        }

        public FinanceEntry() { }

        public void Set(int cat, double amt, String pl, String desc)
        {
            Category = cat;
            Amount = amt;
            Place = pl;
            Description = desc;
        }
    }
}
