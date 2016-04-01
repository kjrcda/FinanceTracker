using System;
using System.Collections;
using System.ComponentModel;
using System.IO;

namespace CustomsActions
{
    [RunInstaller(true)]
    public partial class Installer : System.Configuration.Install.Installer
    {
        public override void Uninstall(IDictionary savedState)
        {
            base.Uninstall(savedState);

            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Finance Tracker");
            if(Directory.Exists(path))
                Directory.Delete(path, true);
        }
    }
}
