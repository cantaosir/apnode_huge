@cd /d %~dp0
@echo.
@echo ��� 80 �˿�ռ�����
@netstat -ano | find "LISTENING" | find "80"
@REM PHP54TS\php.exe -S 127.0.0.1:80 -t .\htdocs
@echo.
@type conf\httpd.conf  | find "Listen"
@echo.
@echo ��� Apache ���� 
@REM bin\httpd.exe -w -d . -f conf\httpd.conf -t
@REM bin\httpd.exe -w -d . -f conf\httpd.conf -M
@bin\httpd.exe -w -d . -f conf\httpd.conf -t -S
@echo.
@echo ��� Apache ����Ŀ¼
@type conf\httpd.conf  | find "ServerRoot" 
@type conf\httpd.conf  | find "DocumentRoot" 
@type conf\vhost.conf  | find "DocumentRoot" 
@echo.
@echo.
@bin\httpd.exe -w -d . -f conf\httpd.conf -T
