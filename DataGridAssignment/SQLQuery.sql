create table Bank(Eid int not null, Ename  varchar(30), Department varchar(40),Location varchar(50));

insert into Bank  values(11023,'Lavanya','CClerk','Hyderabad')


create table Employeee(ID int not null, EName  varchar(30), Designation varchar(40),Location varchar(50));

insert into Employeee values(101,'Aneesha','HR','Mysore')

create table CricketTeam(JerseyNo int, FName varchar(20),LName varchar(30),CenturyNo int);

insert into CricketTeam values(3,'Virat','Kohli',2)

select * from  CricketTeam
select * from Bank


create table Railway(TrainNo int, TrainName varchar(50), Source varchar(40), Destination varchar(50), ArrivalTime Time )




insert into Railway values(1103,'JanmaBhumiExpress','Hyderabad','Visakhapatnam','6:00 pm')


create table student(ID int, FName varchar(20),LName varchar(30),Location varchar(40));

insert into student values (104,'Saritha','prasad','Hyderabad')