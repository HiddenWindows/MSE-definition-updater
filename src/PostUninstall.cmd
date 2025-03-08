
@echo off
title Uninstalling MSE 3rd party definition updater...
reg delete HKLM\Software\Microsoft\Windows\CurrentVersion\Run /v MSEDefUpdater /f
exit