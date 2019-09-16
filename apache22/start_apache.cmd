@cd /d %~dp0
@echo.
@echo 检查 80 端口占用情况
@netstat -ano | find "LISTENING" | find "80"
@REM PHP54TS\php.exe -S 127.0.0.1:80 -t .\htdocs
@echo.
@type conf\httpd.conf  | find "Listen"
@echo.
@echo 检查 Apache 配置 
@REM bin\httpd.exe -w -d . -f conf\httpd.conf -t
@REM bin\httpd.exe -w -d . -f conf\httpd.conf -M
@bin\httpd.exe -w -d . -f conf\httpd.conf -t -S
@echo.
@echo 检查 Apache 配置目录
@type conf\httpd.conf  | find "ServerRoot" 
@type conf\httpd.conf  | find "DocumentRoot" 
@type conf\vhost.conf  | find "DocumentRoot" 
@echo.
@echo.
@bin\httpd.exe -w -d . -f conf\httpd.conf -T
