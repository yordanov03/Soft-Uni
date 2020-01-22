CREATE OR ALTER FUNCTION udf_ProjectDurationWeeks (@StartDate DATETIME, @EndDate DATETIME)
RETURNS INT
AS
BEGIN
DECLARE @projectWeeks INT;
IF(@EndDate IS NULL)
BEGIN
SET @EndDate = GETDATE()
END
SET @projectWeeks = DATEDIFF(WEEK, @StartDate, @EndDate)
RETURN @projectWeeks
END

SELECT ProjectID, StartDate, EndDate, dbo.udf_ProjectDurationWeeks(StartDate,EndDate)
FROM Projects

CREATE OR ALTER FUNCTION udf_GetSalaryLevel(@salary MONEY)
RETURNS VARCHAR (50)
AS
BEGIN
DECLARE @salaryLevel VARCHAR(50);

IF(@salary<30000)
BEGIN
SET @salaryLevel = 'Low'
END

ELSE IF(@salary>=30000 AND @salary<=50000)
BEGIN
SET @salaryLevel = 'Average'
END

ELSE 
BEGIN
SET @salaryLevel = 'High'
END

RETURN @salaryLevel
END

SELECT FirstName, LastName, Salary, dbo.udf_GetSalaryLevel(Salary) AS SalaryLevel
FROM Employees


CREATE OR ALTER PROC dbo.usp_SelectEmployeesBySeniority
AS
SELECT*
FROM Employees
WHERE DATEDIFF(Year, HireDate, GETDATE())>15

EXEC usp_SelectEmployeesBySeniority


CREATE OR ALTER PROCEDURE usp_SelectEmployeesBySeniority(@minYears INT = 5)
AS
	SELECT e.FirstName, e.LastName, e.HireDate
	FROM Employees AS e
	WHERE DATEDIFF(YEAR,e.HireDate, GETDATE())>@minYears

	EXEC usp_SelectEmployeesBySeniority @minYears = 18

CREATE OR ALTER PROC dbo.usp_AddNumbers
@firstNumber SMALLINT,
@secondNumber SMALLINT,
@result INT OUTPUT
AS 
SET @result = @firstNumber + @secondNumber
GO

DECLARE @answer smallint
EXEC usp_AddNumbers 5,6, @answer OUTPUT
SELECT 'The result is:',@answer



CREATE OR ALTER PROCEDURE usp_AssignProjects(@EmployeeID INT, @ProjectID INT)
AS
BEGIN
DECLARE @maxProjectsCoutToAssign INT = 3;
DECLARE @employeeProjectsCount INT = ( SELECT COUNT(ep.EmployeeID)
										FROM EmployeesProjects AS ep
										WHERE ep.EmployeeID = @EmployeeID)

BEGIN TRAN

INSERT INTO EmployeesProjects (EmployeeID, ProjectID)
VALUES (@EmployeeID, @ProjectID)

IF(@employeeProjectsCount>@maxProjectsCoutToAssign)
BEGIN
RAISERROR('Too many projects!',16,1)
ROLLBACK
RETURN
END
ELSE
COMMIT;
END

SELECT*
FROM EmployeesProjects

EXEC usp_AssignProjects 3,5

CREATE OR ALTER PROCEDURE usp_WithdrawMoney(@AccountID INT, @moneyAmount DECIMAL)
AS
BEGIN
BEGIN TRANSACTION
UPDATE Accounts
SET Balance -=@moneyAmount
WHERE ID = @AccountID

IF @@ROWCOUNT<>1
BEGIN
RAISERROR('Invalid Account!',16,1)
ROLLBACK
RETURN
END
ELSE
COMMIT
END



CREATE TRIGGER tr_TownsUpdate ON Towns AFTER UPDATE
AS
BEGIN
	IF(EXISTS(
				SELECT *
				FROM inserted
				WHERE (Name IS NULL OR LEN(Name)=0)))
					BEGIN
					RAISERROR('The name of the town cannot be null!',16,1)
					ROLLBACK
					RETURN
					END
END

UPDATE Towns
SET Name = ' ' 
WHERE TownID = 1


CREATE TABLE Accounts(
Username VARCHAR(10) NOT NULL PRIMARY KEY,
[Password] VARCHAR(20) NOT NULL,
Active CHAR(1) NOT NULL DEFAULT 'Y' )

CREATE TRIGGER tr_AccountsDelete ON Accounts
INSTEAD OF DELETE
AS
UPDATE a
SET Active = 'N'
FROM Accounts AS a
JOIN deleted AS d
ON a.Username = d.Username
WHERE a.Active = 'Y'

//1

CREATE PROC usp_GetEmployeesSalaryAbove35000 
AS
BEGIN
SELECT FirstName, LastName
FROM Employees
WHERE Salary>35000
END

EXEC usp_GetEmployeesSalaryAbove35000 


//2

CREATE PROC usp_GetEmployeesSalaryAboveNumber (@number DECIMAL (18,4))
AS
BEGIN
SELECT FirstName, LastName
FROM Employees
WHERE Salary>=@number
END

EXEC usp_GetEmployeesSalaryAboveNumber 48100

//3

CREATE PROC usp_GetTownsStartingWith (@condition VARCHAR(10))
AS
BEGIN
SELECT [Name]
FROM Towns
WHERE [Name] LIKE (@condition+'%')
END

EXEC usp_GetTownsStartingWith 'b'


//4

CREATE PROC usp_GetEmployeesFromTown (@townCondition VARCHAR(20))
AS
BEGIN
SELECT FirstName, LastName
FROM Employees as emp
JOIN Addresses as adr
ON emp.AddressID = adr.AddressID
JOIN Towns AS towns
ON adr.TownID = towns.TownID
WHERE towns.Name = @townCondition
END

EXEC usp_GetEmployeesFromTown 'Sofia'


//5

CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4)) 
RETURNS VARCHAR (10)
AS
BEGIN
DECLARE @salaryLevel VARCHAR(10)

IF (@salary<30000)
BEGIN
SET @salaryLevel = 'Low'
END

ELSE IF (@salary>=30000 AND @salary<=50000)
BEGIN
SET @salaryLevel = 'Average'
END

ELSE
BEGIN
SET @salaryLevel = 'High'
END

RETURN @salaryLevel

END

SELECT Salary, dbo.ufn_GetSalaryLevel(Salary) AS [Salary Level]
FROM Employees

//6

CREATE PROCEDURE usp_EmployeesBySalaryLevel
( @levelOfSalary VARCHAR(10))
AS
BEGIN
SELECT FirstName, LastName
FROM Employees
WHERE dbo.ufn_GetSalaryLevel(Salary) = @levelOfSalary
END

EXEC usp_EmployeesBySalaryLevel 'High'

//7

CREATE OR ALTER FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(MAX), @word VARCHAR(MAX)) 
RETURNS BIT
BEGIN

DECLARE @currentIndex INT = 1
DECLARE @currentChar NVARCHAR(1);
DECLARE @isCompraised INT;

WHILE(@currentIndex<=LEN(@word))
BEGIN
SET @currentChar = SUBSTRING(@word,@currentIndex,1)
SET @isCompraised = CHARINDEX(@currentChar,@setOfLetters,1)

IF(@isCompraised = 0)
BEGIN
RETURN 0
END
SET @currentIndex += 1;
END
RETURN 1
END

SELECT dbo.ufn_IsWordComprised('oistmiahf','Sofia')

//8

CREATE PROCEDURE usp_DeleteEmployeesFromDepartment (@departmentId INT) 
AS
BEGIN

DELETE FROM EmployeesProjects
WHERE EmployeeID IN (SELECT EmployeeID FROM Employees WHERE EmployeeID = @departmentId)

ALTER TABLE Departments
ALTER COLUMN ManagerID INT

UPDATE Employees
SET ManagerID = NULL
WHERE ManagerID IN ( SELECT EmployeeID FROM Employees WHERE DepartmentID = @departmentId)

UPDATE Departments
SET ManagerID = NULL
WHERE ManagerID IN (SELECT EmployeeID FROM Employees WHERE DepartmentID = @departmentId)

DELETE FROM Employees
WHERE DepartmentID = @departmentId

DELETE FROM Departments
WHERE DepartmentID = @departmentId

SELECT*
FROM Employees
WHERE DepartmentID = @departmentId

SELECT COUNT(*)
FROM Employees
WHERE DepartmentID = @departmentId

END


ROLLBACK 

//9

CREATE PROCEDURE usp_GetHoldersFullName 
AS 
BEGIN
SELECT FirstName + ' ' + LastName AS 'Full Name'
FROM AccountHolders
END

EXEC usp_GetHoldersFullName 

//10

CREATE PROCEDURE usp_GetHoldersWithBalanceHigherThan (@moneyAmount DECIMAL)
AS
BEGIN
SELECT FirstName, LastName
FROM AccountHolders as ah
JOIN Accounts AS acc
ON ah.Id = acc.Id
WHERE acc.Balance>@moneyAmount
END

//11

CREATE FUNCTION ufn_CalculateFutureValue(@sum DECIMAL (15,2), @interest FLOAT, @years INT)
RETURNS DECIMAL (15,4)
AS
BEGIN
DECLARE @futureValue DECIMAL
SET @futureValue = @sum*(POWER((1+ @interest),@years))
RETURN @futureValue
END


SELECT dbo.ufn_CalculateFutureValue (1000,0.1,5)

//12

CREATE PROCEDURE usp_CalculateFutureValueForAccount 
AS
BEGIN
SELECT acc.id, FirstName, LastName, Balance, dbo.ufn_CalculateFutureValue(acc.Balance, 0.1, 5)
FROM AccountHolders AS ach
JOIN Accounts AS acc
ON ach.Id = acc.Id
END

EXEC usp_CalculateFutureValueForAccount 

//13

CREATE OR ALTER FUNCTION ufn_CashInUsersGames (@gameName NVARCHAR(50))
RETURNS TABLE
AS
RETURN (
SELECT SUM(s.Cash) AS SumCash
FROM(
SELECT g.Name, ug.Cash, ROW_NUMBER() OVER(ORDER BY ug.Cash DESC) AS [RowNumber]
FROM Games AS g
JOIN UsersGames AS ug
ON g.Id = ug.GameId
WHERE g.Name = @gameName) AS s
WHERE RowNumber%2=1
)

SELECT * FROM dbo.ufn_CashInUsersGames('Lily Stargazer')

//14

CREATE TABLE Logs(
LogId INT IDENTITY NOT NULL,
AccountID INT NOT NULL,
OldSum DECIMAL(15,2) NOT NULL,
NewSum DECIMAL (15,2) NOT NULL 
CONSTRAINT PK_Logs PRIMARY KEY(LogId)
)

DROP TABLE Logs

CREATE TRIGGER tr_Accounts ON Accounts FOR UPDATE
AS
BEGIN
		
		DECLARE @accountId INT = (SELECT Id FROM inserted)
		DECLARE @oldSum DECIMAL(15,2) = (SELECT Balance FROM deleted)
		DECLARE @newSum DECIMAL (15,2) = (SELECT Balance FROM inserted)

		INSERT INTO Logs VALUES
		(@accountId,@oldSum,@newSum)
END


select * from inserted

//15

CREATE TABLE NotificationEmails(
Id INT NOT NULL IDENTITY,
Recipient INT NOT NULL,
Subjects VARCHAR(50) NOT NULL,
Body VARCHAR(MAX) NOT NULL,
CONSTRAINT PK_NotificationEmails PRIMARY KEY(Id)
)

DROP TABLE NotificationEmails

CREATE TRIGGER tr_Logs_NotificationEmails ON Logs  FOR INSERT
AS 
BEGIN

INSERT INTO NotificationEmails VALUES
((SELECT AccountID FROM inserted), 
CONCAT('Balance change for account:', (SELECT AccountID FROM inserted)), 
CONCAT( 'On', FORMAT(GETDATE(), 'dd-MM-yyyy HH:mm'), 'your balance was changed from', (SELECT OldSum FROM Logs), 'to', (SELECT NewSum FROM Logs),'.'))

END


//16

CREATE PROCEDURE usp_DepositMoney (@accountId INT, @moneyAmount DECIMAL(15,4))
AS
BEGIN

IF (@moneyAmount<0)
BEGIN
RAISERROR ('Invalid amount!',16,1)
RETURN
END

BEGIN TRANSACTION

UPDATE Accounts
SET Balance+=@moneyAmount
WHERE Id = @accountId
COMMIT
END

EXEC dbo.usp_DepositMoney 1, 10

//17


CREATE  PROCEDURE usp_WithdrawMoney (@accountId INT , @moneyAmount DECIMAL (15,4))
AS
BEGIN

IF(@moneyAmount<0)
BEGIN
RAISERROR('Invalid money amount!',16,1)
RETURN
END

BEGIN TRANSACTION
UPDATE Accounts
SET Balance-=@moneyAmount
WHERE Id = @accountId
COMMIT

END

//18
CREATE PROCEDURE usp_TransferMoney(@SenderId INT, @ReceiverId INT, @Amount DECIMAL(15,4))
AS BEGIN

IF(@Amount<0)
BEGIN
RAISERROR ('Invalid money amount!',16,1)
END

BEGIN TRANSACTION
UPDATE Accounts
SET Balance -=@Amount
WHERE Id = @SenderId

UPDATE Accounts
SET Balance+=@Amount
WHERE Id = @ReceiverId
COMMIT

END


//19
CREATE TRIGGER tr_ItemsUpdte ON Items AFTER UPDATE
AS
BEGIN

IF(SELECT MinLevel FROM Items WHERE ItemTypeId = (SELECT ItemId FROM inserted) > 
(SELECT Level FROM UsersGames WHERE Id = (SELECT UserGameId FROM inserted))
BEGIN
RAISERROR('Greater level to buy this item is required',16,1)
END

ELSE
BEGIN
INSERT INTO UserGameItems VALUES
( (SELECT ItemId FROM inserted), (SELECT UserGameId FROM inserted))
END

UPDATE usg
SET usg.Cash+=50000
FROM Users AS us
JOIN UsersGames AS usg
ON us.Id = usg.GameId
JOIN Games AS g
ON usg.GameId = g.Id
WHERE us.Username IN ('baleremuda', 'loosenoise', 'inguinalself', 'buildingdeltoid', 'monoxidecos')
AND g.Name = 'Bali' 


DECLARE @totalSumForMandatoryWeapons DECIMAL(15,4) = (SELECT SUM(Price) FROM Items WHERE Id BETWEEN 251 AND 299) + 
(SELECT SUM(Price) FROM Items WHERE Id BETWEEN 501 AND 539)

SELECT us.Username, g.Name, usg.Cash,it.Name
FROM Users AS us
JOIN UsersGames AS usg
ON us.Id = usg.GameId
JOIN Games AS g
ON usg.GameId = g.Id
JOIN UserGameItems AS usgi
ON usgi.UserGameId = usg.Id
JOIN Items AS it
ON usgi.ItemId = it.Id
WHERE g.Name = 'Bali' 
ORDER BY us.Username, it.Name

//20

DECLARE @gameId INT, @sum1 MONEY, @sum2 MONEY;

SELECT @gameId = usg.[Id]
FROM UsersGames AS usg
     JOIN Games AS g ON usg.[GameId] = g.[Id]
WHERE g.[Name] = 'Safflower';

SET @sum1 =
(
    SELECT SUM(i.Price)
    FROM Items AS i
    WHERE MinLevel BETWEEN 11 AND 12
);

SET @sum2 =
(
    SELECT SUM(i.Price)
    FROM Items AS i
    WHERE MinLevel BETWEEN 19 AND 21
);

BEGIN TRANSACTION;

IF
(
    SELECT Cash
    FROM UsersGames
    WHERE Id = @gameId
) < @sum1
    BEGIN
        ROLLBACK;
END
    ELSE
    BEGIN
        UPDATE UsersGames
          SET
              Cash = Cash - @sum1
        WHERE Id = @gameId;

        INSERT INTO UserGameItems(UserGameId,
                                  ItemId
                                 )
               SELECT @gameId,
                      Id
               FROM Items
               WHERE MinLevel BETWEEN 11 AND 12;
        COMMIT;
END;

BEGIN TRANSACTION;

IF
(
    SELECT Cash
    FROM UsersGames
    WHERE Id = @gameId
) < @sum2
    BEGIN
        ROLLBACK;
END
    ELSE
    BEGIN
        UPDATE UsersGames
          SET
              Cash = Cash - @sum2
        WHERE Id = @gameId;

        INSERT INTO UserGameItems(UserGameId,
                                  ItemId
                                 )
               SELECT @gameId,
                      Id
               FROM Items
               WHERE MinLevel BETWEEN 19 AND 21;
        COMMIT;
END;

SELECT i.Name AS 'Item Name'
FROM UserGameItems AS ugi
     JOIN Items AS i ON ugi.ItemId = i.Id
WHERE ugi.UserGameId = @gameId;


//21

CREATE PROCEDURE usp_AssignProject(@employeeId INT, @projectID INT) 
AS 
BEGIN

INSERT INTO EmployeesProjects VALUES
(@employeeId, @projectId)

DECLARE @currentProjectsCount INT = (SELECT COUNT(ProjectID)
									FROM EmployeesProjects
									WHERE EmployeeID = @employeeId)

BEGIN TRANSACTION

IF(@currentProjectsCount>3)
BEGIN
RAISERROR('The employee has too many projects!',16,1)
ROLLBACK
RETURN
END

ELSE
BEGIN
COMMIT
END

END

//22

CREATE TABLE Deleted_Employees(
EmployeeId INT NOT NULL ,
FirstName VARCHAR(50) NOT NULL,
LastName VARCHAR(50) NOT NULL,
MiddleName VARCHAR(50) NOT NULL,
JobTitle VARCHAR(50) NOT NULL,
DepartmentId INT NOT NULL,
Salary MONEY NOT NULL,

CONSTRAINT PK_DeletedEmployees PRIMARY KEY(EmployeeId) )

DROP TABLE Deleted_Employees

CREATE TRIGGER tr_Deleted_Employees ON Employees
AFTER DELETE
AS
BEGIN

INSERT INTO Deleted_Employees
SELECT FirstName, LastName, MiddleName, JobTitle, DepartmentID, Salary
FROM deleted


END

