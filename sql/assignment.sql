use waiTech
go

--Q1.Write a query to display the names (first_name, last_name) using alias
--name “First Name", "Last Name" – Employee table 
 select first_name [First Name],last_name [Last Name] from employees

--Q2 Write a query to get unique jobId from employee table.

 select  DISTINCT  job_id from employees

-- Q3.Write a query to get all employee details from the table order by first
--name, descending
 select * from employees order by first_name Desc

-- Q4.Write a query to get the names (first_name, last_name), salary, PF of
--all the employees (PF is calculated as 15% of salary).
 select first_name,last_name,salary ,convert(money,(salary/100*15)) [PF] from employees

-- Q5.Write a query to get the employee ID, names (first_name, last_name),
--salary in ascending order of salary 

 select first_name,last_name,salary  from employees  order by salary ASC

 --Q6. Write a query to get the total salaries payable to employees.
 Select SUM(salary)[Total salaries payable] from employees

-- 7. Write a query to get the maximum and minimum salary from
--employees table.
 Select min(salary)[minimum],max(salary)[maximum] from employees

 --Q8.Write a query to get the average salary and number of employees in
--the employees table.

select COUNT(*),(sum(salary)/count(*)) from employees

--Q9.Write a query to get the number of employees working with the
--company.

select count(*) from employees


select * from departments
select * from employees
select * from jobs


--Q10.Write a query to get the number of jobs available in the employees
--table.

 select count ( DISTINCT  job_id) [Number of job] from employees
 select count (job_id) [Number of job] from employees

 --Q11. Write a query get all first name from employees table in upper case

 Select upper(first_name) from employees
-- Q12.Write a query to get the first 3 characters of first name from employees
--table

 SELECT substring(first_name, 1, 3) AS [First 3 characters] from employees


 --Q13.Write a query to calculate 171*214+625.
 select(171*214+625) [Calculate]

-- Q14.Write a query to get the names (for example Ellen Abel, Sundar Ande
--etc.) of all the employees from employees table.

select (first_name+' '+ last_name)[Full Name] from employees

--Q15.Write a query to get first name from employees table after removing
--white spaces from both side.
SELECT trim(' 'from first_name) [First Name] from employees
--Q16. Write a query to get the length of the employee names (first_name,
--last_name) from employees tabl

select len(first_name+ last_name) [length of FUll name]
,len(first_name)[First name length],len(last_name)[Last name length] from employees
--Q17.Write a query to check if the first_name fields of the employees table
--contains numbers.


SELECT * 
   FROM employees 
   WHERE  first_name   like  '%[0-9]%';

 --Q18.Write a query to select first 10 records from a table
 select top 10 * from employees

 --Q19. Write a query to get monthly salary (round 2 decimal places) of each
--and every employee
SELECT round(salary, 2) AS RoundValue from employees

--************************************************************Restricting and Sorting data********************************************************************
--Q1.Write a query to display the name (first_name, last_name) and salary
--for all employees whose salary is not in the range $10,000 through
--$15,000

SELECT first_name, last_name, salary, department_id
FROM employees
WHERE salary NOT BETWEEN 10000 AND 15000 


-- Q2.Write a query to display the name (first_name, last_name) and
--department ID of all employees in departments 30 or 100 in ascending
--order. 

SELECT first_name, last_name, department_id
FROM employees
WHERE department_id IN (30, 100)


--Q3.Write a query to display the name (first_name, last_name) and salary
--for all employees whose salary is not in the range $10,000 through
--$15,000 and are in department 30 or 100. 

SELECT first_name, last_name, salary, department_id
FROM employees
WHERE salary NOT BETWEEN 10000 AND 15000 
and department_id IN (30, 100)


--Q4.Write a query to display the name (first_name, last_name) and hire
--date for all employees who were hired in 1987.

select  (first_name+' '+ last_name)[Name] from employees where year(hire_date) like '1987'


-- Q5.Write a query to display the first_name of all employees who have both
--"b" and "c" in their first name. 

		SELECT first_name
		FROM employees
		WHERE first_name LIKE '%b%'
		AND first_name LIKE '%c%'


--Q6. Write a query to display the last name, job, and salary for all
--employees whose job is that of a Programmer or a Shipping Clerk, and
--whose salary is not equal to $4,500, $10,000, or $15,000. 
select J.job_title,emp.first_name from employees emp
inner join jobs J on J.job_id=emp.job_id
where J.job_title in('Programmer','Shipping Clerk') 
and emp.salary not in (4,500,10000,15000)

-- Q7.Write a query to display the last name of employees whose names
--have exactly 6 characters.
SELECT last_name FROM employees WHERE last_name LIKE '______';

-- Q8.Write a query to display the last name of employees having 'e' as the
--third character
SELECT last_name FROM employees WHERE last_name LIKE '__e%';

-- Q9.Write a query to display the jobs/designations available in the
--employees table.
select DISTINCT J.job_title [designations] from employees emp
inner join jobs J on J.job_id=emp.job_id
where emp.job_id =J.job_id

--Q10. Write a query to display the name (first_name, last_name), salary and
--PF (15% of salary) of all employees. 
 select first_name,last_name,salary ,(salary/100*15)  [PF] from employees

-- 11. Write a query to select all record from employees where last name in
--'FAY', 'CHEN', 'KING' and 'BELL'.
select * from employees where last_name in('FAY', 'CHEN', 'KING' , 'BELL')
