﻿--local db
--language: Vietnamese
--db-name : QuanLyThiTracNghiem
use master
drop database QLTracNghiem;

create database QLTracNghiem;
use QLTracNghiem;


create table NguoiDung(
	MaSo int identity,
	TenTaiKhoan varchar(255) unique,
	MatKhau varchar(255),
	HoTen nvarchar(255),
	NgaySinh date,
	GioiTinh nvarchar(255),
	PhanHe nvarchar(255),
	primary key(MaSo)
	);
alter table NguoiDung
	add check (PhanHe in (N'Giáo viên',N'Học sinh',N'Admin')),
		check (GioiTinh in ('Nam',N'Nữ'));


create table Khoi(
	MaSo int identity,
	TenKhoi nvarchar(255) unique,
	primary key (MaSo )
	);

create table MonHoc(
	MaSo int identity,
	TenMH nvarchar(100) unique,
	primary key (MaSo)
	);


create table LopHoc(
	MaSo int identity,
	MaKhoi int,
	SiSo int default 0,
	primary key (MaSo)
	);
alter table LopHoc
	add foreign key (MaKhoi) references Khoi(MaSo)


create table HocSinh(
	MaNguoiDung int,
	MaHS varchar(255) unique,
	MaLop int,
	primary key(MaNguoiDung)
	);
alter table HocSinh
	add	foreign key (MaNguoiDung) references NguoiDung(MaSo),
		foreign key (MaLop) references LopHoc(MaSo);

create table GiaoVien(
	MaNguoiDung int, 
	MaGV varchar(255) unique,
	MaMonHoc int,
	primary key(MaNguoiDung)
	);
alter table GiaoVien
	add foreign key (MaNguoiDung) references NguoiDung(MaSo),
		foreign key (MaMonHoc) references MonHoc(MaSo) ;

create table GiaoVien_Day_MonHoc(
	MaMonHoc int,
	MaLopHoc int,
	primary key(MaMonHoc,MaLopHoc)
	);
alter table GiaoVien_Day_MonHoc
	add foreign key(MaMonHoc) references MonHoc(MaSo),
		foreign key(MaLopHoc) references LopHoc(MaSo);

create table KyThi(
	MaSo int identity primary key,
	TenKyThi nvarchar(255) unique,
	NgayBatDau date,
	NgayKetThuc date
	);
	
create table CauHoi(
	MaSo int identity,
	MaMonHoc int,
	NoiDungCauHoi text,
	DoKho nvarchar(255),
	primary key(MaSo)
	);
alter table CauHoi
	add check (DoKho in (N'Dễ',N'Trung bình', N'Khó')),
		foreign key (MaMonHoc) references MonHoc(MaSo)


create table CauHoi_DongGop(
	MaCauHoi int,
	MaNguoiDongGop int,
	TenNguoiDongGop nvarchar(255),
	TrangThaiDuyet nvarchar(255),
	primary key(MaCauHoi,MaNguoiDongGop)
	);
alter table CauHoi_DongGop
	add check (TrangThaiDuyet in (N'Rồi', N'Chưa')),
		foreign key (MaNguoiDongGop) references NguoiDung(MaSo),
		foreign key (MaCauHoi) references CauHoi(MaSo);


create table DapAn(
	MaSo int identity,
	MaCauHoi int,
	DapAn nvarchar(255),
	ketqua nvarchar(255),
	primary key(MaSo)
	);
alter table DapAn
	add foreign key (MaCauHoi) references CauHoi(MaSo),
		check (ketqua in (N'Đúng', N'Sai'));


create table DeThi(
	MaSo int identity,
	MaMonHoc int,
	MaKyThi int,
	ThoiGianThi float,
	primary key (MaSo))
alter table DeThi
	add foreign key (MaMonHoc) references MonHoc(MaSo),
		foreign key (MaKyThi) references KyThi(MaSo);


create table DeThi_CauHoi(
	MaDeThi int,
	MaCauHoi int
	primary key(MaDeThi,MaCauHoi)
	);
alter table DeThi_CauHoi
	add foreign key (MaDeThi) references DeThi(MaSo),
		foreign key (MaCauHoi) references CauHoi(MaSo)

create table BaiThi(
	MaSo int identity,
	MaDeThi int,
	MaThiSinh int,
	TinhTrang nvarchar(255),
	NgayThi datetime default getdate(),
	ThoiGian_DaLam float,
	primary key(MaSo)
	);
alter table BaiThi
	add foreign key (MaDeThi) references DeThi(MaSo),
		foreign key (MaThiSinh) references NguoiDung(MaSo),
		check (TinhTrang in (N'Đã nộp', N'Chưa nộp'))


create table BaiThi_ChiTiet(
	MaBaiThi int,
	MaCauHoi int,
	MaDapAn_DaChon int
	primary key(MaBaiThi, MaCauHoi, MaDapAn_DaChon)
	);
alter table BaiThi_ChiTiet
	add foreign key (MaCauHoi) references CauHoi(MaSo),
		foreign key (MaBaiThi) references BaiThi(MaSo),
		foreign key (MaDapAn_DaChon) references DapAn(MaSo);


create table KetQua(
	MaTaiKhoan int,
	MaBaiThi int,
	Diem float,
	primary key(MaTaiKhoan,MaBaiThi)
	);
alter table KetQua
	add foreign key (MaTaiKhoan) references NguoiDung(MaSo),
		foreign key (MaBaiThi) references BaiThi(MaSo)

