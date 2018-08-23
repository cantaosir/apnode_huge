@echo off
@cd /d 
npm install --save sequelize
REM # And one of the following:
npm install --save pg@6 pg-hstore 
REM #pg@7 is currently not supported
npm install --save mysql2
npm install --save sqlite3
npm install --save tedious 
REM // MSSQL