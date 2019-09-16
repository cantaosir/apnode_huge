@cd /d %~dp0
@set pack_path=%~dp0
@REM 
@echo %pack_path%data
@echo if lost msvcrt120 go and download from 
@echo https://www.microsoft.com/en-us/download/details.aspx?id=40784 
@if exist %pack_path%data goto :start_mysql
@mkdir %pack_path%data
@%pack_path%bin\mysqld.exe --verbose --help >help.txt
@%pack_path%bin\mysqld.exe --initialize  --datadir=%pack_path%data
@REM @%pack_path%bin\mysqld.exe --initialize  --datadir=%pack_path%data --defaults-file=%pack_path%my.ini 
@echo.
@echo default password is in err.log
@echo.
@notepad %pack_path%data\err.log


@:start_mysql
@netstat -ano | find "LISTENING"
@netstat -ano | find "3306"
@netstat -ano | find "mysql"
@echo starting mysqld 
@.\bin\mysqld.exe --standalone
@pause