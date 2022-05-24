Create database dbQLBaiGiang
go

use dbQLBaiGiang
go

create table tblSinhVien
(
	sMaSV  NVARCHAR(20) primary key  ,
	sTenSV NVARCHAR(30)  ,
	sLop NVARCHAR(30)  ,
	sGioiTinh NVARCHAR(10),
	dNgaySinh date ,
	sEmail NVARCHAR(250) 
)
go

Create table tblGiangVien
(
	sMaGV nvarchar(20) primary key,
	sTenGV NVARCHAR(30),
	sSDT NVARCHAR(12),
	sEmail nvarchar(100)
	
)
go

create table tblMonHoc
(
	iMaMon INT IDENTITY PRIMARY KEY ,
	sTenMon nvarchar(200),
	iSoTC int
)
go

create table tblLopTC
(
	iMaLopTC INT IDENTITY PRIMARY KEY,
	sTenLopTC nvarchar(200),
	sStatus nvarchar(100) default N'Học',
	sMaGV nvarchar(20),
	iMaMon  int,
	foreign key(sMaGV) references tblGiangVien(sMaGV),
	foreign key(iMaMon) references tblMonHoc(iMaMon)
)
go

create table tblLoaiTaiLieu
(
	iMaLoai INT IDENTITY PRIMARY KEY,
    sTenLoai nvarchar(200)
)
go

create table tblTaiLieu
(
	iMaTL INT IDENTITY PRIMARY KEY,
	sTenTL nvarchar(200),
	iMaLoai int,
	iMaMon int,
	iMaLopTC int,
	foreign key(iMaLoai) references tblLoaiTaiLieu(iMaLoai),
	foreign key(iMaMon) references tblMonHoc(iMaMon),
	foreign key(iMaLopTC) references tblLopTC(iMaLopTC)
)
go

create table tblDangKy
(
	iMaDK INT IDENTITY PRIMARY KEY,
	dTGDK datetime,
	sMaSV  NVARCHAR(20),
	iMaLopTC int,
	foreign key(sMaSV) references tblSinhVien(sMaSV),
	foreign key(iMaLopTC) references tblLopTC(iMaLopTC)
)
go

create table tblTaiKhoan
(
	sTenDangNhap nvarchar(20) primary key,
	sPassword nvarchar(50),
	iLoaiTK int --- 1: sinh vien - 2: giang vien - 3: admin
)
go


------------------- Sinh vien
create procedure getSVByMa
@maSV nvarchar(20)
as
begin
select * from tblSinhVien
where sMaSV = @maSV
end
go

------------------- Mon hoc
create proc getMonByMaSV
@maSV nvarchar(20)
as
begin
select tblMonHoc.iMaMon, tblMonHoc.sTenMon,tblLopTC.iMaLopTC, tblLopTC.sTenLopTC, tblLopTC.sStatus from tblMonHoc, tblLopTC, tblDangKy
where tblMonHoc.iMaMon = tblLopTC.iMaMon
and tblLopTC.iMaLopTC = tblDangKy.iMaLopTC
and tblDangKy.sMaSV = @maSV
end
go

-- lay nhung mon còn lại đã đki
create proc getMonConLaiDaDK
@maSV nvarchar(20),
@maMon int
as
begin
select tblMonHoc.iMaMon, tblMonHoc.sTenMon,tblLopTC.iMaLopTC, tblLopTC.sTenLopTC, tblLopTC.sStatus from tblMonHoc, tblLopTC, tblDangKy
where tblMonHoc.iMaMon = tblLopTC.iMaMon
and tblLopTC.iMaLopTC = tblDangKy.iMaLopTC
and tblDangKy.sMaSV = @maSV
and tblMonHoc.iMaMon
not in
(
	select iMaMon  from tblMonHoc
	where tblMonHoc.iMaMon = @maMon
)
end
go

---- ds mon chua dang ky theo ma
create proc getMonChuaDKByMaSV
@maSV nvarchar(20)
as
begin
select * from tblMonHoc, tblLopTC
where tblMonHoc.iMaMon = tblLopTC.iMaMon
and tblLopTC.iMaLopTC 
NOT IN 
(
	select iMaLopTC  from tblDangKy
	where tblDangKy.sMaSV = @maSV
)
end
go


--- tim kiem gan dung ten mon
create proc searchMonChuaDK
@maSV nvarchar(20),
@tenMon  nvarchar(200)
as
begin
select * from tblMonHoc, tblLopTC
where tblMonHoc.iMaMon = tblLopTC.iMaMon
and  ((tblMonHoc.sTenMon like '%'+IsNull(@tenMon ,tblMonHoc.sTenMon)+'%'))
and tblLopTC.iMaLopTC 
NOT IN 
(
	select iMaLopTC  from tblDangKy
	where tblDangKy.sMaSV = @maSV
)
end
go

exec searchMonChuaDK  @maSV = N'18A111',@tenMon= N'đảm'

------------------- dang ky
create PROCEDURE insertDangKy
@maSV nvarchar(20),
@maLopTC int,
@tGDK date
AS 
BEGIN 
INSERT INTO tblDangKy(sMaSV, iMaLopTC, dTGDK)
VALUES (@maSV, @maLopTC, @tGDK)
END 
go

---------- lay ten mon hoc va giang vien
create proc getTenMonGiangVien
@maMon int,
@maLopTC int
as
BEGIN 
select * from tblGiangVien, tblLopTC, tblMonHoc
where tblLopTC.sMaGV = tblGiangVien.sMaGV
and tblLopTC.iMaMon = tblMonHoc.iMaMon
and tblMonHoc.iMaMon = @maMon
and tblLopTC.iMaLopTC = @maLopTC
END 
go

------ hien mon hoc khac

create proc getMonChuaDKConLaiByMaSV
@maSV nvarchar(20),
@maMon int
as
begin
select * from tblMonHoc, tblLopTC
where tblMonHoc.iMaMon = tblLopTC.iMaMon
and tblLopTC.iMaLopTC 
NOT IN 
(
	select iMaLopTC  from tblDangKy
	where tblDangKy.sMaSV = @maSV
)
and tblMonHoc.iMaMon
not in
(
	select iMaMon  from tblMonHoc
	where tblMonHoc.iMaMon = @maMon
)
end
go

--- Tai Lieu

create proc getByMaMon
@maMon int
as
BEGIN 
select * from tblTaiLieu
where iMaMon = @maMon
END 
go

select * from tblTaiLieu
where iMaTL = 4

--------- Tai Khoan
create proc LoginTaiKhoan
@sTenDangNhap nvarchar(20),
@sPassword nvarchar(50)
as
begin
select * from tblTaiKhoan
where sTenDangNhap = @sTenDangNhap
and sPassword = @sPassword
and iLoaiTK =1
end
go

create proc LoginTaiKhoanTea
@sTenDangNhap nvarchar(20),
@sPassword nvarchar(50)
as
begin
select * from tblTaiKhoan
where sTenDangNhap = @sTenDangNhap
and sPassword = @sPassword
and iLoaiTK =2
end
go


create proc LoginTaiKhoanAd
@sTenDangNhap nvarchar(20),
@sPassword nvarchar(50)
as
begin
select * from tblTaiKhoan
where sTenDangNhap = @sTenDangNhap
and sPassword = @sPassword
and iLoaiTK =2
end
go





