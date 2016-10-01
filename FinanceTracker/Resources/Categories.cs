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

        public static int Length
        {
            get { return Members().Length; }
        }

        public static string Get(int index)
        {
            return Members()[index];
        }

        public static string[] Members()
        {
            return new[] {Rent, PhoneBill, Entertainment, Grocery, Transportation, EatingOut, Other};
        }
    }
}
