using FileInfo;
using System;
using System.Collections;
using System.ComponentModel;
using System.IO;

namespace CustomsActions
{
    [RunInstaller(true)]
    public partial class DeleteData : System.Configuration.Install.Installer
    {
        public override void Uninstall(IDictionary savedState)
        {
            base.Uninstall(savedState);

            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), SaveLocation.FolderName);
            if(Directory.Exists(path))
                Directory.Delete(path, true);
        }
    }
}
