using FileInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FinanceTracker.Resources
{
    public static class FileNames
    {
        public static readonly FileNameType SaveFile = new()
        {
            Name = "file." + FileExtension.Ftf,
            DataType = typeof(DataObjects.Month)
        };

        public static readonly FileNameType ArchiveFile = new()
        {
            Name = "archFile." + FileExtension.Ftf,
            DataType = typeof(List<DataObjects.ArchiveMonth>)
        };

        private static IEnumerable<FileNameType> _members;
        public static IEnumerable<FileNameType> Members
        {
            get
            {
                if (_members == null)
                {
                    _members = typeof (FileNames).GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.GetField)
                        .Select(field => (FileNameType)field.GetValue(null));
                }
                return _members;
            }
        }

        public static IEnumerable<string> Names
        {
            get { return Members.Select(fnt => fnt.Name); }
        }

        public static Dictionary<string, Type> Pairs
        {
            get
            {
                return Members.ToDictionary(member => member.Name, member => member.DataType);
            }
        }

        public static IEnumerable<FileNameType> Where(Func<FileNameType, bool> predicate)
        {
            return Members.Where(predicate);
        }
    }

    public class FileNameType
    {
        public string Name;
        public Type DataType;
    }
}
