
@echo off
title Installing MSE 3rd party definition updater...
reg add HKLM\Software\Microsoft\Windows\CurrentVersion\Run /v MSEDefUpdater /t REG_SZ /d "wscript.exe %systemdrive%\MSEDefinitionUpdater\hide.vbs %systemdrive%\MSEDefinitionUpdater\Update.cmd" /f
exit