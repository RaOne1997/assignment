Create Database StudentPerformanceManagement

 --CREATE SCHEMA student;
 --CREATE SCHEMA Course;



 create table [Course].[Course]( Cource_id int IDENTITY(101,1) ,Cource_Code Nvarchar(50) unique,Title Nvarchar(100),Description Nvarchar(200) primary key(Cource_id));
 go
  create table [Course].Subjects( subject_ID int IDENTITY(10,1),  Subject_Code Nvarchar(50) unique, Cource_id int,Title Nvarchar(100),Description Nvarchar(200) 
  primary key(subject_ID) ,FOREIGN KEY (Cource_id) REFERENCES [Course].[Course](Cource_id));
 
 go
  Create table [student].student(Roll_Number int  IDENTITY(1001,1),Name Nvarchar(100),Email Nvarchar(100) unique,[Address] Nvarchar(150) 
  ,Cource_ID int primary Key(Roll_Number) , FOREIGN KEY (Cource_ID) REFERENCES [Course].[Course](Cource_id))
  go

  Create table [Course].Marks(StudentId int ,SubjectId int ,Marks decimal(4,2) FOREIGN KEY (SubjectId) REFERENCES [Course].Subjects(subject_ID) ,
  FOREIGN KEY (StudentId) REFERENCES [student].student(Roll_Number)   )

  select sstu.*,cc.Title,CS.Title from student.student sstu
	inner join Course.Course  cc on cc.Cource_id=sstu.Cource_ID
	inner join Course.Subjects CS on CS.Cource_id=sstu.Cource_ID
