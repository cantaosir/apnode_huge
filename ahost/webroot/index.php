<?php
if($_GET['q']=='info'){
	phpinfo();
}else{
	echo "hello_nginx vhost ",microtime(1);
	
}