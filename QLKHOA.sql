create database QUANLYKHOA
go
use QUANLYKHOA
go
create table GIANGVIEN
(
	MaGV char(10) primary key,
	HotenGV nvarchar(50),
	Ngaysinh smalldatetime,
	Dienthoai Char(10),
	Diachi nvarchar(150),
	Gmail nvarchar(50),
	MaMH char(10),
	MaLH char(10)
)
create table GVKHOA
(
	MaGVK char(10) primary key,
	HotenGVK nvarchar(50),
	Ngaysinh smalldatetime,
	Dienthoai Char(10),
	Diachi nvarchar(150),
	Gmail nvarchar(50),
	MaLH char(10)
)
go

create table MONHOC
(	
      MaMH char(10) primary key,
	  TenMH nvarchar(100),
      Tinchi int,
	  Sotiet int,
	  MaHK char(10)
)
go
create table HOCKY
(	
      MaHK char(10) primary key,
	  TenHK nvarchar(100),
      Tinchi int,
	  Sotiet int
)
go
Create table LOPHOC
(
    MaLH char(10) primary key,
    TenLH nvarchar(50),
 )
go 
create table TINTUC
(
    MaTT char(10) primary key,
	Tieude nvarchar(50),
	Ngaydang smalldatetime,
	MaGVK char(10)
)
go
create table LoginGV(
MaLogin char(10) primary key,
MaGV char(10),
Password nvarchar(200) not null
)
go
create table LoginGVK(
MaLogin char(10) primary key,
MaGVK char(10),
Password nvarchar(200) not null
)


-- Thêm khóa ngoại
alter table GIANGVIEN  add constraint fk_gv1 foreign key(MaMH) references MONHOC(MaMH);
alter table GIANGVIEN  add constraint fk_gv2 foreign key(MaLH) references LOPHOC(MaLH);
alter table MONHOC  add constraint fk_mh foreign key(MaHK) references HOCKY(MaHK);
alter table TINTUC  add constraint fk_tt foreign key(MaGVK) references GVKHOA(MaGVK);
alter table GVKHOA  add constraint fk_gvk foreign key(MaLH) references LOPHOC(MaLH);
alter table LoginGV  add constraint fk_lg1 foreign key(MaGV) references GIANGVIEN(MaGV);
alter table LoginGVK  add constraint fk_lg2 foreign key(MaGVK) references GVKHOA(MaGVK);

-- Thêm dữ liệu
insert into HOCKY values
	('HKI', N'Học Kỳ 1', 15, 150),
	('HKII', N'Học Kỳ 2', 25, 250)

insert into MONHOC values
	('17021070',N'Anh văn chuyên ngành HTTT&GIS', 3, 45, 'HKI'),
	('17021104',N'Cơ sở viễn thám', 2, 30, 'HKII'),
	('17111026',N'Thiết kế web',3 , 45, 'HKI'),
	('17011002',N'Cơ sở dữ liệu',3 , 45, 'HKI'),
	('17011036',N'An toàn và bảo mật hệ thống thông tin',3 , 45, 'HKII'),
	('17011019',N'Hệ quản trị cơ sở dữ liệu',3 , 45, 'HKII'),
	('17021005',N'Phân tích và thiết kế hệ thống thông tin',3 , 45, 'HKI'),
	('17011138',N'Hệ hỗ trợ ra quyết định',3 , 45, 'HKI'),
	('17011014',N'Ngôn ngữ Java',3 , 45, 'HKII'),
	('17021110',N'Phân tích không gian',2 , 30, 'HKI')

insert into LOPHOC values
	('08TTMT', N'Thông Tin Môi Trương'),
	('08TMDT', N'Thương Mại Điện Tử'),
	('08CNPM', N'Công Nghệ Phần Mềm'),
	('08THMT', N'Tin Học Môi Trường')

insert into GIANGVIEN values
   ('GV01', N'Nguyễn Trần Nam Hưng', 1980-01-04, 0902725853, N'123 Nguyễn Chí Thanh, phường 11, quận 5, TPHCM', 'namhung123@gmail.com', '17021104','08TTMT'),
   ('GV02', N'Trần Văn Thành', 1987-01-01, 0902725123, N'111 Trần Phú, phường 1, quận 6, TPHCM', 'vanthanh12@gmail.com', '17111026','08TMDT'),
   ('GV03', N'Phạm Thị Yến', 1989-03-03, 0981234568, 'TPHCM', 'yenpham111@gmail.com', '17021104','08THMT'),
   ('GV04', N'Nguyễn Phúc Nguyên', 1990-07-08, null , N'Đà Nẵng', 'null', '17021070','08CNPM'),
   ('GV05', N'Nguyễn Thị Ngọc Huyền', 1992-02-04, 01206138612, N'48 Tô Hiệu, phường Nghĩa Thành, TP Gia Nghĩa, Đắk Nông', 'ngochuyenbtf@gmail.com', '17011036','08TTMT'),
   ('GV06', N'Vũ Khánh Đăng Quang', 1990-22-06, 0902725778, N'180 Nguyễn Kiệm, phường 13, quận Gò Vấp, TPHCM', 'quangvu1995@gmail.com', '17021110','08THMT'),
   ('GV07', N'Lê Thị Ngọc Hoa', 1988-08-12, 0806725143, N'199 Tản Đà, phường 9, quận 5, TPHCM', 'ngochoale1208@gmail.com', '17021005','08CNPM'),
   ('GV08', N'Nguyễn Đỗ Đức Duy', 1979-05-05, 0868245959, N'12 An Dương Vương, phường Tân Sơn, quận Sơn Trà, Đà Nẵng', 'ducduynguyen5050@gmail.com','17011014','08TMDT')

insert into GVKHOA values
   ('GVK01', N'Nguyễn Thị Thương Thương', 1992- 23-09, 0333461889, N'124 Nguyễn Thị Minh Khai, phường 1, Quận 1, TPHCM', 'thuongthuong123@gmail.com', '08TTMT'),
   ('GVK02', N'Trần Văn Nam Phong', 1989-15-08, 0977816799, N'84 Ngô Quyền, phường 6, Quận 5, TPHCM', 'namphong1999@gmail.com', '08TMDT'),
   ('GVK03', N'Trần Anh Thư', 1988-11-12, 0333461098, N'9 Nguyễn Thị Thập, phường Tân Hưng, Quận 7, TPHCM', 'null', '08CNPM'),
   ('GVK04', N'Lê Thị Thanh Huyền', 1979-12-06, 0878904456, N'44 Ngô Thời Nhiệm, phường 3, Quận 4, TPHCM', 'thanhhuyenle12@gmail.com', '08THMT')

   
insert into TINTUC values
	('TT01',N'Học bổng sinh viên HKI năm học 2020-2021', 2021-22-06, 'GVK01'),
	('TT02',N'Thời khoá biểu HKII năm học 2020-2021', 2021-12-09, 'GVK02'),
	('TT03',N'Toạ đmà hướng nghệp - Tương lai xanh', 2022-01-14, 'GVK03'),
	('TT04',N'Ngày hội sinh viên thành phố', 2023-26-03, 'GVK04')

insert into LoginGV values
   ('LGGV01','GV01','namhung'),
   ('LGGV02','GV02','vanthanh'),
   ('LGGV03','GV03','thiyen'),
   ('LGGV04','GV04','phucnguyen')
   
insert into LoginGVK values
   ('LGGVK01','GVK01','thuongthuong'),
   ('LGGVK02','GVK02','namphong'),
   ('LGGVK04','GVK03','anhthu'),
   ('LGGVK05','GVK04','thanhhuyen')
   