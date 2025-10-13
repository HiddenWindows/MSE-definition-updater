# MSE definition updater
A third party tool to update Microsoft Security Essentials malware definitions.

**Please read this before installing. Do not ignore**

Ever since Microsoft Security Essentials (MSE) stopped receiving automatic malware definition updates, this tool allows you to restore its ability to update malware definitions automatically. It works on Windows Vista and Windows 7. Default install directory is at drive C.
You will need to update your root certificates and install Service Pack 1 (Win7) or SP2 (Win Vista) before installing this program. It is also recommended that you fully update your system.
Please install update "KB4474419" before installing this program (Note, for Windows Vista install the Server 2008 update) and if it still doesn't work, file an issue on github. After installing, you must restart your computer for the tool to take effect.

NOTE: This program doesn't modify Microsoft Security Essentials, you still will not be able to update malware definitions from MSE. Instead on every startup, this tool will update MSE malware definitions automatically. To manually update Microsoft Security Essentials you will need to type "C:\MSEDefinitionUpdater\Update.cmd" on the run box.

This program is not affiliated with Microsoft. This is a 3rd party program, please use it at your own risk. However, it has been tested and works fine.
I'd recommend you to use "Legacy Update" to update your old systems.


**How does this program update MSE's malware definitions?**

When Windows starts up, this program will start downloading the latest malware definition from Microsoft and installs it silently.

NOTE: It downloads the definition updates directly from Microsoft and not from other sources.

**More detail of MSE definition updater files**

"PostInstall.exe" is used to add MSE Definition updater to startup and removes it from startup when uninstall

"hide.vbs" is to hide the MSE updater on startup so that it doesn't annoy the user while it is updating MSE definition

"Update.cmd" is used to download the malware definitions from Microsoft and installs it.

"wget.exe" is not my  program. You can find more info about wget here: https://www.gnu.org/software/wget/








