REM 2.1 ϵͳ������������
REM ��������ROCKETMQ_HOME
REM ����ֵ��MQ��ѹ·��\MQ�ļ�����
REM ��NAMESERVER
REM Cmd�����ִ�н�������MQ�ļ���\bin���£�Ȼ��ִ�С�start mqnamesrv.cmd��������NAMESERVER���ɹ���ᵯ����ʾ�򣬴˿���رա�
REM start mqbroker.cmd -n 127.0.0.1:9876 autoCreateTopicEnable=true
REM �������֮�󣬽��롮rocketmq-externals\rocketmq-console\src\main\resources���ļ��У��򿪡�application.properties���������á�
REM ���롮\rocketmq-externals\rocketmq-console���ļ��У�ִ�С�mvn clean package -Dmaven.test.skip=true�����������ɡ�

java -jar ./rocketmq-console-ng-1.0.1.jar
