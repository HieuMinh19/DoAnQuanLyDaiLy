use master
create database QuanLyDaiLy
go
use QuanLyDaiLy
go
create table DAILY
(
	MaDL int primary key identity(1,1),
	TenDL varchar(20),
	DiaChi varchar(40),
	Email varchar(40),
	DienThoai varchar(11),
	NgTiepNhan smalldatetime,
	MaQuan int,
	MaLoaiDL int
)
go
create table QUAN
(
	MaQuan int primary key,
	TenQuan varchar(20)
)
go
create table LOAIDL
(
	MaLoaiDL int primary key,
	TenLoaiDL varchar(20)
)
go
Create table THAMSO
(
	SoDaiLyToiDa int,
)
go
Select *from DAILY