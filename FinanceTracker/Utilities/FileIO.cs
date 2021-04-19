using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using FileInfo;
using FinanceTracker.DataObjects;
using FinanceTracker.Resources;

namespace FinanceTracker
{
    public static class FileIO
    {
        private static bool EncryptionEnabled { get; } = false;

        /// <exception cref="Exception">Couldn't read file properly</exception>
        public static dynamic ReadFile(string name, Type objType)
        {
            dynamic list = null;
            try
            {
                var xml = File.ReadAllText(Path.Combine(SaveLocation.Path, name));

                if (EncryptionEnabled)
                {
                    xml = Encryption.Encryption.Decrypt(xml, Encryption.Encryption.Crypto, Encryption.Encryption.Vector);
                }

                using (var xreader = XmlReader.Create(new StringReader(xml)))
                {
                    xreader.MoveToContent();
                    list = new XmlSerializer(objType).Deserialize(xreader);
                }
            }
            catch (FileNotFoundException)
            {
                //keep going the file hasnt been created yet
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(SaveLocation.Path);
            }
            catch (XmlException)
            {
                //Chances are there is a discrepancy between encrypted and non encrypted files
                File.Copy(Path.Combine(SaveLocation.Path, name), Path.Combine(SaveLocation.Path, name + "_backup"), true);
            }
            catch (FormatException)
            {
                //Chances are there is a discrepancy between encrypted and non encrypted files
                File.Copy(Path.Combine(SaveLocation.Path, name), Path.Combine(SaveLocation.Path, name + "_backup"), true);
            }
            catch (Exception e)
            {
                throw new Exception($"Error reading file {name}", e);
            }

            return list;
        }

        /// <exception cref="Exception">Something went wrong writing to file</exception>
        public static void WriteFile(string name, Type objType, dynamic list)
        {
            try
            {
                using (var writer = new StringWriter())
                {
                    var serializer = new XmlSerializer(objType);
                    serializer.Serialize(writer, list);
                    var xml = writer.ToString();

                    if (EncryptionEnabled)
                    {
                        xml = Encryption.Encryption.Encrypt(xml, Encryption.Encryption.Crypto, Encryption.Encryption.Vector);
                    }

                    File.WriteAllText(Path.Combine(SaveLocation.Path, name), xml);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Error writing to file {name}", e);
            }
        }

        public static void BackupFiles(string filename)
        {
            var zipFile = new FileStream(filename, FileMode.Create);

            using (var archive = new ZipArchive(zipFile, ZipArchiveMode.Create))
            {
                foreach (var name in FileNames.Names)
                {
                    try
                    {
                        archive.CreateEntryFromFile(Path.Combine(SaveLocation.Path, name), name);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No file " + name + " generated to backup yet. Continuing...", "File Not Backed Up");
                    }
                }
            }
        }

        public static void ImportFiles(string filename, ref List<ArchiveMonth> archived)
        {
            //check to see if files are in the .zip, skip archFile though its not required
            var archive = ZipFile.OpenRead(filename);
            var hasAll = FileNames.Names.Where(name => String.Compare(name, FileNames.ArchiveFile.Name, StringComparison.CurrentCultureIgnoreCase) != 0).All(
                name => archive.Entries.Count(item => String.Equals(item.Name, name, StringComparison.CurrentCultureIgnoreCase)) == 1);

            if (!hasAll) //if file or projfile missing, cancel
            {
                MessageBox.Show("The selected file does not have the required files", "Required Files Missing");
                return;
            }

            //otherwise import files
            foreach (var name in FileNames.Names)
            {
                var fName = name;
                var archiveEntry = archive.Entries.Where(item => String.Equals(item.Name, fName, StringComparison.CurrentCultureIgnoreCase));
                var fNamePath = Path.Combine(SaveLocation.Path, fName);

                var zipArchiveEntries = archiveEntry.ToList();
                if (!zipArchiveEntries.Any()) //will only ever be archives
                {
                    MessageBox.Show("No file " + fName + " to be found. It will not be imported.\nThe current archive file will be deleted.", "File Not Found");
                    if (File.Exists(fNamePath))
                        File.Delete(fNamePath);
                    archived = new List<ArchiveMonth>();
                }
                else
                    zipArchiveEntries.First().ExtractToFile(fNamePath, true);
            }
        }

    }
}
