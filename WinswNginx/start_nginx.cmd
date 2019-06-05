@cd /d %~dp0
@echo.
@echo 当前80占用
@netstat -ano | find "LISTENING" | find "80"
@echo.
@echo 运行 NGINX
@nginx.exe -p %~dp0 -c %~dp0conf/nginx.conf
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
