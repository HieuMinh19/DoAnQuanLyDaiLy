﻿use master
go
create database QuanLyDaiLy
go
use QuanLyDaiLy
go
create table DAILY
(
	MaDL int identity(1,1) primary key ,
	TenDL varchar(20),
	DiaChi varchar(40),
	Email varchar(40),
	DienThoai varchar(11),
	NgTiepNhan smalldatetime,
	NoCuaDaiLy int, 
	MaQuan int,
	MaLoaiDL int
)
go
drop table DAILY
create table QUAN
(
	MaQuan int primary key,
	TenQuan varchar(20)
)

go
create table LOAIDL
(
	MaLoaiDL int primary key,
	TenLoaiDL varchar(20),
	NoToiDa int,
)

go
create table PHIEUXUAT
(
	MaPhieuXuat int identity(1,1) primary key,
	MaDaiLy int,
	NgayLapPhieu smalldatetime,
	TongGiaTri int
)
go

create table CHITIETPHIEUXUAT
(
	MaChiTietPhieu int identity(1,1) primary key,
	MaPhieuXuat int, 
	MaMatHang int, 
	MaDonViTinh int, 
	SoLuongXuat int,
	DonGia int, 
	ThanhTien int
)
go 
create table MATHANG
(
	MaMatHang int primary key, 
	TenMatHang varchar(40),
	SoLuongTon int
)

go 
create table DONVITINH
(
	MaDonViTinh  int  primary key,		
	TenDonViTinh varchar(40)
)

go
create table PHIEUTHUTIEN
(
	MaPhieuThu int identity(1,1) primary key,
	MaDaiLy int, 
	NgayThuTien smalldatetime,
	SoTienThu int
)
go
create table BAOCAODOANHSO
(
	MaBaoCaoDoanhSo int identity(1,1) primary key,
	MaDaiLy int,
	SoPhieuXuat int, 
	TongGiaTri int,
	TiLe float
)

go 
create table BAOCAOCONGNO
(
	MaBaoCaoCongNo int identity(1,1) primary key,
	MaDaiLy int,
	NoDau int,
	NoCuoi int,
	PhatSinh int,
)
go
Create table THAMSO
(
	ID int,
	SoDaiLyToiDa int,
)

go
insert THAMSO VALUES ('1','4')
go
insert QUAN VALUES ('1','Quan 1')
insert QUAN VALUES ('2','Quan 2')
insert QUAN VALUES ('3','Quan 3')
insert QUAN VALUES ('4','Quan 4')
insert QUAN VALUES ('5','Quan 5')
insert QUAN VALUES ('6','Quan 6')
insert QUAN VALUES ('7','Quan 7')
insert QUAN VALUES ('8','Quan 8')
insert QUAN VALUES ('9','Quan 9')
insert QUAN VALUES ('10','Quan 10')
insert QUAN VALUES ('11','Quan 11')
insert QUAN VALUES ('12','Quan 12')
insert QUAN VALUES ('13','Quan Thu Duc')
insert QUAN VALUES ('14','Quan Go Vap')
insert QUAN VALUES ('15','Quan Binh Thuan')
insert QUAN VALUES ('16','Quan Tan Binh')
insert QUAN VALUES ('17','Quan Tan Phu')
insert QUAN VALUES ('18','Quan Phu Nhuan')
insert QUAN VALUES ('19','Quan Binh Tan')
insert QUAN VALUES ('20','Huyen Cu Chi')
go
insert LOAIDL VALUES ('1','Loai 1', '100000')
insert LOAIDL VALUES ('2','Loai 2', '200000')

go
insert DONVITINH VALUES ('1', 'VND')
insert DONVITINH VALUES ('2','Dola')
go
select * from DAILY
select * from LOAIDL
select * from QUAN
select * from MATHANG
select * from DONVITINH
select * from THAMSO
select * from PHIEUXUAT
select * from CHITIETPHIEUXUAT
select * from PHIEUTHUTIEN
select * from BAOCAODOANHSO 