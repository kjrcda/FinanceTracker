using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FinanceTracker.Resources
{
    public static class Categories
    {
        public const string Rent = "Rent";
        public const string PhoneBill = "Phone Bill";
        public const string Entertainment = "Entertainment";
        public const string Grocery = "Grocery";
        public const string Transportation = "Transportation";
        public const string EatingOut = "Eating Out";
        public const string Other = "Other";

        private static int _length = -1;
        public static int Length
        {
            get
            {
                if (_length == -1)
                {
                    _length = Members.Count();
                }
                return _length;
            }
        }

        private static IEnumerable<string> _members;
        public static IEnumerable<string> Members
        {
            get
            {
                if (_members == null)
                {
                    _members = typeof (Categories).GetFields(BindingFlags.Static | BindingFlags.Public)
                        .Select(field => field.GetValue(null).ToString());
                }
                return _members;
            }
        }

        public static string Get(int index)
        {
            return Members.ElementAt(index);
        }
    }
}
