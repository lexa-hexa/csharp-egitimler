/*
========================================
IDENTITY
========================================
ID alanýnýn otomatik artmasýný saðlar.
IDENTITY(1,1) -> Baþlangýç 1, artýþ 1
*/

CREATE TABLE Ogrenciler
(
    Id INT IDENTITY(1,1) NOT NULL,
    Adi VARCHAR(50) NOT NULL,
    Soyadi VARCHAR(50) NOT NULL,
    Email NVARCHAR(50) NULL
);

-- Identity varsa insert sýrasýnda Id yazýlmaz
INSERT INTO Ogrenciler (Adi, Soyadi, Email)
VALUES ('Ali', 'Yýlmaz', 'ali@mail.com');

SELECT * FROM Ogrenciler;