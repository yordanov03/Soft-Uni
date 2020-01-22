//1
SELECT TOP(5) EmployeeID, JobTitle, emp.AddressID, AddressText
FROM Employees AS emp
JOIN Addresses AS ad
ON emp.AddressID = ad.AddressID
ORDER BY emp.AddressID

//2
SELECT TOP (50) FirstName, LastName, t.Name, [AddressText]
FROM Towns AS t
JOIN Addresses AS a
ON t.TownID = a.TownID 
JOIN Employees AS E
ON e.AddressID = a.AddressID
ORDER BY e.FirstName, e.LastName

//3
SELECT EmployeeID, FirstName, LastName, d.Name
FROM Employees AS e
JOIN Departments AS d
ON (e.DepartmentID = d.DepartmentID AND d.Name = 'Sales')
ORDER BY EmployeeID

//4
SELECT TOP(5) EmployeeID, FirstName, Salary, [Name]
FROM Employees AS emp
JOIN Departments AS dept
ON emp.DepartmentID = dept.DepartmentID
WHERE Salary>15000
ORDER BY emp.DepartmentID

//5

SELECT TOP(3)emp.EmployeeID, FirstName
FROM Employees AS emp
LEFT OUTER JOIN EmployeesProjects as epr
ON emp.EmployeeID = epr.EmployeeID
WHERE epr.ProjectID IS NULL
ORDER BY emp.EmployeeID


//6

SELECT FirstName, LastName, HireDate, d.Name
FROM Employees AS e
JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
WHERE HireDate> '1.1.1999' AND d.Name IN( 'Sales', 'Finance')
ORDER BY HireDate

//7
SELECT TOP(5) emp.EmployeeID, emp.FirstName, pro.Name
FROM Employees AS emp
JOIN EmployeesProjects AS emppro
ON emp.EmployeeID = emppro.EmployeeID
JOIN Projects AS pro
ON pro.ProjectID = emppro.ProjectID
WHERE pro.StartDate> (SELECT CONVERT(DATE, '13.08.2002', 103))
ORDER BY emp.EmployeeID


//8
SELECT TOP(5) emp.EmployeeID, FirstName, CASE
           WHEN pro.StartDate > '2005'
           THEN NULL
           ELSE pro.Name
       END AS ProjectName
FROM Employees as emp
RIGHT OUTER JOIN EmployeesProjects AS emppro
ON emp.EmployeeID = emppro.EmployeeID
LEFT OUTER JOIN Projects as pro
ON emppro.ProjectID = pro.ProjectID
WHERE emp.EmployeeID = 24


//9

SELECT emp.EmployeeID, emp.FirstName, emp.ManagerID AS ManagerID, man.FirstName AS ManagerName
FROM Employees AS emp
JOIN Employees AS man
ON emp.ManagerID = man.EmployeeID
WHERE emp.ManagerID IN (3,7)
ORDER BY emp.EmployeeID

//10

SELECT TOP (50) 
emp.EmployeeID, emp.FirstName +  ' ' + emp.LastName AS EmployeeName, 
m.FirstName + ' ' + m.LastName AS ManagerName, dept.Name AS DepartnmentName
FROM Employees AS emp
LEFT OUTER JOIN Employees AS m 
ON m.EmployeeID = emp.ManagerID
LEFT OUTER JOIN Departments AS dept
ON dept.DepartmentID = m.DepartmentID
ORDER BY emp.EmployeeID

//11

SELECT MIN(AverageSalary.AvgSalary)
FROM (SELECT AVG(Salary) AS AvgSalary
		FROM Employees
		GROUP BY DepartmentID) AS AverageSalary

//12

SELECT mc.CountryCode, moun.MountainRange, pks.PeakName, pks.Elevation
FROM MountainsCountries as mc
JOIN Mountains AS moun
ON moun.ID = mc.MountainId
JOIN Peaks AS pks
ON mc.MountainId = pks.MountainID
WHERE mc.CountryCode = 'BG' AND pks.Elevation>2835
ORDER BY pks.Elevation DESC

//13

SELECT mtco.CountryCode, COUNT(CountryCode) AS MountainRanges
FROM Mountains AS moun
JOIN MountainsCountries AS mtco
ON moun.Id = mtco.MountainId
WHERE CountryCode IN ('BG','US','RU')
GROUP BY CountryCode


//14

SELECT TOP(5)coun.CountryName, ri.RiverName
FROM Countries AS coun
LEFT OUTER JOIN CountriesRivers AS counri
ON coun.CountryCode = counri.CountryCode
LEFT OUTER JOIN Rivers AS ri
ON counri.RiverId = ri.Id
WHERE ContinentCode = 'AF'
ORDER BY coun.CountryName


//15

WITH CTE_CountriesInfo (ContinentCode, CurrencyCode, CurrencyUsage) AS (
SELECT ContinentCode,CurrencyCode, COUNT(CurrencyCode) AS CurrencyUsage
FROM Countries
GROUP BY ContinentCode, CurrencyCode
HAVING COUNT(CurrencyCode)>1) 

SELECT e.ContinentCode, cci.CurrencyCode, e.MaxCurrency
FROM (SELECT ContinentCode, MAX(CurrencyUsage) AS MaxCurrency FROM CTE_CountriesInfo
GROUP BY ContinentCode) AS e
JOIN CTE_CountriesInfo AS cci ON cci.ContinentCode=e.ContinentCode AND cci.CurrencyUsage = e.MaxCurrency




//16

SELECT COUNT (coun.CountryCode)
FROM Countries AS coun
LEFT OUTER JOIN MountainsCountries AS como
ON coun.CountryCode = como.CountryCode
WHERE como.MountainId IS NULL

//17
SELECT TOP(5) c.CountryName, MAX(p.Elevation) AS HighestPeak, MAX(r.Length) AS LongestRiver
FROM Countries AS c
LEFT JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
LEFT JOIN Peaks AS p ON p.MountainId = mc.MountainId
LEFT JOIN CountriesRivers AS cr ON cr.CountryCode = c.CountryCode
LEFT JOIN Rivers AS r ON r.Id = cr.RiverId
GROUP BY c.CountryName
ORDER BY HighestPeak DESC , LongestRiver DESC ,c.CountryName


//18

SELECT TOP (5) jt.CountryName AS Country,
               CASE
                   WHEN jt.PeakName IS NULL
                   THEN '(no highest peak)'
                   ELSE jt.PeakName
               END AS HighestPeakName,
               CASE
                   WHEN jt.Elevation IS NULL
                   THEN 0
                   ELSE jt.Elevation
               END AS HighestPeakElevation,
               CASE
                   WHEN jt.MountainRange IS NULL
                   THEN '(no mountain)'
                   ELSE jt.MountainRange
               END AS Mountain
FROM
(
    SELECT c.CountryName,
           DENSE_RANK() OVER(PARTITION BY c.CountryName ORDER BY p.Elevation DESC) AS PeakRank,
           p.PeakName,
           p.Elevation,
           m.MountainRange
    FROM Countries AS c
         LEFT JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
         LEFT JOIN Mountains AS m ON mc.MountainId = m.Id
         LEFT JOIN Peaks AS p ON m.Id = p.MountainId
) AS jt
WHERE jt.PeakRank = 1
ORDER BY jt.CountryName,
         jt.PeakName;






select*from countries

WITH CTE_EmployeesNames(FirstName, LastName) AS
(SELECT FirstName, LastName
FROM Employees)

SELECT *
FROM CTE_EmployeesNames


SELECT * 
FROM Employees
WHERE FirstName = 'Pesho'

CREATE NONCLUSTERED INDEX
IX_Employees_FirstName
ON Employees(FirstName)