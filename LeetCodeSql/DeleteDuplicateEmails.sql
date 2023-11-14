-- https://leetcode.com/problems/delete-duplicate-emails/

--if OBJECT_ID('dbo.Person') is not null
--BEGIN
--	drop table Person
--	PRINT 'dropped table Person successfully'
--END

--Create table Person (Id int, Email varchar(255))
--Truncate table Person
--insert into Person (id, email) values ('1', 'john@example.com')
--insert into Person (id, email) values ('2', 'bob@example.com')
--insert into Person (id, email) values ('3', 'john@example.com')

delete from Person
where id not in (select min(id) from person group by email)

select *
from Person

