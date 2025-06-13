# MSE Definition updater
A third-party tool to update Microsoft Security Essentials malware definitions.

**Please read this before installing**

Ever since Microsoft Security Essentials stopped receiving automatic malware definition updates, this tool allows you to restore its ability to update definitions automatically. It works on Windows Vista and Windows 7. Default install directory is at drive C.
You will need to update your root certificates and install Service Pack 1 (Win7) or SP2 (Win Vista) before installing this program. It is also recommended that you update your system.
Please install update "KB4474419" before installing this program (Note, for Windows Vista install the Server 2008 update) and if it still doesn't work, file a issue.

This program is not not affiliated with Microsoft. This is a 3rd party program, please use it at your own risk. However, it has been tested and works fine.
You can also use other tools like LegacyUpdate if you want, this tool isn't the best, but it does the job.


**How does this program update MSE's malware definitions?**

When Windows starts up, this program will start downloading the latest malware definition from Microsoft and installs it silently.

If the program is no longer functioning correctly, please submit an issue on GitHub so it can be reviewed.

NOTE: It downloads the definition updates directly from Microsoft and not other sources.

**More detail of MSE definition updater files**

"PostInstall.exe" is used to add MSE Definition updater to startup and removes it from startup when uninstall

Only "wget.exe" is not my  program. You can find more info about wget here: https://www.gnu.org/software/wget/

"hide.vbs" is to hide the "Update.cmd"/MSE updater on startup so that it doesn't annoy the user while it is updating MSE definition
