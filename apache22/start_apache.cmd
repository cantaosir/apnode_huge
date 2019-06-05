@cd /d %~dp0
@netstat -ano | find "LISTENING"
@REM PHP54TS\php.exe -S 127.0.0.1:80 -t .\htdocs
@echo.
@type conf\httpd.conf  | find "Listen"
@echo.
@bin\httpd.exe -w -d . -f conf\httpd.conf -t
@bin\httpd.exe -w -d . -f conf\httpd.conf -M
@bin\httpd.exe -w -d . -f conf\httpd.conf -S
@echo.
@type conf\httpd.conf  | find "ServerRoot" 
@type conf\httpd.conf  | find "DocumentRoot" 
@type conf\vhost.conf  | find "DocumentRoot" 
@echo.
@echo.
@bin\httpd.exe -w -d . -f conf\httpd.conf -T
