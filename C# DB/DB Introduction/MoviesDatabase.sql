USE Movies;

CREATE TABLE Directors(
Id INT PRIMARY KEY NOT NULL IDENTITY,
DirectorName NVARCHAR(100) NOT NULL,
Notes NVARCHAR(MAX))

CREATE TABLE Genres(
Id INT PRIMARY KEY NOT NULL IDENTITY,
GenreName NVARCHAR(50) NOT NULL,
Notes NVARCHAR(MAX))

CREATE TABLE Categories(
Id INT PRIMARY KEY NOT NULL IDENTITY,
CategoryName NVARCHAR(100) NOT NULL,
Notes NVARCHAR(MAX))

CREATE TABLE Movies(
Id INT PRIMARY KEY NOT NULL IDENTITY,
Title NVARCHAR(50) NOT NULL,
DirectorId INT NOT NULL
FOREIGN KEY(DirectorId) REFERENCES Directors(Id),
CopyrightYear DATE NOT NULL,
[Length] FLOAT NOT NULL,
GenreId INT NOT NULL
FOREIGN KEY (GenreId) REFERENCES Genres(Id),
CategoryId INT NOT NULL
FOREIGN KEY(CategoryId) REFERENCES Categories(Id),
Rating FLOAT,
Notes NVARCHAR(MAX));

INSERT INTO Directors
VALUES
('Tarantino', NULL),
('George Lucas', NULL),
('Tarantino', NULL),
('George Lucas', NULL),
('Tarantino', NULL),
('George Lucas', NULL);

INSERT INTO Genres
VALUES
('Fiction', NULL),
('Fantasy', NULL),
('SCI_FI', NULL),
('Fiction', NULL),
('Fantasy', NULL),
('SCI_FI', NULL);

INSERT INTO Categories
VALUES
('Fiction', NULL),
('Fantasy', NULL),
('SCI_FI', NULL),
('Fiction', NULL),
('Fantasy', NULL),
('SCI_FI', NULL);

INSERT INTO Movies
VALUES
('SHREK 5', 1, GETDATE(), 2.30, 1, 3, 10, NULL),
('SHREK 5', 1, GETDATE(), 2.30, 1, 3, 10, NULL),
('SHREK 5', 1, GETDATE(), 2.30, 1, 3, 10, NULL),
('SHREK 5', 1, GETDATE(), 2.30, 1, 3, 10, NULL),
('SHREK 5', 1, GETDATE(), 2.30, 1, 3, 10, NULL);