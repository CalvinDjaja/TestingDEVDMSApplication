Database:
---------------------------------------------------------------------------------------------------
CREATE DATABASE DMS;

CREATE TABLE Education (
    ID INT PRIMARY KEY,
    Name VARCHAR(100)
);

INSERT INTO Education (ID, Name)
VALUES
(1, 'SMA atau dibawahnya'),
(2, 'D1, D2, D3, D4'),
(3, 'S1'),
(4, 'Master atau diatasnya (S2, S3)');

CREATE TABLE OwnershipOfResidence (
    ID INT PRIMARY KEY,
    Name VARCHAR(100)
);

INSERT INTO OwnershipOfResidence (ID, Name)
VALUES
(1, 'Lain-lain'),
(2, 'Sewa / Kontrak'),
(3, 'Milik sendiri masih diangsur'),
(4, 'Milik sendiri');

CREATE TABLE CompanyCategory (
    ID INT PRIMARY KEY,
    Name VARCHAR(100)
);

INSERT INTO CompanyCategory (ID, Name)
VALUES
(11,'Lembaga Departemen'),
(25,'BUMD'),
(31,'SWASTA tidak punya rating'),
(32,'SWASTA dengan rating'),
(33,'SWASTA Katergori I'),
(34,'SWASTA Kategori II'),
(35,'SWASTA Kategori III');

CREATE TABLE Department (
    ID INT PRIMARY KEY,
    Name VARCHAR(100)
);

INSERT INTO Department (ID, Name)
VALUES
(1, 'Staff'),
(2, 'Direktur'),
(3, 'Komisaris');

CREATE TABLE RecordPaymentTrack (
    ID INT PRIMARY KEY,
    Name VARCHAR(100)
);

INSERT INTO RecordPaymentTrack (ID, Name)
VALUES
(1, 'Peminjam baru'),
(2, 'Angsuran terlambat tapi lancar'),
(3, 'Angsuran tepat waktu');

CREATE TABLE TrackDataSLIK (
    ID INT PRIMARY KEY,
    Name VARCHAR(100)
);

INSERT INTO TrackDataSLIK (ID, Name)
VALUES
(1, 'Kolektibilitas 3 sd 5'),
(2, 'Ada tunggakan < 3 bulan'),
(3, 'Tidak ada fasilitas'),
(4, 'Lancar');

CREATE TABLE PemilikanKartuKredit (
    ID INT PRIMARY KEY,
    Name VARCHAR(100)
);

INSERT INTO PemilikanKartuKredit (ID, Name)
VALUES
(1, 'Tidak Ada'),
(2, 'Basic'),
(3, 'Gold'),
(4, 'Platinum atau diatasnya');

CREATE TABLE TujuanDariPembiayaan (
    ID INT PRIMARY KEY,
    Name VARCHAR(100)
);

INSERT INTO TujuanDariPembiayaan (ID, Name)
VALUES
(1, 'Lain-Lain'),
(2, 'Disewakan/Investasi'),
(3, 'Renovasi'),
(4, 'Pertama & Ditempati Sendiri');

CREATE TABLE Customer (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Code NVARCHAR(50) NOT NULL,
    Name NVARCHAR(150) NOT NULL,
    BirthDate DATETIME NOT NULL,
    BirthPlace NVARCHAR(100) NOT NULL,
    Gender NVARCHAR(10) NOT NULL,
    PostalCode NVARCHAR(20) NOT NULL,
    Address NVARCHAR(255) NOT NULL,
    IsMarriage BIT NOT NULL DEFAULT 0,
    ManyKids INT NOT NULL,
    EducationID INT NOT NULL,
    BankAddress NVARCHAR(255) NOT NULL,
    OwnershipOfResidenceID INT NOT NULL,
    OccupiedTime INT NOT NULL,
    CompanyCategoryID INT NOT NULL,
    DepartmentID INT NOT NULL,
    WorkTime INT NOT NULL,
    EarningTHP DECIMAL(18,2) NOT NULL DEFAULT 0,
    IsTabungan BIT NOT NULL DEFAULT 0,
    IsGiro BIT NOT NULL DEFAULT 0,
    IsDeposito BIT NOT NULL DEFAULT 0,
    SaldoRate DECIMAL(18,2) NOT NULL DEFAULT 0,
    RecordPaymentTrackID INT NOT NULL,
    TrackDataSLIKID INT NOT NULL,
    PemilikanKartuKreditID INT NOT NULL,
    Tenor INT NOT NULL,
    DebtServiceRatio INT NOT NULL,
    HasilAppraisal INT NOT NULL,
    LuasBangun INT NOT NULL,
    TujuanDariPembiayaanID INT NOT NULL,
    LTV INT NOT NULL,
    RowStatus INT NOT NULL DEFAULT 0,
    
    -- Foreign keys
    CONSTRAINT FK_Customer_Education FOREIGN KEY (EducationID) REFERENCES Education(ID),
    CONSTRAINT FK_Customer_OwnershipOfResidence FOREIGN KEY (OwnershipOfResidenceID) REFERENCES OwnershipOfResidence(ID),
    CONSTRAINT FK_Customer_CompanyCategory FOREIGN KEY (CompanyCategoryID) REFERENCES CompanyCategory(ID),
    CONSTRAINT FK_Customer_Department FOREIGN KEY (DepartmentID) REFERENCES Department(ID),
    CONSTRAINT FK_Customer_RecordPaymentTrack FOREIGN KEY (RecordPaymentTrackID) REFERENCES RecordPaymentTrack(ID),
    CONSTRAINT FK_Customer_TrackDataSLIK FOREIGN KEY (TrackDataSLIKID) REFERENCES TrackDataSLIK(ID),
    CONSTRAINT FK_Customer_PemilikanKartuKredit FOREIGN KEY (PemilikanKartuKreditID) REFERENCES PemilikanKartuKredit(ID),
    CONSTRAINT FK_Customer_TujuanDariPembiayaan FOREIGN KEY (TujuanDariPembiayaanID) REFERENCES TujuanDariPembiayaan(ID)
);

INSERT INTO Customer
(
    Code, Name, BirthDate, BirthPlace, Gender, PostalCode, Address,
    IsMarriage, ManyKids, EducationID, BankAddress, OwnershipOfResidenceID,
    OccupiedTime, CompanyCategoryID, DepartmentID, WorkTime, EarningTHP,
    IsTabungan, IsGiro, IsDeposito, SaldoRate, RecordPaymentTrackID,
    TrackDataSLIKID, PemilikanKartuKreditID, Tenor, DebtServiceRatio,
    HasilAppraisal, LuasBangun, TujuanDariPembiayaanID, LTV, RowStatus
)
VALUES
('C001','John Doe','1990-01-01','Jakarta','Male','12345','Jl. Contoh No 1',1,2,3,'Jl. Contoh No 1',4,5,32,1,10,15000000.00,1,0,1,500000.00,3,4,2,12,30,1,120,4,75,1),
('C002','Jane Smith','1985-05-15','Bandung','Female','40123','Jl. Mawar No 2',0,0,4,'Jl. Bank No 2',2,3,25,2,8,12000000.00,1,1,0,300000.00,2,1,3,24,25,1,100,3,65,1),
('C003','Michael Lee','1992-08-22','Surabaya','Male','60234','Jl. Melati No 3',1,1,2,'Jl. Melati No 3',3,2,31,1,5,8000000.00,0,0,0,0.00,1,2,1,12,35,1,90,2,70,1),
('C004','Siti Aminah','1988-12-10','Jakarta','Female','12346','Jl. Kenanga No 4',1,3,1,'Jl. Kenanga No 4',1,6,11,3,20,20000000.00,1,0,0,1000000.00,3,4,2,36,28,1,110,4,80,1),
('C005','Ahmad Fauzi','1995-03-05','Medan','Male','20123','Jl. Anggrek No 5',0,0,3,'Jl. Bank No 5',2,5,34,3,12,9000000.00,0,1,1,500000.00,2,3,1,18,20,1,95,3,60,1);

CREATE TABLE ScoreGroup
(
    ID INT IDENTITY PRIMARY KEY,
    GroupName NVARCHAR(50) NOT NULL,
    BobotB DECIMAL(5,2) NOT NULL
);

INSERT INTO ScoreGroup (GroupName, BobotB) VALUES
('INFORMASI 1', 5),
('INFORMASI 2', 5),
('INFORMASI 3', 20),
('INFORMASI 4', 15),
('INFORMASI 5', 30),
('INFORMASI 6', 25);

CREATE TABLE ScoreGroupItem
(
    ID INT IDENTITY PRIMARY KEY,
    GroupID INT NOT NULL,
    ItemName NVARCHAR(100) NOT NULL,
    BobotD DECIMAL(5,2) NOT NULL,
    FOREIGN KEY (GroupID) REFERENCES ScoreGroup(ID)
);

INSERT INTO ScoreGroupItem (GroupID, ItemName, BobotD) VALUES
(1,'Umur Pemohon',30),
(1,'Umur Pemohon + Tenor',10),
(1,'Status Perkawinan',40),
(1,'Pendidikan',20),

(2,'Alamat tempat tinggal',40),
(2,'Kepemilikan tempat tinggal',30),
(2,'Lama menempati',30),

(3,'Kategori Perusahaan',20),
(3,'Jabatan',20),
(3,'Lama bekerja',20),
(3,'Pendapatan THP',40),

(4,'Rekening Bank',10),
(4,'Rata-rata saldo per bulannya',15),
(4,'Track record pembayaran angsuran',15),
(4,'Track Data SLIK',40),
(4,'Kepemilikan Kartu Kredit',20),

(5,'Tenor',25),
(5,'Debt Service Ratio',75),

(6,'Hasil Appraisal',10),
(6,'Luas Bangunan',20),
(6,'Tujuan dari Pembiayaan',10),
(6,'LTV',60);

CREATE TABLE ScoreItem
(
    ID INT IDENTITY PRIMARY KEY,
    ScoreGroupItemID INT NOT NULL,
    ItemLabel NVARCHAR(150) NOT NULL,
    ScoreF DECIMAL(5,2) NOT NULL,
    FOREIGN KEY (ScoreGroupItemID) REFERENCES ScoreGroupItem(ID)
);

INSERT INTO ScoreItem (ScoreGroupItemID, ItemLabel, ScoreF) VALUES
(1,'56 - 65 Tahun',25),
(1,'21 - 30 Tahun',50),
(1,'31 - 45 Tahun',100),
(1,'46 - 55 Tahun',75),
(2,'Diatas Ketentuan',25),
(2,'Dibawah Ketentuan',100),
(3,'Belum Kawin dengan > 2 tanggungan',25),
(3,'Belum Kawin dengan <= 2 tanggungan',45),
(3,'Belum Kawin dengan 0 tanggungan',65),
(3,'Kawin dengan > 2 tanggungan',85),
(3,'Kawin dengan <= 2 tanggungan',100),
(4,'SMA atau dibawahnya',25),
(4,'D1, D2, D3, D4',50),
(4,'S1',75),
(4,'Master atau diatasnya (S2, S3)',100),
(5,'Tidak sesuai dengan data Bank',25),
(5,'Sesuai dengan data Bank',100),
(6,'Lain-lain',25),
(6,'Sewa / Kontrak',50),
(6,'Milik sendiri masih diangsur',75),
(6,'Milik sendiri',100),
(7,'<= 2 tahun',25),
(7,'> 2 - 5 tahun',50),
(7,'> 5 - 8 tahun',75),
(7,'> 8 tahun',100);

---------------------------------------------------------------------------------------------------

DevExtreme 22.1.3
.Net 7
