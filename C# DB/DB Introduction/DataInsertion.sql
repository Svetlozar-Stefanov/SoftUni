USE Minions

INSERT INTO Towns ([Name])
VALUES
	('Sofia'),
	('Plovdiv'),
	('Varna');

INSERT INTO Minions([Name], Age, TownId)
VALUES
	('Kevin', 22, 1),
	('Bob', 15, 3),
	('Steward', NULL, 2);