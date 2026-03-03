/*
========================================
DML - Data Manipulation Language
========================================
CRUD işlemleri.
*/

USE OrnekDB;
GO

-- INSERT
INSERT INTO Personel (PersonelId, Adi, Soyadi)
VALUES (1, 'Ahmet', 'Yılmaz');

-- SELECT
SELECT * FROM Personel;

-- UPDATE
UPDATE Personel
SET Adi = 'Mehmet'
WHERE PersonelId = 1;

-- DELETE
DELETE FROM Personel
WHERE PersonelId = 1;