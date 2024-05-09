CREATE DATABASE SchoolProject;
--Admin table
create table Administator(
Ad_ID int primary key identity,
Ad_name varchar(20) not null unique,
Ad_password varchar (20) not null
);
--Student Table
CREATE TABLE STUDENT(
std_id int primary key identity(100,1),
std_Firstname varchar (30) not null,
std_LastName varchar(30),
std_Fname varchar (100) not null,
std_dateofBirth DATE,
std_Gender varchar (10) not null,
std_Address varchar (99) not null,
std_AdmissionDate DATE ,
st_Ad_ID int foreign key references Administator(Ad_ID) on update cascade on delete cascade);
--Fee table
create table FEE(
Fee_ID int identity(1000,1) primary key ,
fee_Amount float,
fdays varchar(20),
months varchar(19),
fee_sa_id int foreign key references Student_status,
fee_st_Id int foreign key references STUDENT (std_id) on update cascade on delete cascade
);
select * from Fee
--image table
create table Student_img(
Img_id int  identity (1,1) primary  key,
Img_path varchar (max) not null,
img_fk int foreign key references  STUDENT(std_id) on update cascade on delete cascade);

        select * from Student_img
		select * from STUDENT
--Class table
create table Classes(
class_id int primary key identity,
classname varchar (20) not null,
 Fees Float
 )
 --status table
 create table Student_status(
 Sa_Id int primary key identity,
 Sa_year  varchar(20),
 Sa_ST_ID int foreign key references STUDENT (std_id) on update cascade on delete cascade,
 Sa_Class_ID int foreign key references Classes (class_id) on update cascade on delete cascade);
 


	select * From	  Student_status
	--Teacher Table
 create table Teacher(
 T_id int identity(2000,1) primary key not null,
 T_Name varchar (70),
 T_Gender varchar (10) ,
 T_Address varchar (99) ,
 Phone varchar(80),
 Education varchar(50),
 joind date,
 Salary float,
T_Ad_ID int foreign key references Administator(Ad_ID) on update cascade on delete cascade);
--PAyment
create table toPay(
P_id int identity(20,1) primary key,
Pstatus varchar(10),
T_id int foreign key  references Teacher(t_id) on update cascade on delete cascade,
amount float,
Pmonth varchar(10),
Pyera varchar(10),
PWdays int,
);