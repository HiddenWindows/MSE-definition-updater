# MSE-definition-updater
A third-party tool to update Microsoft Security Essentials malware definitions.

Ever since Microsoft Security Essentials stopped receiving automatic malware definition updates, this tool allows you to restore its ability to update definitions automatically. It works on Windows Vista and Windows 7. Default install directory is at drive C.
All the .exe files are just bat to exe conversion. I had to do it to make the batch files run as administrator to apply the "Run" registry key as for some reason I can't make inno setup apply the registry keys.

**How does this program update MSE's malware definitions?**

When Windows starts up, this program will start downloading the latest malware definition from Microsoft and installs it silently.

If the program no longer work, contact me via reddit (u/HiddenWindows7601) or discord (HiddenWindows) and I will fix it.

NOTE: It downloads the definition updates directly from Microsoft and not other sources.
