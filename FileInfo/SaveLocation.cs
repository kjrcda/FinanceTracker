using System;

namespace FileInfo
{
    public static class SaveLocation
    {
        public static string FolderName { get; } = "FinanceTracker";
        public static string Path { get; } = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), FolderName);
    }
}
