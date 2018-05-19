use master
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
insert QUAN VALUES ('13','Quận Thủ Đức')
insert QUAN VALUES ('14','Quận Gò Vấp')
insert QUAN VALUES ('15','Quận Bình Thạnh')
insert QUAN VALUES ('16','Quận Tân Bình')
insert QUAN VALUES ('17','Quận Tân Phú')
insert QUAN VALUES ('18','Quận Phú Nhuận')
insert QUAN VALUES ('19','Quận Bình Tân')
insert QUAN VALUES ('20','Huyện Củ Chi')
go
insert LoaiDL VALUES ('1','Loai 1')
insert LoaiDL VALUES ('2','Loai 2')
go
select *from DAILY