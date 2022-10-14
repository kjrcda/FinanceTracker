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

        /// <summary>
        /// Read the file contents dynamically and cast to type T
        /// </summary>
        /// <remarks>If nothing to read then return and empty object of type T</remarks>
        /// <exception cref="Exception">Couldn't read file properly</exception>
        public static T ReadXmlFile<T>(string name)
        {
            T list = default;
            try
            {
                var xml = File.ReadAllText(Path.Combine(SaveLocation.DataPath, name));

                if (EncryptionEnabled)
                {
                    xml = Encryption.Encryption.Decrypt(xml, Encryption.Encryption.Crypto, Encryption.Encryption.Vector);
                }

                using (var xreader = XmlReader.Create(new StringReader(xml)))
                {
                    xreader.MoveToContent();
                    list = (T)new XmlSerializer(typeof(T)).Deserialize(xreader);
                }
            }
            catch (FileNotFoundException)
            {
                //keep going the file hasnt been created yet
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(SaveLocation.DataPath);
            }
            catch (XmlException)
            {
                //Chances are there is a discrepancy between encrypted and non encrypted files
                File.Copy(Path.Combine(SaveLocation.DataPath, name), Path.Combine(SaveLocation.DataPath, name + "_backup"), true);
            }
            catch (FormatException)
            {
                //Chances are there is a discrepancy between encrypted and non encrypted files
                File.Copy(Path.Combine(SaveLocation.DataPath, name), Path.Combine(SaveLocation.DataPath, name + "_backup"), true);
            }
            catch (Exception e)
            {
                throw new Exception($"Error reading file {name}", e);
            }

            return list ?? (T)Activator.CreateInstance(typeof(T));
        }

        /// <exception cref="Exception">Something went wrong writing to file</exception>
        public static void WriteXmlFile<T>(string name, T list)
        {
            try
            {
                using (var writer = new StringWriter())
                {
                    var serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(writer, list);
                    var xml = writer.ToString();

                    if (EncryptionEnabled)
                    {
                        xml = Encryption.Encryption.Encrypt(xml, Encryption.Encryption.Crypto, Encryption.Encryption.Vector);
                    }

                    File.WriteAllText(Path.Combine(SaveLocation.DataPath, name), xml);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Error writing to file {name}", e);
            }
        }

        public static int BackupFiles(string filename)
        {
            var zipFile = new FileStream(filename, FileMode.Create);
            var numFilesBackedUp = 0;

            using (var archive = new ZipArchive(zipFile, ZipArchiveMode.Create))
            {
                foreach (var name in FileNames.Names)
                {
                    try
                    {
                        archive.CreateEntryFromFile(Path.Combine(SaveLocation.DataPath, name), name);
                        numFilesBackedUp++;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No file " + name + " generated to backup yet. Continuing...", "File Not Backed Up");
                    }
                }
            }

            return numFilesBackedUp;
        }

        public static int ImportFiles(string filename)
        {
            var numFilesImported = 0;
            //check to see if files are in the .zip, skip archFile though its not required
            var archive = ZipFile.OpenRead(filename);
            var hasAll = FileNames.Names
                .Where(name => string.Compare(name, FileNames.ArchiveFile, StringComparison.CurrentCultureIgnoreCase) != 0)
                .All(name => archive.Entries.Count(item => string.Equals(item.Name, name, StringComparison.CurrentCultureIgnoreCase)) == 1);

            if (!hasAll) //if cuurent month file missing, cancel
            {
                MessageBox.Show("The selected file does not have the required files", "Required Files Missing");
                return 0;
            }

            //otherwise import files
            foreach (var name in FileNames.Names)
            {
                var fName = name;
                var archiveEntry = archive.Entries.Where(item => string.Equals(item.Name, fName, StringComparison.CurrentCultureIgnoreCase));
                var fNamePath = Path.Combine(SaveLocation.DataPath, fName);

                var zipArchiveEntries = archiveEntry.ToList();
                if (!zipArchiveEntries.Any()) //will only ever be archives
                {
                    MessageBox.Show("No file " + fName + " to be found. It will not be imported.\nThe current archive file will be deleted.", "File Not Found");
                    if (File.Exists(fNamePath))
                    {
                        File.Delete(fNamePath);
                    }
                }
                else
                {
                    zipArchiveEntries.First().ExtractToFile(fNamePath, true);
                    numFilesImported++;
                }
            }

            return numFilesImported;
        }

    }
}
