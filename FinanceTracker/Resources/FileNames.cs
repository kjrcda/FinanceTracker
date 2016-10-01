using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FinanceTracker.Resources
{
    public static class FileNames
    {
        public const string SaveFile = "file." + FileExtensions.Ftf;
        public const string ProjectionFile = "projFile." + FileExtensions.Ftf;
        public const string ArchiveFile = "archFile." + FileExtensions.Ftf;

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

        public static IEnumerable<string> Where(Func<string, bool> predicate)
        {
            return Members.Where(predicate);
        }
    }
}
