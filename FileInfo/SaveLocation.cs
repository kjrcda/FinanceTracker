namespace FileInfo
{
    public static class SaveLocation
    {
        public static string FolderName { get; } = "FinanceTracker";

#if DEBUG
        public static string Path {
            get {
                var currentLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
                return System.IO.Path.Combine(System.IO.Path.GetDirectoryName(currentLocation), FolderName);
            }
        }
#else
        public static string Path { get; } = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), FolderName);
#endif
    }
}
