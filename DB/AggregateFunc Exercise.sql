 
 SELECT TOP(10) e.FirstName, e.LastName, e.DepartmentID FROM 
	(SELECT AVG(e.Salary) AS avgsal, e.DepartmentID 
	FROM Employees as e
	GROUP BY e.DepartmentID ) AS ordered 
JOIN Employees AS e ON ordered.DepartmentID = e.DepartmentID
WHERE e.Salary > ordered.avgsal 
ORDER BY e.DepartmentID

GO

USE Gringotts

SELECT TOP (2) DepositGroup
	   FROM WizzardDeposits AS w
	   GROUP BY DepositGroup, MagicWandSize
	   ORDER BY AVG(MagicWandSize),DepositGroup 

GO

SELECT TOP(1) MagicWandSize AS LongestMagicWand
FROM WizzardDeposits AS w
ORDER BY MagicWandSize DESC

 