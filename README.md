# Ticket机票预订系统
这是学习过c#和数据库之后动手做的一个简单的机票预订系统
### 开发环境
* Visual Studio2012
* VS中自带的SQL Server2008 Express
* C#
### 功能
* 用户注册、注销、信息查询、修改
* 航班查询、订单查询、航空公司信息查询
* 机票预订、退订
### 项目流程
* 1 已存在用户登录![登录](http://upload-images.jianshu.io/upload_images/4975863-75bde33bb312e291.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240)
* 2 新用户注册![注册](http://upload-images.jianshu.io/upload_images/4975863-d1656484cf6228c5.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240)
* 3 跳转主界面![主界面](http://upload-images.jianshu.io/upload_images/4975863-988325b7de1b0001.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240)
* 4 查询航班信息![航班查询](http://upload-images.jianshu.io/upload_images/4975863-db16fdcb42f5a7b1.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240)
* 5 购票后跳转订单信息![订单](http://upload-images.jianshu.io/upload_images/4975863-756501093428f465.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240)
* 6 用户可以在退票信息中选择退订![退票](http://upload-images.jianshu.io/upload_images/4975863-5d126d19d3225db0.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240)
* 7 查看航空公司信息![航空公司](http://upload-images.jianshu.io/upload_images/4975863-8f76e35c8ff4c816.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240)
* 8 查看、更改、注销用户![用户](http://upload-images.jianshu.io/upload_images/4975863-8784d7ecee9913d7.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240)
### 数据库设计
* 表名和对应关系

用户表（身份证号、用户名、姓名、联系方式、登陆密码） 
Customer(idno,user,name,tel,pwd)

航班表（航班号、出发地、目的地、日期）
Flight(fno,chufa,mudi,data)

机票表（航班号、机舱等级、票价、余票）
Ticket(fno,fclass,price,yupiao)

订单表（订单号、航班号、机舱等级、日期、票价、身份证号）
Order(orno,fno,fclass,date,price,idno)

航空公司表（公司名称，航班，地址，公司客服）
Air(airname,fno,address,tnumber)

登录表（身份证号、登陆密码）
Logins(idno,pwd)

* E-R图
![E-R](http://upload-images.jianshu.io/upload_images/4975863-1bc3028bda9cae06.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240)
* 连接语句

`using System.Data.SqlClient;`//加入引用数据库头文件

`stringstr=@"DataSource(LocalDB)\v11.0;AttachDbFilename=D:ticket1\ticket1\Database1.mdf;Integrated Security=True";`

连接vs中自带的sql server数据库，服务器名 (LocalDB)\v11.0，数据库名Database1.mdf

`SqlConnection conn = new SqlConnection(str);`

`conn.Open();` //数据库连接

`conn.Close();`//断开连接











