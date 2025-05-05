# MSE-definition-updater
A third-party tool to update Microsoft Security Essentials malware definitions.

Ever since Microsoft Security Essentials stopped receiving automatic malware definition updates, this tool allows you to restore its ability to update definitions automatically. It works on Windows Vista and Windows 7. Default install directory is at drive C.
You will need to update your root certificates and install Service Pack 1 (Win7) or SP2 (Win Vista) before installing this program.


**How does this program update MSE's malware definitions?**

When Windows starts up, this program will start downloading the latest malware definition from Microsoft and installs it silently.

If the program is no longer functioning correctly, please submit an issue on GitHub so it can be reviewed.

NOTE: It downloads the definition updates directly from Microsoft and not other sources.

**More detail of MSE definition updater files**

All the .exe files are just bat to exe conversion. I had to do it to make the batch files run as administrator to apply the "Run" registry key as for some reason I can't make inno setup apply the registry keys.

Only "wget.exe" is not my  program. You can find more info about wget here: https://www.gnu.org/software/wget/

"hide.vbs" is to hide the "Update.cmd"/MSE updater on startup so that it doesn't annoy the user while it is updating MSE definition

The false positive is mostly from the bat to exe conversion, I will try to fix it.
