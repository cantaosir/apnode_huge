@cd /d %~dp0
@echo.
@echo 当前9006占用
@netstat -ano | find "LISTENING" | FIND "9006"
@echo.
@echo 运行PHPFPM
@phpfpm.exe "%~dp0php-cgi.exe -c %~dp0php.ini" -n 2 -i 127.0.0.1 -p 9006 -r "%~dp0"
@REM php-cgi.exe -b 127.0.0.1:9000 -c .\php.ini
@REM phpfpm.exe php-cgi.exe -c ./php.ini -n 2 -i 127.0.0.1 -p 9006 -r ./
@REM php -S 127.0.0.1:80 -t ..\apache22\htdocs
@REM PHP54TS\php.exe -S 127.0.0.1:80 -t .\htdocs
@REM echo.
@REM type conf\httpd.conf  | find "Listen"
@REM echo.
@REM bin\httpd.exe -w -d . -f conf\httpd.conf -t
@REM bin\httpd.exe -w -d . -f conf\httpd.conf -M
@REM bin\httpd.exe -w -d . -f conf\httpd.conf -S
@REM echo.
@REM type conf\httpd.conf  | find "ServerRoot" 
@REM type conf\httpd.conf  | find "DocumentRoot" 
@REM type conf\vhost.conf  | find "DocumentRoot" 
@REM echo.
@REM echo.
@REM bin\httpd.exe -w -d . -f conf\httpd.conf -T
