-- https://leetcode.com/problems/department-top-three-salaries/

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
--insert into Employee (id, name, salary, departmentId) values ('1', 'Joe', '85000', '1')
--insert into Employee (id, name, salary, departmentId) values ('2', 'Henry', '80000', '2')
--insert into Employee (id, name, salary, departmentId) values ('3', 'Sam', '60000', '2')
--insert into Employee (id, name, salary, departmentId) values ('4', 'Max', '90000', '1')
--insert into Employee (id, name, salary, departmentId) values ('5', 'Janet', '69000', '1')
--insert into Employee (id, name, salary, departmentId) values ('6', 'Randy', '85000', '1')
--insert into Employee (id, name, salary, departmentId) values ('7', 'Will', '70000', '1')
--Truncate table Department
--insert into Department (id, name) values ('1', 'IT')
--insert into Department (id, name) values ('2', 'Sales')

SELECT
	[d].[name] AS [Department],
	[e].[name] AS [Employee],
	[e].[salary] AS [Salary]
FROM
	[Employee] [e]
	INNER JOIN [Department] [d] ON [e].[departmentId] = [d].[id]
WHERE
	[e].[salary] >= ISNULL((select distinct salary
							from Employee
							where departmentId = [e].[departmentId]
							order by salary desc
							offset 2 rows
							fetch first 1 row only), 0)