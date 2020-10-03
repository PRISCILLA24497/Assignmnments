create database ABC
use ABC

create table Category
( cid int not null primary key identity(1,1),
 cname varchar(64) not null,
 tax decimal)

 select * from Category

insert into Category values('Women Clothing',15)
delete from  Category where cid=7

  create table Product
 (pid int not null primary key identity(1,1),
 pname varchar(64) not null,
 open_stock decimal not null,
 cur_stock decimal not null,
 sale_price decimal not null,
 category int not null foreign key references Category(cid))
 
 insert into Product values('kurti',3000,2000,500,6)
 select * from Product


 create table Customer
 ( custid int not null primary key identity(1,1),
 custname varchar(32) not null,
 mobile_no varchar(15) not null,
 open_bal decimal not null  default 0,
 is_active Bit not null default('TRUE'))


 insert into Customer values('reena',756578898,1000,0)


 create table SalesHead
 (sale_inv_no int not null primary key identity(1,1),
 sale_date date not null,
 customer int not null foreign key references  Customer(custid),
 Ptype char(10),
 constraint check_1 check(Ptype='Credit' or Ptype='Paid'))

 insert into SalesHead values('7-jun-2020',1,'Paid')

  insert into SalesHead values('3-jun-2020',2,'Credit')
  insert into SalesHead values('2-jun-2020',5,'Credit')

 
   select * from Category

   select * from Product
    select *  from Customer

    select * from SalesHead
   select * from SalesDetail
 
 create table SalesDetail

 (sale_inv_no int not null foreign key references SalesHead(sale_inv_no),
 product_id int not null foreign key references Product(pid),
 qty decimal not null,
 rate decimal not null)

  insert into SalesDetail values(1,1,1,1000)
   insert into SalesDetail values(2,2,2,500)
   insert into SalesDetail values(5,4,3,1500)


 --Query1:
 select p.pname,c.cname,p.cur_stock from Product as p ,Category as c where p.category=c.cid

 --Query2:
 select custname from Customer where is_active='True'

 --Query3:
 select custname ,open_bal from Customer

 --Query4:
 select  sum(sd.qty) as SALES from SalesDetail as sd , SalesHead as sh where sale_date > '2020-06-01' and sale_date < '2020-07-01'

 --Query5:
 select pname ,sum(qty) QTY from Product as p, SalesDetail as sd where sd.product_id=p.pid 
 group by pname 
 order by (QTY) Desc

 --Query6:
 select pname ,sum(qty) QTY from Product as p, SalesDetail as sd where sd.product_id=p.pid 
 group by pname 
 order by (QTY) Asc
