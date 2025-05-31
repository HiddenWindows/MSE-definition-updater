using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;

namespace PostInstall
{
    class Program
    {
        static void Main(string[] args)
        {
            
            foreach (string argument in args)
            {

           
                if (argument.ToLower() == "/i")
                {
                    // Adds MSE Definition updater to startup.

                    try
                    {
                        Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run")
                            .SetValue("MSEDefUpdater",
                            (object)"wscript.exe \"C:\\MSEDefinitionUpdater\\hide.vbs\" \"C:\\MSEDefinitionUpdater\\Update.cmd\"",
                            RegistryValueKind.String);

                    }
                    catch
                    {
                        MessageBox.Show("Error adding MSE Definition updater to startup. Please reinstall this program.", "MSE Definition updater uninstall and install script", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Application.Exit();

                }
                else if (argument.ToLower() == "/u")
                {
                    //Removes MSE Definition updater from startup.

                    try
                    {
                        Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run").DeleteValue("MSEDefUpdater");
                    }
                    catch
                    {
                        MessageBox.Show("Error removing MSE Definition updater from startup. Please remove the registry value manually.", "MSE Definition updater uninstall and install script", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Application.Exit();
                }
            }
        }
    }
}