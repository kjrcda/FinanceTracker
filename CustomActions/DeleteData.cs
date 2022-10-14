using FileInfo;
using System.Collections;
using System.ComponentModel;
using System.IO;

namespace CustomActions
{
    [RunInstaller(true)]
    public partial class DeleteData : System.Configuration.Install.Installer
    {
        public override void Uninstall(IDictionary savedState)
        {
            base.Uninstall(savedState);

            if (Directory.Exists(SaveLocation.ApplicationPath))
            {
                Directory.Delete(SaveLocation.ApplicationPath, true);
            }
        }
    }
}
