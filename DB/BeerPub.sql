USE Master

IF EXISTS(SELECT * FROM sys.databases WHERE NAME='BeerPubDB')
DROP DATABASE BeerPubDB;

GO

CREATE DATABASE BeerPubDB;

GO

USE BeerPubDB;

GO

CREATE TABLE Pub
(
	PubID int identity NOT NULL PRIMARY KEY,
	PubName nvarchar(100) NOT NULL	
);

GO

CREATE TABLE Beer
(
	BeerID int identity NOT NULL PRIMARY KEY,
	BeerName nvarchar(100) NOT NULL,
	BeerPrice int NULL,
	BeerVolume int NULL,
	BeerStock int NULL,
	PubID int FOREIGN KEY REFERENCES Pub(PubID) NOT NULL
);

GO

INSERT INTO Pub VALUES (N'Bridgewater');
INSERT INTO Pub VALUES (N'Paddy Go Easy');
INSERT INTO Beer VALUES (N'Carls Special', 25, 33, 100, 1);
INSERT INTO Beer VALUES (N'Leffe Blonde', 50, 50, 76, 2);
INSERT INTO Beer VALUES (N'Hoegarden', 45, 50, 45, 2);
INSERT INTO Beer VALUES (N'Grøn Tuborg', 18, 33, 300, 1);
INSERT INTO Beer VALUES (N'Carlsberg Pilsner', 18, 33, 335, 2);
INSERT INTO Beer VALUES (N'Newcastle Brown Ale', 35, 50, 56, 1);
INSERT INTO Beer VALUES (N'Carlsberg Pilsner', 15, 33, 454, 1);

GO

--SELECT * FROM Beer;
--SELECT BeerName, BeerPrice, BeerStock FROM Beer WHERE BeerVolume = 33;
--SELECT BeerName, BeerPrice, BeerVolume FROM Beer WHERE BeerPrice < 30;
--SELECT BeerName, BeerPrice, BeerVolume FROM Beer WHERE BeerPrice BETWEEN 25 AND 50;
--SELECT * FROM Beer WHERE PubID = 2;
--SELECT PubName, BeerName, BeerPrice FROM Beer b, Pub p WHERE p.PubID = b.PubID AND PubName = 'Bridgewater';
--SELECT p.PubID, p.PubName, b.BeerName, b.BeerPrice, b.BeerVolume, b.BeerStock, b.PubID FROM Beer b, Pub p;