CREATE DATABASE Demo
USE DEMO


CREATE TABLE Countries(
CountryID INT NOT NULL IDENTITY,
[Name] NVARCHAR (50),

CONSTRAINT PK_Coutries PRIMARY KEY (CountryID)
)

CREATE TABLE Towns(
TownID INT NOT NULL IDENTITY,
[Name] NVARCHAR(50),
CountryID INT NOT NULL

CONSTRAINT PK_Towns PRIMARY KEY (TownID),

CONSTRAINT FK_Towns_Countries FOREIGN KEY (CountryID)
REFERENCES Countries(CountryID)
)

INSERT INTO Countries VALUES
('Bulgaria'),
('Germany'),
('Afganistan')

INSERT INTO Towns VALUES
('Blagoevgrad',1),
('Berlin',2),
('Kardahar',3)


SELECT *
FROM Countries AS c 
JOIN Towns AS t
ON t.CountryID = c.CountryId

CREATE TABLE Mountains(
MountainID INT NOT NULL IDENTITY,
[Name] NVARCHAR(50)

CONSTRAINT PK_MoutainID PRIMARY KEY (MountainID)
)

CREATE TABLE Peaks(
PeakID INT NOT NULL IDENTITY,
[Name] NVARCHAR(50),
MountainID INT NOT NULL,

CONSTRAINT PK_Peaks 
PRIMARY KEY (PeakID),

CONSTRAINT FK_Peaks_Mountains 
FOREIGN KEY (MountainID) 
REFERENCES Mountains(MountainID)
)


CREATE TABLE Employees(
EmployeeID INT NOT NULL,
[Name] NVARCHAR(50)

CONSTRAINT PK_Employees PRIMARY KEY (EmployeeID)
)

CREATE TABLE Projects(
ProjectID INT NOT NULL,
[Name] NVARCHAR(50)

CONSTRAINT PK_Projects
PRIMARY KEY (ProjectID) 
)

CREATE TABLE EmployeesProjects(

EmployeeID INT NOT NULL,
ProjectID INT NOT NULL,

CONSTRAINT PK_EmployeesProjects
PRIMARY KEY(EmployeeID, ProjectID),

CONSTRAINT FK_EmployeesProjects_Employees
FOREIGN KEY (EmployeeID) 
REFERENCES Employees(EmployeeID),

CONSTRAINT FK_EmployeesProjects_Projects
FOREIGN KEY (ProjectID)
REFERENCES Projects(ProjectID)
)

INSERT INTO Employees
VALUES
(1,'Bay Ivan'),
(2,'Pesho'),
(3, 'Gosho')

INSERT INTO Projects
VALUES
(1,'MS SQL Server'),
(2,'Java project'),
(3, 'Swift project')

SELECT * 
FROM Employees

SELECT *
FROM Projects

INSERT INTO EmployeesProjects VALUES
(1,2),
(1,3),
(2,2)


CREATE Table Drivers(
DriverID INT NOT NULL,
[Name] NVARCHAR(50) NOT NULL,

CONSTRAINT PK_Drivers
PRIMARY KEY (DriverID)
)

CREATE TABLE Cars(
CarID INT NOT NULL,
DriverID INT UNIQUE NOT NULL

CONSTRAINT FK_Cars_Drivers
FOREIGN KEY (DriverID)
REFERENCES Drivers(DriverID) )


SELECT m.Name, p.Name
FROM Mountains AS m
JOIN Peaks AS p
ON m.MountainID = p.PeakID

SELECT*
FROM Mountains

SELECT*
FROM Peaks

SELECT m.MountainRange, p.PeakName, p.Elevation
FROM Mountains AS m
JOIN Peaks AS p
ON m.Id = p.MountainID
WHERE MountainRange = 'Rila'
ORDER BY Elevation DESC



//1

CREATE TABLE Persons(
PersonID INT NOT NULL,
FirstName VARCHAR(50) NOT NULL,
Salary DECIMAL (15,2) NOT NULL,
PassportID INT NOT NULL )


CREATE TABLE Passports(
PassportId INT NOT NULL,
PassportNumber VARCHAR(50) )

INSERT INTO Persons VALUES
(1,'Roberto',43300,102),
(2,'Tom',56100,103),
(3,'Yana',60200,101)


INSERT INTO Passports VALUES
(101,'N34FG21B'),
(102,'K65LO4R7'),
(103,'ZE657QP2')

ALTER TABLE Persons
ADD CONSTRAINT  PK_Person PRIMARY KEY (PersonID)

ALTER TABLE Passports
ADD CONSTRAINT PK_Passports PRIMARY KEY(PassportID)

ALTER TABLE Persons
ADD CONSTRAINT FK_PassportID
FOREIGN KEY (PassportID)
REFERENCES Passports(PassportId) 

SELECT *
FROM Persons AS pe
JOIN Passports AS pa
ON pe.PassportID = pa.PassportId

//2

CREATE TABLE Manufacturers(
ManufacturerID INT NOT NULL,
[Name] VARCHAR(50) NOT NULL,
EstablishedOn DATE DEFAULT GETDATE() NOT NULL,

CONSTRAINT PK_Manifacturers PRIMARY KEY(ManufacturerID))



CREATE TABLE Models(
ModelID INT IDENTITY (100,1) NOT NULL,
[Name] VARCHAR(50) NOT NULL,
ManufacturerID INT NOT NULL,

CONSTRAINT PK_Models PRIMARY KEY(ModelID),

CONSTRAINT FK_Models_Manifacturers 
FOREIGN KEY (ManufacturerID) 
REFERENCES Manufacturers (ManufacturerID) )

INSERT INTO Manufacturers VALUES
(1,'BMW','07/03/1916'),
(2,'Tesla', '01/01/2003'),
(3,'Lada','01/05/1966')

INSERT INTO Models VALUES
('X1',1),
('i6',1),
('Model S',2),
('Model X',2),
('Model 3',2),
('Nova', 3)



//3


CREATE TABLE Exams(
ExamID INT IDENTITY (101,1) NOT NULL,
[Name] VARCHAR (50) NOT NULL,

CONSTRAINT PK_Exams PRIMARY KEY (ExamID) )

CREATE TABLE Students(
StudentID INT NOT NULL,
[Name] VARCHAR (50) NOT NULL

CONSTRAINT PK_Students PRIMARY KEY (StudentID)
)



CREATE TABLE StudentsExams(
StudentID INT NOT NULL,
ExamID INT NOT NULL,


CONSTRAINT PK_StudentsExams 
PRIMARY KEY(StudentID, ExamID),

CONSTRAINT FK_StudentExams_Exams 
FOREIGN KEY (ExamID)
REFERENCES Exams(ExamID),

CONSTRAINT FK_StudentExams_Students
FOREIGN KEY (StudentID)
REFERENCES Students(StudentID)
)


INSERT INTO Students VALUES
(1,'Mila'),
(2,'Toni'),
(3,'Ron')



INSERT INTO Exams VALUES
('SpringMVC'),
('Neo4j'),
('Oracle 11g')


INSERT INTO StudentsExams VALUES
(1,101),
(1,102),
(2,101),
(3,103),
(2,102),
(2,103)

//4

CREATE TABLE Teachers(
TeacherID INT IDENTITY(101,1) NOT NULL,
[Name] VARCHAR (50),
ManagerID INT,

CONSTRAINT PK_Teachers PRIMARY KEY (TeacherID),

CONSTRAINT FK_Teachers_Teachers
FOREIGN KEY (ManagerID)
REFERENCES Teachers(TeacherID) )


INSERT INTO Teachers VALUES
('John',NULL),
('Maya',106),
('Silvia',106),
('Ted',106),
('Mark',101),
('Greta',101)

//5
CREATE DATABASE OnlineStore 

CREATE TABLE Cities(
CityID INT NOT NULL,
[Name] VARCHAR(50)

CONSTRAINT PK_Cities PRIMARY KEY (CityID) )


CREATE TABLE Customers (
CustomerID INT NOT NULL,
[Name] VARCHAR(50),
Birthday DATE,
CityID INT NOT NULL,

CONSTRAINT PK_Customer PRIMARY KEY(CustomerID),

CONSTRAINT FK_Customer_Cities
FOREIGN KEY (CityID)
REFERENCES Cities(CityID) )


CREATE TABLE Orders(
OrderID INT NOT NULL,
CustomerID INT NOT NULL,

CONSTRAINT PK_Orders PRIMARY KEY (OrderID),

CONSTRAINT FK_Orders_Customers
FOREIGN KEY (CustomerID)
REFERENCES Customers(CustomerID) )

CREATE TABLE ItemTypes(
ItemTypeID INT NOT NULL,
[Name] VARCHAR (50),

CONSTRAINT PK_ItemTypes PRIMARY KEY (ItemTypeID) 
)


CREATE TABLE Items(
ItemID INT NOT NULL,
[Name] VARCHAR (50),
ItemTypeID INT NOT NULL,

CONSTRAINT PK_Items PRIMARY KEY (ItemID),
CONSTRAINT FK_Items_ItemTypes FOREIGN KEY (ItemTypeID) REFERENCES ItemTypes(ItemTypeID)
)

CREATE TABLE OrderItems(
OrderID INT NOT NULL,
ItemID INT NOT NULL,

CONSTRAINT PK_OrderItems PRIMARY KEY (OrderID, ItemID),
CONSTRAINT FK_OrderItems_Orders FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
CONSTRAINT FK_OrderItems_Items FOREIGN KEY (ItemID) REFERENCES Items (ItemID)  )


//6
CREATE DATABASE University
USE University

CREATE TABLE Majors(
MajorID INT NOT NULL,
[Name] VARCHAR (50),

CONSTRAINT PK_Majors PRIMARY KEY(MajorID) )



CREATE TABLE Students(
StudentID INT NOT NULL,
StudentNumber INT NOT NULL,
StudentName NVARCHAR(50),
MajorID INT NOT NULL,

CONSTRAINT PK_Students PRIMARY KEY(StudentID),
CONSTRAINT FK_Students_Majors FOREIGN KEY (MajorID) REFERENCES Majors(MajorID) )



CREATE TABLE Payments(
PaymentID INT NOT NULL,
PaymentDate DATE,
PaymentAmount DECIMAL (15,2),
StudentID INT NOT NULL,

CONSTRAINT PK_Payments PRIMARY KEY (PaymentID),
CONSTRAINT FK_Payments_Students FOREIGN KEY (StudentID) REFERENCES Students(StudentID) )


CREATE TABLE Subjects(
SubjectID INT NOT NULL,
SubjectName VARCHAR (50),

CONSTRAINT PK_Sujebcts PRIMARY KEY (SubjectID))



CREATE TABLE Agenda(
StudentID INT NOT NULL,
SubjectID INT NOT NULL,

CONSTRAINT PK_Agenda PRIMARY KEY(StudentID, SubjectID),
CONSTRAINT FK_Agenda_Subjects FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID),
CONSTRAINT FK_Agenda_Students FOREIGN KEY(StudentID) REFERENCES Students(StudentID) )


//9
USE Geography

SELECT MountainRange, PeakName, Elevation
FROM Peaks AS p
JOIN Mountains AS m
ON p.MountainId = m.Id
WHERE m.MountainRange = 'Rila'
ORDER BY Elevation DESC


