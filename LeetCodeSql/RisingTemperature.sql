--https://leetcode.com/problems/rising-temperature/

--if OBJECT_ID('dbo.Weather') is not null
--BEGIN
--	drop table Weather
--	PRINT 'dropped table Weather successfully'
--END

--Create table Weather (id int, recordDate date, temperature int)
--Truncate table Weather
--insert into Weather (id, recordDate, temperature) values ('1', '2015-01-01', '10')
--insert into Weather (id, recordDate, temperature) values ('2', '2015-01-02', '25')
--insert into Weather (id, recordDate, temperature) values ('3', '2015-01-03', '20')
--insert into Weather (id, recordDate, temperature) values ('4', '2015-01-04', '30')

select 
	[w2].[id]
from [weather] [w1]
	inner join [weather] [w2] on 
		datediff(day, [w1].[recordDate], [w2].[recordDate]) = 1 AND 
		[w2].[temperature] > [w1].[temperature]