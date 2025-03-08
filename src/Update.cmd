@echo off
cls
title Microsoft Security Essentials 3rd party definition updater by HiddenWindows
echo Updating MSE to the latest definition update...
timeout /T 20 /NOBREAK > Nul
cd "%systemdrive%\MSEDefinitionUpdater"
del MSEUpd.exe
if exist "%systemdrive%\Program Files (x86)" goto x64
if not exist "%systemdrive%\Program Files (x86)" goto x86
:x64
wget --no-check-certificate -O "MSEUpd.exe" "https://go.microsoft.com/fwlink/?LinkID=121721&arch=x64"
if not exist MSEUpd.exe exit
start /wait MSEUpd.exe
exit
:x86
wget --no-check-certificate -O "MSEUpd.exe" "https://go.microsoft.com/fwlink/?LinkID=121721&arch=x86"
if not exist MSEUpd.exe exit
start /wait MSEUpd.exe
exit
