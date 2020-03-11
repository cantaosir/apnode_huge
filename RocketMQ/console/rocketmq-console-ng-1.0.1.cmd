REM 2.1 系统环境变量配置
REM 变量名：ROCKETMQ_HOME
REM 变量值：MQ解压路径\MQ文件夹名
REM 动NAMESERVER
REM Cmd命令框执行进入至‘MQ文件夹\bin’下，然后执行‘start mqnamesrv.cmd’，启动NAMESERVER。成功后会弹出提示框，此框勿关闭。
REM start mqbroker.cmd -n 127.0.0.1:9876 autoCreateTopicEnable=true
REM 下载完成之后，进入‘rocketmq-externals\rocketmq-console\src\main\resources’文件夹，打开‘application.properties’进行配置。
REM 进入‘\rocketmq-externals\rocketmq-console’文件夹，执行‘mvn clean package -Dmaven.test.skip=true’，编译生成。

java -jar ./rocketmq-console-ng-1.0.1.jar
