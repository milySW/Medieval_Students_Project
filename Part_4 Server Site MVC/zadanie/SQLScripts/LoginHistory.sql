CREATE TABLE LoginHistory(
    ID INT NOT NULL PRIMARY KEY IDENTITY,
	DateOfLogging DATETIME NOT NULL,
	UserID INT FOREIGN KEY(PlayerID) REFERENCES Accounts(ID),
	);