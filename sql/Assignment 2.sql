

create table Courses (Cource_id int IDENTITY(1001,1),
						Title varchar(225),
						Details varchar(200)
						primary Key(Cource_id)
)

create table Student (
		Student_ID int IDENTITY(1,1),
		Name varchar(100)
		,Age int,
		[Address] varchar(200),
		Courses_ID int,
		primary Key(Student_ID),
		 FOREIGN KEY (Courses_ID) REFERENCES Courses(Cource_id)
)

truncate TABLE Student

select * from Student

select * from Courses order by Title 

Insert into Courses values('C#','Basic C#')

select Stu.Name,Stu.Age,Stu.Address,Cour.Title,Cour.Details from Student Stu
inner join Courses Cour on Cour.Cource_id = Stu.Courses_ID

Insert into Student values('Steven King',21,'2014 Jabberwocky Rd',(select Cource_id from Courses where Title= 'C#'))
Insert into Student values('Neena Kochhar',	20,'2011 Interiors Blvd',	1005)	
Insert into Student values('Lex De Haan',21,'2004 Charade Rd',	1006	)
Insert into Student values('Alexander Hunold',19,'147 Spadina Ave',	1007)
Insert into Student values('Bruce Ernst','22','8204 Arthur St',	1007)
Insert into Student values('David Austin',21,'Schwanthalerstr. 7031'	,1004)
Insert into Student values('Valli Pataballa',20,'Magdalen Centre, The Oxford Science Park',	1005)

	



