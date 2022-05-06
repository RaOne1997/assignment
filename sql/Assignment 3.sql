select  emp.employee_id,Job.job_title,COUNT(emp.employee_id)[Total emp in position],AVG(emp.salary)[Emp salary] from employees emp
inner join jobs Job on Job.job_id=emp.job_id
inner join departments dept on dept.department_id=emp.department_id  group by emp.employee_id,  Job.job_title having count(emp.employee_id) <= 103

select 
	depq.department_name,count(emps.employee_id)
from 
	departments depq
	inner join employees emps on emps.department_id = depq.department_id
group by
		depq.department_name
having count(emps.employee_id)=
(
	

		select 
				MAX(e.maxs)
		
		from(
					select
					 
					count(*)[maxs] 
				From
					employees emp
				inner join
					departments dept 
				on
					dept.department_id=emp.department_id
				group by
					dept.department_name

		)e 

)



select
cours.Title,count(emps.Student_ID)
from
Courses cours
inner join Student emps on emps.Courses_ID = cours.Cource_id
group by
cours.Title
having count(emps.Courses_ID) =
(



select
MAX(e.maxs)

from(
select

count(*)[maxs]
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