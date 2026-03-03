/*
========================================
DDL - Data Definition Language
========================================
Tablo, veritabanı oluşturma, değiştirme ve silme işlemleri.
*/

-- Veritabanı oluşturma
CREATE DATABASE OrnekDB;
GO

-- Veritabanını seçme
USE OrnekDB;
GO

-- Veritabanı adını değiştirme
-- ALTER DATABASE OrnekDB MODIFY NAME = OrnekDatabase;

-- Veritabanı silme
-- DROP DATABASE OrnekDatabase;


-- Tablo oluşturma
CREATE TABLE Personel
(
    PersonelId INT NOT NULL,
    Adi VARCHAR(50) NOT NULL,
    Soyadi VARCHAR(50) NOT NULL,
    Email NVARCHAR(50) NULL
);

-- Tabloya sütun ekleme
ALTER TABLE Personel
ADD Telefon NVARCHAR(20) NULL;

-- Sütun değiştirme
ALTER TABLE Personel
ALTER COLUMN Email NVARCHAR(100);

-- Sütun silme
ALTER TABLE Personel
DROP COLUMN Telefon;