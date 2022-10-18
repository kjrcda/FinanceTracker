namespace FinanceTracker.DataObjects
{
    public class DisplayItem<T>
    {
        public string Name { get; set; }
        public T Value { get; set; }
    }
}
