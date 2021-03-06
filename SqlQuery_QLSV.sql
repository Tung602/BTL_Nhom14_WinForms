create table KHOA 
(
	maKhoa varchar(50) not null primary key,
	tenKhoa nvarchar(50) not null,
);
create table MONHOC 
(
	maMonHoc varchar(50) not null primary key,
	tenMonHoc nvarchar(50) not null,
);
create table LOP
(
	tenLop varchar(50) not null primary key,
	maKhoa varchar(50) not null foreign key references KHOA(maKhoa),
);
create table THUOC
(
	maKhoa varchar(50) not null foreign key references KHOA(maKhoa),
	maMonHoc varchar(50) not null foreign key references MONHOC(maMonHoc)
);
Create table SV
(
	maSV varchar(50) not null primary key,
	tenSV nvarchar(50) not null,
	gioiTinh nvarchar(20) not null,
	ngaySinh date not null,
	queQuan nvarchar(50) not null,
	tenLop varchar(50) not null foreign key references LOP(tenLop)
);
create table DIEM 
(
	diem float,
	maSV varchar(50) foreign key references SV(maSV),
	maMonHoc varchar(50) foreign key references MONHOC(maMonHoc),
);
create table ACCOUNT
(
	userName varchar(50) not null primary key,
	passWord varchar(50) not null,
);
-- insert admin account
insert into ACCOUNT values('admin', '1234');

-- insert điểm
insert into DIEM values('8.2', '001', 'SSE111');
insert into DIEM values('9', '004', 'SSE111');
insert into DIEM values('7.5', '005', 'SSE111');
insert into DIEM values('10', '001', 'CSE281');
-- Select sinh viên
SELECT 
SV.maSV as 'Mã SV', 
SV.tenSV as 'Họ tên', 
SV.NgaySinh as 'Ngày sinh',
SV.gioiTinh as 'Giới tính', 
SV.queQuan as 'Quê quán', 
LOP.tenLop as 'Lớp', 
KHOA.tenKhoa as 'Khoa' 
FROM  KHOA 
INNER JOIN LOP ON KHOA.maKhoa = LOP.maKhoa 
INNER JOIN SV ON LOP.tenLop = SV.tenLop;
-- Insert Khoa
insert into KHOA values('CNTT', N'Công nghệ thông tin');
insert into KHOA values('KTO', N'Kĩ thuật cơ khí');
insert into KHOA values('KT', N'Kế toán');
insert into KHOA values('K', N'Kinh tế');
insert into KHOA values('QLXD', N'Quản lý xây dựng');

-- Insert Lop
insert into LOP values('62TH3', 'CNTT');
insert into LOP values('62TH2', 'CNTT');
insert into LOP values('57K-QT', 'K');
insert into LOP values('58K-PT2', 'K');
insert into LOP values('57KT-DN3', 'KT');
insert into LOP values('57KT-XD', 'KT');
insert into LOP values('58M-XD1', 'KTO');
insert into LOP values('58M-XD2', 'KTO');
insert into LOP values('54QLXD2', 'QLXD');
insert into LOP values('57QLXD1', 'QLXD');
-- Insert SV
insert into SV values('001', N'Đỗ Thanh Tùng', N'Nam', '01/02/2001', N'Ninh Bình', '62TH3');
insert into SV values('002', N'Lê Quang Thành', N'Nam', '07/03/2001', N'Hà Tĩnh', '62TH3');
insert into SV values('003', N'Nguyễn Đức Thiện', N'Nam', '08/06/2001', N'Hà Nội', '62TH3');
insert into SV values('004', N'Trần Đức Hải', N'Nam', '12/08/2001', N'Ninh Bình', '57KT-XD');
insert into SV values('005', N'Lê Thị Hoa', N'Nữ', '06/28/2001', N'Ninh Bình', '58K-PT2');
insert into SV values('006', N'Đỗ Thanh Tùng', N'Nam', '9/11/2002', N'Bắc Ninh', '62TH2');
insert into SV values('008', N'Lê Quang Thành', N'Nữ', '06/28/2001', N'Bình Định', '62TH3');
insert into SV values('007', N'Lê Thị Mai', N'Nữ', '01/02/2001', N'Ninh Bình', '57KT-DN3');
insert into SV values('009', N'Đỗ Thanh Tùng', N'Nam', '01/02/2001', N'Thái Bình', '62TH2');
-- Insert môn học
insert into MONHOC values('CSE281', N'Cấu trúc dữ liệu và giải thuật');
insert into MONHOC values('CSE484', N'Cơ sở dữ liệu');
insert into MONHOC values('CSE481', N'Công nghệ phần mềm');
insert into MONHOC values('CSE370', N'Kiến trúc máy tính');
insert into MONHOC values('CSE205', N'Lập trình nâng cao');
insert into MONHOC values('CSE204', N'Lập trình Python');
insert into MONHOC values('GDQP321', N'	Công tác quốc phòng và an ninh');
insert into MONHOC values('GDQP311', N'Đường lối quốc phòng và an ninh');
insert into MONHOC values('MATH111', N'Giải tích hàm một biến');
insert into MONHOC values('MATH254', N'Xác suất thống kê');
insert into MONHOC values('SSE111', N'Kỹ năng mềm và tinh thần khởi nghiệp');
insert into MONHOC values('MLP121', N'Triết học Mác - Lênin	');
insert into MONHOC values('ENG213', N'Tiếng Anh 1');

-- Insert môn học thuộc khoa
insert into THUOC values('CNTT','CSE281');
insert into THUOC values('CNTT','CSE481');
insert into THUOC values('CNTT','CSE484');
insert into THUOC values('CNTT','CSE370');
insert into THUOC values('CNTT','CSE205');
insert into THUOC values('CNTT','CSE204');
insert into THUOC values('CNTT','SSE111');
insert into THUOC values('CNTT','ENG213');

insert into THUOC values('KTO','GDQP321');
insert into THUOC values('KTO','GDQP311');
insert into THUOC values('KTO','MATH111');
insert into THUOC values('KTO','MATH254');
insert into THUOC values('KTO','ENG213');

insert into THUOC values('KT','ENG213');
insert into THUOC values('KT','MLP121');
insert into THUOC values('KT','SSE111');
insert into THUOC values('KT','MATH254');
insert into THUOC values('KT','MATH111');
insert into THUOC values('KT','GDQP311');
insert into THUOC values('KT','GDQP321');

insert into THUOC values('K','ENG213');
insert into THUOC values('K','MLP121');
insert into THUOC values('K','SSE111');
insert into THUOC values('K','MATH254');
insert into THUOC values('K','MATH111');
insert into THUOC values('K','GDQP311');
insert into THUOC values('K','GDQP321');

insert into THUOC values('QLXD','ENG213');
insert into THUOC values('QLXD','MLP121');
insert into THUOC values('QLXD','SSE111');
insert into THUOC values('QLXD','MATH254');
insert into THUOC values('QLXD','MATH111');
insert into THUOC values('QLXD','GDQP311');
insert into THUOC values('QLXD','GDQP321');

-- Select điểm
select SV.maSV as N'Mã SV', MONHOC.maMonHoc as N'Mã môn học', MONHOC.tenMonHoc as N'Tên môn học', DIEM.diem as N'Điểm', KHOA.tenKhoa as N'Khoa' 
from DIEM inner join SV on DIEM.maSV = SV.maSV inner join MONHOC on DIEM.maMonHoc = MONHOC.maMonHoc inner join THUOC on MONHOC.maMonHoc = THUOC.maMonHoc inner join KHOA on KHOA.maKhoa = THUOC.maKhoa inner join LOP on SV.tenLop = LOP.tenLop and Lop.maKhoa = Khoa.maKhoa;
