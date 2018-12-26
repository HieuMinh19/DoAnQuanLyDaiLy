use master
go
create database QuanLyDaiLy
go
use QuanLyDaiLy
go
create table DAILY
(	MaDL int identity(1,1) primary key ,
	TenDL varchar(20),
	DiaChi varchar(40),
	Email varchar(40),
	DienThoai varchar(11),
	NgTiepNhan smalldatetime,
	NoCuaDaiLy int, 
	MaQuan int,
	MaLoaiDL int,
	MaNguoiDaiDien int,
)
go
set dateformat ymd
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
create table NGUOIDAIDIEN
(
	MaNguoiDaiDien int identity(1,1) primary key,
	SoDT int,
	CMND varchar(15),
	DiaChi varchar(20),
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
create table LOAIXE
(
	MaXe int primary key, 
	TenXe varchar(40),
	SoLuongTon int
)

go 
create table DONGIA
(
	MaDonGia int primary key,
	MaXe  int,		
	SoTien varchar(40),
)

go
create table PHIEUTHUTIEN
(
	MaPhieuThu int identity(1,1) primary key,
	MaDaiLy int, 
	NgayThuTien smalldatetime,
	SoTienThu int
	--tong tri gia nua
	--TiLe nua
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
	Id int,
	SoDaiLyToiDa int,
	SoLoaiDaiLy int,
	SoMatHang int, 
	SoDonViTinh int
)
drop table THAMSO
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
insert THAMSO VALUES('1','3','4','3','4');
go

insert into DAILY VALUES(2,'dai ly 3', '123 so 7', 'DL3@gmail.com','01584389','2018-05-10',1000,2,1,1)

