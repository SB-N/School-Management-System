select *from Administator
 select * from STUDENT;
 select Ad_password from Administator where Ad_name='Subaina';
select * from Administator
          select count(Ad_ID) from Administator where Ad_name='Subaina';
 select st.std_Firstname,st.std_Gender,st.std_AdmissionDate , ad.Ad_name as 'admin name' from
 STUDENT st inner join Administator ad on ad.Ad_ID=st.st_AD_ID where ad.Ad_name = 'Subaina';
 --for searhing through student first name
 select st.std_id,st.std_FirstName,st.std_LastName,st.std_Address,st.std_dateofBirth,st.std_AdmissionDate ,ad.Ad_name from STUDENT st inner join Administator ad
 on ad.Ad_ID=st.st_Ad_ID
 where st.std_Firstname like '%A%';
 select * from STUDENT
 select * 
 --fee
select s.std_FirstName,s.std_Fname,f.Fee_Amount,Fee_date
from STUDENT s inner join Fee f on s.std_id=f.fee_st_ID;
select st.std_id,st.std_FirstName,st.std_LastName,st.std_Address,st.std_dateofBirth,st.std_AdmissionDate ,ad.Ad_name from STUDENT st inner join Administator ad on ad.Ad_ID = st.st_Ad_ID where st.std_Firstname like 'Ali';
            select st.std_id,st.std_FirstName,st.std_LastName,st.std_Address,st.std_dateofBirth,st.std_AdmissionDate ,ad.Ad_name from STUDENT st inner join Administator ad on ad.Ad_ID = st.st_Ad_ID where st.std_id=101;
			select * from FEE  inner join STUDENT on fee.fee_st_Id=STUDENT.std_id;
			select * from Teacher
			select * from toPay

			--fee
			select  s.std_id, sa.SA_ID,s.std_Gender,s.std_Address,c.classname from  STUDENT s inner join Student_status sa on s.std_id=sa.Sa_ST_ID inner join Classes c on sa.Sa_Class_ID=c.class_id   where s.std_id not in (select f.fee_st_Id from Student_status sa inner join FEE f on sa.Sa_Id = f.fee_sa_id where sa.Sa_year = '2024' and f.months = '1');
			--delete
			select std_Firstname,std_Lastname,std_Fname,std_Gender,std_Address from STUDENT where std_ID =125;
			--
			select SA.Sa_ID ,s.std_id,s.std_Firstname,SA.sa_year,SA.Sa_Class_ID,C.Classname ,c.Fees ,C.class_id from STUDENT s inner join Student_status SA  on S. std_id = SA.Sa_ST_ID inner join Classes C on C.class_id = SA.Sa_Class_ID where s.std_id=130 and SA.Sa_year ='2024';
			--teacher
			select * from Teacher
			--view
			select st.std_id as ID,st.std_Firstname as [First Name],st.std_Lastname as [Last Name] ,st.std_Address as [Address] ,st.std_dateofBirth as [Date of Birth],st.std_AdmissionDate as [Admission Date],ad.Ad_name as [Admin Name] from STUDENT st inner join Administator ad on ad.Ad_ID = st.st_Ad_ID where st.std_id=125;
			--classes fee
			 insert into Classes
 values('Toddler',3000),('KGI',3000),('KGII',3000),('One',3000),('Two',3000),('Three',3000),('Four',3000),('Five',3000),('Six',1500),('Seven',1500),('Eight',1500),('Nine',1500),('Ten',1500);
  select SA.Sa_ID ,s.std_id,s.std_Firstname,SA.Sa_year,SA.Sa_Class_ID,C.Classname ,c.Fees ,C.class_id from STUDENT s inner join Student_status SA 
 on S. std_id=SA.Sa_ST_ID inner join Classes C on C.class_id=SA.Sa_Class_ID ;
 select * from STUDENT
select * from Student_status ;
exec insert_Student_status2 135,1,'2024';
select * from Classes
select * from Student_img