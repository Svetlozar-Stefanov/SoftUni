CREATE TABLE Users(
Id BIGINT NOT NULL PRIMARY KEY IDENTITY,
Username VARCHAR(30) NOT NULL UNIQUE,
[Password] VARCHAR(26) NOT NULL,
ProfilePicture VARBINARY(900),
LastLoginTime DATETIME2,
IsDeleted BIT);

INSERT INTO Users
VALUES
('Jack', 'jAckTHeCoolEStGuY', NULL, NULL, 0),
('Jackie', 'jAckTHeCoolEStGuY', NULL, NULL, 0),
('JackieBoi', 'jAckTHeCoolEStGuY', NULL, NULL, 0),
('JackSparow', 'jAckTHeCoolEStGuY', NULL, NULL, 0),
('JackTheRapper', 'jAckTHeCoolEStGuY', NULL, NULL, 0);