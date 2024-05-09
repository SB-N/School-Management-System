--procedure for Admin
create proc insert_tblAdmin
(
@Ad_name varchar(20) ,
@Ad_password varchar (20) 

)
as 
begin
insert into Administator(Ad_name,Ad_password)
Values (@Ad_name,@Ad_password)
end

execute insert_tblAdmin 'Hello','firstPro1';
exec insert_tblAdmin 'First','Open2';

--procedure for student
create proc insert_tablestudent2( 
@std_Firstname varchar (30) ,
@std_LastName varchar(30),
@std_Fname varchar (100),
@std_dateofBirth date,
@std_Gender varchar (10) ,
@std_Address varchar (99) ,
@std_AdmissionDate date ,
@st_Ad_ID int
) 
as
begin

insert into STUDENT(std_Firstname,std_LastName,std_Fname,std_dateofBirth,std_Gender,std_Address,std_AdmissionDate,st_Ad_ID)
values(@std_Firstname,@std_LastName,@std_Fname,@std_dateofBirth,@std_Gender,@std_Address,@std_AdmissionDate,@st_Ad_ID)
 
 end;
 
 

 exec insert_tablestudent2'Ali','DF','sdf','3/10/2010','Male','dfsfdfdsf','4/20/2020',1; 
 select * from STUDENT;
 
--procedure for Fee
create proc insert_tableFee
(
@fee_Amount float ,
@fdays varchar(20) ,
@months varchar(19),
@fee_st_Id int,
@fee_sa_id int 
)
as
begin
insert into FEE(fee_Amount,fdays,months,fee_st_id,fee_sa_id)
VALUES(@fee_Amount,@fdays,@months,@fee_st_id,@fee_sa_id)
end;
select * from Student_status
exec insert_tableFee 3000,2,1,125,18;

--select  f.fee_Amount, f.fee_data  ,s.std_name  from Fees F inner join STUDENT s on s.std_id = f.fee_fk__st_id;
--Procedure for update
create proc Update_STUDENT
(
@std_id int ,
@std_Firstname varchar(30),
@std_LastName varchar(30),
@std_Fname varchar(100),
@std_Gender varchar(10),
@std_address varchar(99)
)
as 
begin
update  STUDENT
set @std_Firstname=@std_Firstname,
std_LastName=@std_LastName,
std_Fname=@std_fname, 
std_Gender=@std_Gender,
std_Address=@std_address
where std_id =@std_id
end
select * from STUDENT;
--Procedure for imge
create proc insert_Student_img(
@Img_path varchar (max) ,
@img_fk int
) AS
begin
insert into Student_img(Img_path,img_fk)
values(@img_path,@img_fk )

end
--delete student
CREATE PROCEDURE Delete_Student1
(
    @student_id INT
)
AS
BEGIN
    DELETE FROM STUDENT WHERE std_id = @student_id;
    DELETE FROM Student_img WHERE img_fk = @student_id;
END
select * from STUDENT;
--procedire for status
 create procedure insert_Student_status2(
  @Sa_ST_ID int ,
 @Sa_Class_ID int ,
 @Sa_year varchar(20)
 )
 AS
 begin
 insert into Student_status(Sa_ST_ID,Sa_Class_ID,Sa_year)
 values(@Sa_ST_ID,@Sa_Class_ID,@Sa_year)
 end ;
  
 
--teacher
create proc ins_Tea(
@T_Name varchar (70),
@T_Gender varchar (10) ,
@T_Address varchar (99) ,
@Phone varchar(80),
@Education varchar(50),
@joind date,
@Salary float,
@T_Ad_ID int )
As begin
insert into Teacher(T_Name,T_Gender,T_Address,Phone,Education,joind,Salary,T_Ad_ID)
values(@T_Name,@T_Gender,@T_Address,@Phone,@Education,@joind,@Salary,@T_Ad_ID)
end;
--sal
create proc ToPAyS1(
@Pstatus varchar(10),
@T_id int,
@amount float,
@Pmonth varchar(10),
@Pyera varchar(10),
@PWdays int)
as begin
insert into toPay (T_id,Pstatus,amount,Pmonth,Pyera,PWdays)
values(@T_id,@Pstatus,@amount,@Pmonth,@Pyera,@PWdays)
end;