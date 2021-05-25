CREATE DATABASE BekerjaDenganData2
USE BekerjaDenganData2

CREATE TABLE jabatan
(id_jabatan varchar(5) not null primary key,
 nama_jabatan varchar(50) not null)

CREATE TABLE karyawan
(nik varchar(10) not null primary key,
 nama_karyawan varchar(100) not null,
 jabatan varchar(5),

 FOREIGN KEY(jabatan) REFERENCES jabatan(id_jabatan) ON UPDATE CASCADE ON DELETE CASCADE)

SELECT * FROM karyawan
SELECT * FROM jabatan

DELETE FROM jabatan WHERE id_jabatan = ' '

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 --=====================================--
 -- Author		: Irza Muhammad Fatir
 -- Create Date	: 29 April 2021
 -- Description	: Insert data jabatan
 --=====================================--
CREATE PROCEDURE [dbo].[sp_InputJabatan]
	@id_jabatan varchar(5),
	@nama_jabatan varchar(50)
AS
BEGIN
	INSERT INTO Jabatan (id_jabatan,nama_jabatan)
	VALUES
	(
		@id_jabatan,
		@nama_jabatan
	)
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 --=====================================--
 -- Author		: Irza Muhammad Fatir
 -- Create Date	: 29 April 2021
 -- Description	: Insert data karyawan
 --=====================================--
CREATE PROCEDURE [dbo].[sp_InputKaryawan]
	@nik varchar(10),
	@nama_karyawan varchar(100),
	@jabatan varchar(5)
AS
BEGIN
	INSERT INTO karyawan(nik,nama_karyawan,jabatan)
	VALUES
	(
		@nik,
		@nama_karyawan,
		@jabatan
	)
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 --=====================================--
 -- Author		: Irza Muhammad Fatir
 -- Create Date	: 29 April 2021
 -- Description	: Update data karyawan
 --=====================================--
CREATE PROCEDURE [dbo].[sp_UpdateKaryawan]
	@nik varchar(10),
	@nama_karyawan varchar(100),
	@jabatan varchar(5)
AS
BEGIN
	UPDATE karyawan SET
	nama_karyawan = @nama_karyawan,
	jabatan = @jabatan
	WHERE nik = @nik
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 --=====================================--
 -- Author		: Irza Muhammad Fatir
 -- Create Date	: 29 April 2021
 -- Description	: Cari data karyawan
 --=====================================--
CREATE PROCEDURE [dbo].[sp_CariData]
	@nik varchar(10)
AS
BEGIN
	SELECT * FROM karyawan WHERE nik = @nik
END


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 --=====================================--
 -- Author		: Irza Muhammad Fatir
 -- Create Date	: 29 April 2021
 -- Description	: Delete data karyawan
 --=====================================--
CREATE PROCEDURE [dbo].[sp_DeleteKaryawan]
	@nik varchar(10)
AS
BEGIN
	DELETE FROM karyawan WHERE nik = @nik
END
