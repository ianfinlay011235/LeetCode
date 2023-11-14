--https://leetcode.com/problems/department-highest-salary/

--if OBJECT_ID('dbo.Employee') is not null
--BEGIN
--	drop table Employee
--	PRINT 'dropped table Employee successfully'
--END

--if OBJECT_ID('dbo.Department') is not null
--BEGIN
--	drop table Department
--	PRINT 'dropped table Department successfully'
--END

--Create table Employee (id int, name varchar(255), salary int, departmentId int)
--Create table Department (id int, name varchar(255))
--Truncate table Employee
--insert into Employee (id, name, salary, departmentId) values ('1', 'Joe', '70000', '1')
--insert into Employee (id, name, salary, departmentId) values ('2', 'Jim', '90000', '1')
--insert into Employee (id, name, salary, departmentId) values ('3', 'Henry', '80000', '2')
--insert into Employee (id, name, salary, departmentId) values ('4', 'Sam', '60000', '2')
--insert into Employee (id, name, salary, departmentId) values ('5', 'Max', '90000', '1')
--Truncate table Department
--insert into Department (id, name) values ('1', 'IT')
--insert into Department (id, name) values ('2', 'Sales')

SELECT 
	d.name AS Department,
	e.name AS Employee,
	e.salary AS SALARY
FROM
	Employee e
	INNER JOIN Department d ON e.departmentId = d.id
	WHERE 
		e.salary = (select MAX(salary) from Employee where e.departmentId = departmentId)
