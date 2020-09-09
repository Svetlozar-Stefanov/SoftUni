CREATE DATABASE Softuni;

USE Softuni;

CREATE TABLE Towns(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(50) NOT NULL);

CREATE TABLE Addresses(
Id INT PRIMARY KEY IDENTITY,
AdressText NVARCHAR(100) NOT NULL,
TownId INT NOT NULL
FOREIGN KEY(TownId) REFERENCES Towns(Id));

CREATE TABLE Departments(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(50) NOT NULL);

CREATE TABLE Employees(
Id INT PRIMARY KEY IDENTITY,
FirstName NVARCHAR(30) NOT NULL,
MiddleName NVARCHAR(30),
LastName NVARCHAR(30) NOT NULL,
JobTitle NVARCHAR(50) NOT NULL,
DepartmentId INT NOT NULL
FOREIGN KEY(DepartmentId) REFERENCES Departments(Id),
HireDate DATE NOT NULL,
Salary DECIMAL NOT NULL,
AddressId INT
FOREIGN KEY(AddressId) REFERENCES Addresses(Id));

INSERT INTO Towns
VALUES
('Sofia'),
('Plovdiv'),
('Varna'),
('Burgas');

INSERT INTO Departments
VALUES
('Engineering'),
('Sales'),
('Marketing,'),
('Software Development'),
('Quality Assurance');

INSERT INTO Employees
VALUES
('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, '02.01.2013', 3500.00, NULL),
('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, '03.02.2004', 4000.00, NULL),
('Maria', 'Petrova', 'Ivanova', 'Intern', 5, '08.28.2016', 525.25, NULL),
('Georgi', 'Teziev', 'Ivanov', 'CEO', 2, '12.09.2007', 3000.00, NULL),
('Peter', 'Pan', 'Pan', 'Intern', 3, '08.28.2016', 599.88, NULL);

SELECT * FROM Towns
ORDER BY [Name];

SELECT * FROM Departments
ORDER BY [Name];

SELECT * FROM Employees
ORDER BY Salary DESC;


SELECT [Name] FROM Towns
ORDER BY [Name];

SELECT [Name] FROM Departments
ORDER BY [Name];

SELECT FirstName, LastName, JobTitle, Salary FROM Employees
ORDER BY Salary DESC;

UPDATE Employees
SET Salary = Salary + Salary * 0.1;

SELECT Salary FROM Employees;