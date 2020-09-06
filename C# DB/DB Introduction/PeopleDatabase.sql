CREATE DATABASE PersonalInfo;

CREATE TABLE People (
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(200) NOT NULL,
Picture IMAGE,
Height FLOAT(2),
Kilograms FLOAT(2),
Gender CHAR(1),
Birth DATE NOT NULL,
Biography NVARCHAR(MAX))

INSERT INTO People ([Name],Picture, Height, Kilograms, Gender, Birth, Biography)
VALUES
('Bob', NULL, 1.42, 70.12, 'M', GETDATE(), NULL),
('Job', NULL, 4.20, 70.12, 'M', GETDATE(), NULL),
('Sob', NULL, 0.69, 70.12, 'M', GETDATE(), NULL),
('Rob', NULL, 1.41, 70.12, 'M', GETDATE(), NULL),
('Mob', NULL, 1.43, 70.12, 'M', GETDATE(), NULL);