
--https://leetcode.com/problems/nth-highest-salary/

CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN
	SET @N = @N - 1
    RETURN (
		SELECT DISTINCT salary 
		FROM Employee
		ORDER BY salary DESC
		OFFSET @N ROWS 
		FETCH FIRST 1 ROW ONLY
    );
END