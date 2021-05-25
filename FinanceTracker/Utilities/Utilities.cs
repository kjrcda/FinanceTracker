using System.Collections.Generic;
using FinanceTracker.DataObjects;

namespace FinanceTracker
{
    public static class Utilities
    {
        private static int _nextID;
        
        public static void LoadID(List<FinanceEntry> list)
        {
            if (list.Count == 0)
                _nextID = 1;
            else
                _nextID = list[^1].ID + 1;
        }

        public static int GetNextID()
        {
            return _nextID++;
        }
    }
}
