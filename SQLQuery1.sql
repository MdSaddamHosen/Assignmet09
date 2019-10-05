use CustomerInfo
select * from Customers
insert into Customers values('A001','Saddam','kachua-chandpur','01639193149','Chandpur')
insert into Customers values('A002','Amir','shashonpara','01639193141','Comilla')
insert into Customers values('A003','Eman','shashaonpara','01639193425','DHAKA')
insert into Customers values('A004','Sayeed','aliara','01639193453','Chandpur')

select * from Customers
drop database Customers
create database CustomersInformation

create table Districts(Id int identity (1,1),District varchar(20))
insert into Districts values('--Select--')
insert into Districts values('Chandpur')
insert into Districts values('Comilla')
insert into Districts values('Sirajgonj')
insert into Districts values('Natore')
insert into Districts values('Chattogram')
insert into Districts values('Rajshahi')
select * from Districts