# apnode

#### 项目介绍
Windows （或包括Linux MacOS）通过 NodeJS 管理服务的管理工具集 
Nginx，PHP，MySQL， 扩展，
Apache，Redis，MongoDB，FTP，Git，SVN

#### 软件架构
软件架构说明


#### 安装教程

1. Git，https://github.com/git-for-windows/git/releases/download/v2.18.0.windows.1/Git-2.18.0-64-bit.exe
2. TortoiseGit，https://download.tortoisegit.org/tgit/2.7.0.0/TortoiseGit-LanguagePack-2.7.0.0-64bit-zh_CN.msi
3. TortoiseGit ，https://download.tortoisegit.org/tgit/2.7.0.0/TortoiseGit-2.7.0.0-64bit.msi
4. mysql-5.7， https://cdn.mysql.com/archives/mysql-5.7/mysql-5.7.22-winx64.zip
5. MiniThunder，  http://t.cn/zOY7u6X 
6. MiniThunder官微，https://weibo.com/minithunder
7. NODEJS，https://nodejs.org/zh-cn/download/  
    > https://nodejs.org/dist/v12.13.0/node-v12.13.0-win-x64.zip  
    > https://nodejs.org/dist/v8.11.4/node-v8.11.4-x64.msi 旧版  

8. JAVA ,   
    > http://www.oracle.com/technetwork/java/javase/archive-139210.html
    > http://download.oracle.com/otn/java/jdk/8u172-b11/a58eab1ec242421181065cdc37240b08/jdk-8u172-windows-x64.exe 

9. Tomcat  
    > 官网地址 https://tomcat.apache.org/download-80.cgi

#### 使用说明
1. apnode, 为了方便开发环境搭建而准备的套件，默认放到 C: 下即可
2. 安装必备工具，下载的 MiniThunder， TortoiseGit，
3. NODEJS MySQL Java 按需到官方下载 
4. FileZillaClient 中包含了WinSCP 和 Putty ，FileZillaServer 为FTP服务
5. Redis Server 和 Memcache 版本是从网络上收集的
6. Apache 含 PHP54TS 和 subversion 
7. Nginx 配套使用 WinswPHP56x64NTS，含有较多插件 events,mongodb,redis,sphinx,wincache,xdebug,yaf,win32ps,
8. FRP Ngrok 集成方便一些测试
9. .tool 目录下有NODE 和 MySQL 的配置文件
10. start_nginx.cmd，start_apache.cmd，start_PHP56.cmd，是启动快捷方式
11. MysqlRoute 做测试读写分离用
12. apmanger 准备用C#写的管理工具，说不定也可以成为一个Apache Friends 工具套件
#### 参与贡献

1. Fork 本项目
2. 新建 Feat_xxx 分支
3. 提交代码
4. 新建 Pull Request

#### 相关引用
1. Winsw，方便的应用转服务工具
2. phpfpm 虽然有官方的fastcgi，但是看起来似乎这个更和谐
3. 