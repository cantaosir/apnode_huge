@echo off
@REM MySQL 5.6.30
@REM don't modify the caller's environment
@REM setlocal
@REM Set up prog to be the path of this script, including following symlinks,
@REM and set up progdir to be the fully-qualified pathname of its directory.
@REM set prog=%~f0
@REM Grab current directory before we change it
@REM set work_dir=%cd%
@REM Change current directory and drive to where the script is, to avoid
@REM issues with directories containing whitespaces.
@REM
@cd /d %~dp0
@set pack_path=%~dp0
@set path=%path%;%pack_path%bin
@cls
:pack_readme
@echo.
@echo. 
:pack_config
@echo. 
@echo start config pack
REM start %pack_path%bin\notepad2\Notepad2.exe %pack_path%my.ini
:pack_install
@echo.
@echo any key to initialize and search A temporary password is generated for root
@pause
REM %pack_path%bin\mysqld.exe --install WinswMySQL56x64 --defaults-file=%pack_path%my.ini 
%pack_path%bin\mysqld.exe --initialize --defaults-file=%pack_path%my.ini  --datadir=%pack_path%data
start notepad data/err.log
:pack_install
@echo.
@echo any key to install 
@pause
%pack_path%bin\mysqld.exe --install WinswMySQL56x64 --defaults-file=%pack_path%my.ini 
REM %pack_path%bin\mysqld.exe --initialize --defaults-file=%pack_path%my.ini  --datadir=%pack_path%data

:pack_start
echo.
echo any key to start 
pause 
REM sc start WinswMySQL56x64 
:pack_stop
echo.
echo any key to stop 
pause 
REM sc stop WinswMySQL56x64 
:pack_uninstall
echo any key to uninstall
echo.
pause 
REM sc delete WinswMySQL56x64
