
--Q4.Use inner join between Employee, jobs and department table to show the following data
--		a. Emp full name, job title, department name 

	select 
			(emp.first_name+' '+emp.last_name)[Name]
			,Job.job_title[Designations],
			dept.department_name[Department Name] 
	from
		employees emp
	inner join 
		jobs Job on Job.job_id=emp.job_id
	inner join 
		departments dept on dept.department_id=emp.department_id 

--Q5. Course wise show count of students. 
		select 
				cou.Title,
				count(Student_ID) 
		from 
				Student std
		inner join 
			Courses cou 
		on	
			cou.Cource_id=std.Courses_ID
		group by	
			cou.Title

--6. Show all students who all belong to course Title ending with “Science”
	select 
			*
	from 
		Student std
	inner join
		Courses cou
	on
			cou.Cource_id=std.Courses_ID
	where 
			cou.Title like '%Science'

--7. Create the above query with inner join and in clause 
	select
			*
	from
		Student std
	inner join 
		Courses cou
	on
		cou.Cource_id=std.Courses_ID
	where 
		cou.Title in (select Title From Courses where Title like '%Science')

--8. List all students alphabetically arranged
		select
			*
		from 
			Student
		order by 
			Name
--9. Show all students alphabetically arranged by Title of course 

	select 
			std.Name,
			cou.Title 
	from 
		Student std
	inner join
			Courses cou 
	on 
			cou.Cource_id=std.Courses_ID
	order by 
		cou.Title

--10. Show Course having the max number of students 

		select 
			cours.Title
			,count(emps.Student_ID)
		from 
			Courses cours
		inner join 
			Student emps 
		on
			emps.Courses_ID = cours.Cource_id
		group by
				cours.Title
		having count(emps.Courses_ID) =
		(
	
			select 

						MAX(e.maxs)
		
				from(
							select
					 
							count(Details)[maxs] 
						From
							Student emp
						inner join
							Courses dept 
						on
							dept.Cource_id=emp.Courses_ID
						group by
							dept.Title

				)e 

		)

--11Show list of courses order by the number of students in each 

	select
					 
				courc.Title,count(*)[Number of Student] 
				From
					Student std
				inner join
					Courses courc 
				on
					courc.Cource_id=std.Courses_ID
				group by
					courc.Title
				order by [Number of Student]

--@12.Show the following list
		select 
			std.Name,
			cou.Title 
		from 
			Student std
		inner join 
			Courses cou 
		on
			cou.Cource_id=std.Courses_ID
