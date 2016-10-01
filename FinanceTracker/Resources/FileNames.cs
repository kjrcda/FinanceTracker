using System;
using System.Collections.Generic;
using System.Linq;

namespace FinanceTracker.Resources
{
    public static class FileNames
    {
        public const string SaveFile = "file." + FileExtensions.Ftf;
        public const string ProjectionFile = "projFile." + FileExtensions.Ftf;
        public const string ArchiveFile = "archFile." + FileExtensions.Ftf;

        public static string[] Members()
        {
            return new [] { SaveFile, ProjectionFile, ArchiveFile };
        }

        public static IEnumerable<string> Where(Func<string, bool> predicate)
        {
            return Members().Where(predicate);
        }
    }
}
