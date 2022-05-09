WITH AVGSUM_CTE(Salary, DepartmentName)
AS
(
	SELECT AVG(e.Salary), d.[Name] AS DepartmentName FROM 
	Employees as e
	JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
	GROUP BY (d.[Name])
)

SELECT MIN(result.Salary) AS MinAgerageSalary FROM AVGSUM_CTE AS result

GO

SELECT TOP (50) e.FirstName, e.LastName, t.[Name] AS Town, a.AddressText
FROM Employees AS e
INNER JOIN Addresses AS a ON e.AddressID = a.AddressID
JOIN  Towns AS t ON a.TownID = t.TownID
ORDER BY e.FirstName, e.LastName

GO

SELECT e.EmployeeID, e.FirstName, e.LastName, d.[Name] AS DepartmentName
FROM Employees AS e
INNER JOIN Addresses AS a ON e.AddressID = a.AddressID
JOIN Departments as d ON e.DepartmentID = d.DepartmentID
WHERE d.[Name] = 'Sales'
ORDER BY e.EmployeeID ASC


GO

SELECT TOP (5) e.EmployeeID, e.FirstName, e.Salary, d.[Name] AS DepartmentName
FROM Employees AS e
JOIN Departments as d ON e.DepartmentID = d.DepartmentID
WHERE e.Salary > 15000
ORDER BY e.EmployeeID ASC

GO

SELECT e.EmployeeID, e.FirstName
FROM EmployeesProjects AS ep
RIGHT JOIN  Employees AS e ON ep.EmployeeID = e.EmployeeID
WHERE ep.EmployeeID IS NULL
ORDER BY e.EmployeeID ASC
OFFSET 0 ROWS
FETCH FIRST 3 ROWS ONLY 

GO

SELECT e.EmployeeID, e.FirstName, p.[Name] AS ProjectName
FROM EmployeesProjects AS ep
JOIN  Employees AS e ON ep.EmployeeID = e.EmployeeID
JOIN Projects AS p ON ep.ProjectID = p.ProjectID
WHERE p.StartDate  > CAST('08/13/2002' AS smalldatetime) AND p.EndDate IS NULL
ORDER BY e.EmployeeID ASC
OFFSET 0 ROWS
FETCH FIRST 5 ROWS ONLY 

GO



GO
