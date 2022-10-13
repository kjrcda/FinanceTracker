using FileInfo;
using System.Collections.Generic;

namespace FinanceTracker.Resources
{
    public static class FileNames
    {
        public static string SaveFile
        {
            get => "file." + FileExtension.Ftf;
        }

        public static string ArchiveFile
        {
            get => "archFile." + FileExtension.Ftf;
        }

        public static IEnumerable<string> Names => new List<string>() { SaveFile, ArchiveFile };
    }
}
