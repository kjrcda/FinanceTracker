using System;
using System.IO;

namespace FileInfo
{
    public static class SaveLocation
    {
        public static string FolderName => "FinanceTracker";
        public static string LocalPath => ".";

        public static string ApplicationPath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), FolderName);

        public static string DataPath
        {
            get {
#if DEBUG
                return LocalPath;
#else
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), FolderName);
#endif
            }
        }
    }
}
