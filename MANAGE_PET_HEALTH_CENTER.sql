-- Ctrl + A --> F5 or Press "Execute"
-- Database: MANAGE_PET_HEALTH_CENTER
IF DB_ID (N'MANAGE_PET_HEALTH_CENTER') IS NOT NULL
DROP DATABASE MANAGE_PET_HEALTH_CENTER
GO
CREATE DATABASE MANAGE_PET_HEALTH_CENTER
GO
USE MANAGE_PET_HEALTH_CENTER
GO
SET DATEFORMAT dmy;
GO

CREATE TABLE EMPLOYEE
(
	EMPLOYEE_ID		char(10) Primary key,
	NAME			nvarchar(100),
	BIRTHDAY		varchar(20),
	GENDER          nvarchar(10),
	ADDRESS			nvarchar(200),
	EMAIL			varchar(50),
	PHONE_NUMBER	varchar(13),
	TITLE			nvarchar(50),
	SALARY			Bigint,
)
GO
-----------------------------------------------------------------------------------------------------------------------------

CREATE TABLE CUSTOMER
(
    CUSTOMER_ID     char(10) Primary key,
    NAME            nvarchar(100),
    BIRTHDAY		varchar(20),
    GENDER          nvarchar(10),
    ADDRESS			nvarchar(200),
    EMAIL			varchar(50),
    PHONE_NUMBER	varchar(13),
);
GO
-----------------------------------------------------------------------------------------------------------------------------

CREATE TABLE ACCOUNT
(
    EMPLOYEE_ID		char(10) Primary key,	
    USERNAME		varchar(50),
    PASSWORD		varchar(50),
	ROLE			varchar(50),
);
GO
-----------------------------------------------------------------------------------------------------------------------------

CREATE TABLE PET 
(
    PET_ID          char(10) Primary key,
	CUSTOMER_ID     char(10) NOT NULL,
    NAME            nvarchar(100),
    AGE				varchar(10),
    GENDER          nvarchar(10),
    PET_TYPE        nvarchar(20),
    BREED           nvarchar(100),
    COLOR           nvarchar(100),
    WEIGHT          float,
    DISTINCTION     nvarchar(100),	
);
GO
-----------------------------------------------------------------------------------------------------------------------------

CREATE TABLE PRODUCT
(
    PRODUCT_NO     char(10) Primary key,
    PRODUCT_TYPE   nvarchar(100),
    NAME           nvarchar(100),
    SUPPLIER       nvarchar(100),
    NATION         nvarchar(100),
    PRICE          Bigint,
);
GO
-----------------------------------------------------------------------------------------------------------------------------

CREATE TABLE ORDERS 
(
    ORDER_ID      char(10) Primary key,
	BOOKING_ID	  char(10),
    CUSTOMER_ID   char(10) NOT NULL,
	VET			  nvarchar(100),
	PET_ID	      char(10) NOT NULL,
    EMPLOYEE_ID   char(10) NOT NULL,
    ORDER_DATE    varchar(20),
    TOTAL_PRICE   Bigint,
);
GO
-----------------------------------------------------------------------------------------------------------------------------

CREATE TABLE ORDER_DETAIL 
(
    ORDER_ID            char(10) Not NULL,
    PRODUCT_NO          char(10) Not NULL,
    AMOUNT_OF_PRODUCT   int,
	TOTAL_AMOUNT		Bigint,

    CONSTRAINT PK_ORDER_DETAIL PRIMARY KEY (ORDER_ID, PRODUCT_NO)
);
GO
-----------------------------------------------------------------------------------------------------------------------------

CREATE TABLE BOOKING
(
	BOOKING_ID		char(10) Primary key,
	CUSTOMER_ID     char(10) NOT NULL,
	PET_ID			char(10) NOT NULL,
	DATE			varchar(20),
	VET_ID		    char(10),
);
GO


-------------------------------------
--Drop Table EMPLOYEE
--Drop Table CUSTOMER
--Drop Table ACCOUNT
--Drop Table PET
--Drop Table PRODUCT
--Drop Table ORDERS
--Drop Table ORDER_DETAIL
--Drop Table BOOKING
-------------------------------------


-----------------------------------------------------------------------------------------------------------------------------------------------------
--FOREIGN KEY

-- ACCOUNT
ALTER TABLE ACCOUNT ADD CONSTRAINT FK_ACCOUNT_1 FOREIGN KEY (EMPLOYEE_ID) REFERENCES EMPLOYEE (EMPLOYEE_ID);
GO
--Alter Table ACCOUNT Drop Constraint FK_ACCOUNT_1;

-- PET
ALTER TABLE PET ADD CONSTRAINT FK_PET_1 FOREIGN KEY (CUSTOMER_ID) REFERENCES CUSTOMER (CUSTOMER_ID);
GO
--Alter Table PET Drop Constraint FK_PET_1;

-- ORDERS
ALTER TABLE ORDERS ADD CONSTRAINT FK_ORDERS_1 FOREIGN KEY (BOOKING_ID) REFERENCES BOOKING (BOOKING_ID);
GO
ALTER TABLE ORDERS ADD CONSTRAINT FK_ORDERS_2 FOREIGN KEY (CUSTOMER_ID) REFERENCES CUSTOMER (CUSTOMER_ID);
GO
ALTER TABLE ORDERS ADD CONSTRAINT FK_ORDERS_3 FOREIGN KEY (PET_ID) REFERENCES PET (PET_ID);
GO
ALTER TABLE ORDERS ADD CONSTRAINT FK_ORDERS_4 FOREIGN KEY (EMPLOYEE_ID) REFERENCES EMPLOYEE (EMPLOYEE_ID);
GO
--Alter Table ORDERS Drop Constraint FK_ORDERS_1;
--Alter Table ORDERS Drop Constraint FK_ORDERS_2;
--Alter Table ORDERS Drop Constraint FK_ORDERS_3;
--Alter Table ORDERS Drop Constraint FK_ORDERS_4;

-- ORDER_DETAIL
ALTER TABLE ORDER_DETAIL ADD CONSTRAINT FK_ORDER_DETAIL_1 FOREIGN KEY (PRODUCT_NO) REFERENCES PRODUCT (PRODUCT_NO);
GO
--Alter Table ORDER_DETAIL Drop Constraint FK_ORDER_DETAIL_1;

-- BOOKING
ALTER TABLE BOOKING ADD CONSTRAINT FK_BOOKING_1 FOREIGN KEY (CUSTOMER_ID) REFERENCES CUSTOMER (CUSTOMER_ID);
GO
ALTER TABLE BOOKING ADD CONSTRAINT FK_BOOKING_2 FOREIGN KEY (PET_ID) REFERENCES PET (PET_ID);
GO
ALTER TABLE BOOKING ADD CONSTRAINT FK_BOOKING_3 FOREIGN KEY (VET_ID) REFERENCES EMPLOYEE (EMPLOYEE_ID);
GO
--Alter Table BOOKING Drop Constraint FK_BOOKING_1;
--Alter Table BOOKING Drop Constraint FK_BOOKING_2;
--Alter Table BOOKING Drop Constraint FK_BOOKING_3;
-----------------------------------------------------------------------------------------------------------------------------------------------------


--Insert dữ liệu

Insert Into EMPLOYEE (EMPLOYEE_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER, TITLE, SALARY) 
Values ('REC001', N'Chu Nam Thắng', '28/12/2000', N'Nam', N'Đồng Nai', '18521386@gm.uit.edu.vn', '0961600587', 'Receptionist', 100000000)
Insert Into EMPLOYEE (EMPLOYEE_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER, TITLE, SALARY) 
Values ('REC002', N'Nguyễn Thị Hồng Thủy', '26/6/2000', N'Nữ', N'Đồng Nai', 'thuynguyen@gmail.com', '0367530455', 'Receptionist', 40000000)
Insert Into EMPLOYEE (EMPLOYEE_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER, TITLE, SALARY)
Values ('MAN001', N'Phan Võ Hiếu Nghĩa', '11/11/1999', N'Nam', N'Bình Dương', '18521149@gm.uit.edu.vn', '0969397525', 'Manager', 50000000)
Insert Into EMPLOYEE (EMPLOYEE_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER, TITLE, SALARY)
Values ('VET001', N'Nguyễn Thị Hải Ngân', '18/1/2000', N'Nữ', N'Đồng Nai', 'haingan@gmail.com', '0123456789', 'Vet', 30000000)
Insert Into EMPLOYEE (EMPLOYEE_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER, TITLE, SALARY)
Values ('VET002', N'Phan Thị Phương Thảo', '18/6/2000', N'Nữ', N'Đồng Nai', 'thaoblue@gmail.com', '0123456789', 'Vet', 50000000)
Insert Into EMPLOYEE (EMPLOYEE_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER, TITLE, SALARY) 
Values ('VET003', N'Nguyễn Thành Hiệp', '15/3/2000', N'Nam', N'TP.Hồ Chí Minh', 'thanhhiep@gmail.com', '0564864864', 'Vet', 40000000)
Insert Into EMPLOYEE (EMPLOYEE_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER, TITLE, SALARY)
Values ('VET004', N'Lê Thị Tiểu Linh', '11/11/2000', N'Nữ', N'Đồng Nai', 'linhtay@gmail.com', '0123456789', 'Vet', 40000000)
Insert Into EMPLOYEE (EMPLOYEE_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER, TITLE, SALARY)
Values ('VET005', N'Đinh Thị Hoàng Lan', '28/12/2000', N'Nữ', N'Đồng Nai', 'landinh@gmail.com', '0123456789', 'Vet', 40000000)
Insert Into EMPLOYEE (EMPLOYEE_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER, TITLE, SALARY)
Values ('VET006', N'Trương Thị Ngọc Huyền', '5/1/2000', N'Nữ', N'Đồng Nai', 'truonghuyen@gmail.com', '0864289844', 'Vet', 40000000)
Insert Into EMPLOYEE (EMPLOYEE_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER, TITLE, SALARY)
Values ('VET007', N'Nguyễn Minh Thư', '9/8/2000', N'Nữ', N'Long An', 'thunguyen@gmail.com', '0547931555', 'Vet', 40000000)
Insert Into EMPLOYEE (EMPLOYEE_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER, TITLE, SALARY)
Values ('VET008', N'Nguyễn Thị Yến Nhi', '10/3/2000', N'Nữ', N'Đồng Nai', 'yennhi@gmail.com', '0987562524', 'Vet', 40000000)
Insert Into EMPLOYEE (EMPLOYEE_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER, TITLE, SALARY)
Values ('VET009', N'Trần Nhật Khuê', '1/4/2001', N'Nữ', N'Trà Vinh', '19521713@gm.uit.edu.vn', '0256485511', 'Vet', 40000000)
Insert Into EMPLOYEE (EMPLOYEE_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER, TITLE, SALARY)
Values ('VET010', N'Lê Nhất Minh', '25/1/1999', N'Nam', N'TP.Hồ Chí Minh', '17520751@gm.uit.edu.vn', '0937387605', 'Vet', 40000000)
Insert Into EMPLOYEE (EMPLOYEE_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER, TITLE, SALARY)
Values ('VET011', N'Vũ Hồng Đức', '9/11/2000', N'Nam', N'Đồng Nai', 'hongduc@gmail.com', '0329887729', 'Vet', 40000000)
Insert Into EMPLOYEE (EMPLOYEE_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER, TITLE, SALARY)
Values ('VET012', N'Vũ Tiến Giáp', '26/2/2000', N'Nam', N'Đồng Nai', 'giapvu@gmail.com', '0358374929', 'Vet', 40000000)
Insert Into EMPLOYEE (EMPLOYEE_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER, TITLE, SALARY)
Values ('VET013', N'Nguyễn Việt Hoàng', '18/8/2000', N'Nam', N'Đồng Nai', 'hoangnguyen@gmail.com', '0387739116', 'Vet', 40000000)
Insert Into EMPLOYEE (EMPLOYEE_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER, TITLE, SALARY)
Values ('VET014', N'Bùi Thanh Tuấn', '19/9/2000', N'Nam', N'Đồng Nai', 'tuanbui@gmail.com', '0979480322', 'Vet', 40000000)
Insert Into EMPLOYEE (EMPLOYEE_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER, TITLE, SALARY)
Values ('VET015', N'Lê Thị Khánh Linh', '9/8/2000', N'Nữ', N'Đồng Nai', 'khanhlinh@gmail.com', '0324599856', 'Vet', 40000000)

--Select * From EMPLOYEE
--Delete From EMPLOYEE
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Cquyen1', N'Đoàn Thục Quyên', '18/1/2000', N'Nữ', N'TP. Hồ Chí Minh', '18521320@gm.uit.edu.vn', '0123456789')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Cphuong1', N'Nguyễn Thị Quỳnh Phương', '21/1/2000', N'Nữ', N'Quảng Trị', '18521277@gm.uit.edu.vn', '0124817930')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Cphung1', N'Nguyễn Thị Kim Phụng', '25/8/1975', N'Nữ', N'TP.Hồ Chí Minh', 'phungntk@gm.uit.edu.vn', '0961600587')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Csy1', N'Phạm Tiến Sỹ', '9/6/2000', N'Nam', N'Đắk Lắk', '18521356@gm.uit.edu.vn', '0155116516')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Ctuan1', N'Lê Tử Tuấn', '17/2/2000', N'Nam', N'Đắk Nông', '18521598@gm.uit.edu.vn', '0341255788')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Cquyen2', N'Đỗ Thanh Quyền', '20/9/2000', N'Nam', N'TP.Bà Rịa Vũng Tàu', '18521319@gm.uit.edu.vn', '0281255662')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Ckhoa1', N'Nguyễn Minh Khoa', '26/12/2000', N'Nam', N'TP.Cần Thơ', 'erikkhoa@gmail.com', '0706817933')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Cquang1', N'Hoàng Đình Quang', '25/7/2000', N'Nam', N'Đồng Nai', 'quangwayciQ@gmail.com', '0966271105')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Ctai1', N'Nguyễn Hữu Tài', '18/5/2000', N'Nam', N'Đồng Nai', '18521361@gm.uit.edu.vn', '0987451355')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Cnhut1', N'Chung Quang Nhựt', '13/4/2000', N'Nam', N'Long An', '18521220@gm.uit.edu.vn', '0898424538')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Cthang1', N'Hồ Hữu Thắng', '24/12/2000', N'Nam', N'Đồng Nai', '18521390@gm.uit.edu.vn', '0354545988')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Cthi1', N'Khổng Phạm Minh Thi', '21/3/2000', N'Nam', N'Đồng Nai', '18521424@gm.uit.edu.vn', '0358966987')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Cnghia1', N'Nguyễn Hữu Nghĩa', '12/5/2000', N'Nam', N'Đồng Nai', '18521145@gm.uit.edu.vn', '0364561218')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Cnam1', N'Dương Bảo Nam', '22/11/2000', N'Nam', N'TP.Hồ Chí Minh', '18521118@gm.uit.edu.vn', '0396485177')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Ctu1', N'Hà Minh Tú', '11/6/2000', N'Nam', N'TP.Hồ Chí Minh', '18521579@gm.uit.edu.vn', '0316548565')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Cthinh1', N'Bành Phúc Thịnh', '13/10/2000', N'Nam', N'Nha Trang', '18521435@gm.uit.edu.vn', '0968156618')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Cnhuy1', N'Trần Thị Như Ý', '12/9/2000', N'Nữ', N'TP.Hồ Chí Minh', '18521688@gm.uit.edu.vn', '0979651265')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Cthu1', N'Trương Ngọc Anh Thư', '23/7/2000', N'Nữ', N'TP.Hồ Chí Minh', '18521466@gm.uit.edu.vn', '0864113544')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Ctien1', N'Hoàng Thủy Tiên', '30/10/2000', N'Nữ', N'Đồng Nai', '18521483@gm.uit.edu.vn', '0231154448')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Ctram1', N'Huỳnh Thị Kim Trâm', '22/12/2000', N'Nữ', N'Đồng Nai', '18521519@gm.uit.edu.vn', '0384856239')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Cthuy1', N'Phan Thu Thủy', '23/1/2000', N'Nữ', N'TP.Hồ Chí Minh', '18521478@gm.uit.edu.vn', '0989454655')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Ctrung1', N'Đặng Võ Bảo Trung', '3/6/2000', N'Nam', N'TP.Hồ Chí Minh', '18521546@gm.uit.edu.vn', '0973211861')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Ctran1', N'Trần Tú Trân', '5/8/2000', N'Nữ', N'Long An', '18521521@gm.uit.edu.vn', '0354861686')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Chiep1', N'Dương Vũ Hoàng Hiệp', '10/9/2000', N'Nam', N'Đắk Lắk', '18520727@gm.uit.edu.vn', '0363874985')
Insert Into CUSTOMER (CUSTOMER_ID, NAME, BIRTHDAY, GENDER, ADDRESS, EMAIL, PHONE_NUMBER)
Values ('Ctrang1', N'Hình Thanh Thiên Trang', '26/10/2000', N'Nữ', N'Đồng Tháp', '18521523@gm.uit.edu.vn', '0314952555')

--Select * From CUSTOMER
--Delete From CUSTOMER
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Insert Into ACCOUNT (EMPLOYEE_ID, USERNAME, PASSWORD, ROLE) 
Values ('REC001', 'Thang_UIT', 't', 'Receptionist')	    
Insert Into ACCOUNT (EMPLOYEE_ID, USERNAME, PASSWORD, ROLE) 
Values ('REC002', 'hongthuy', 't', 'Receptionist')
Insert Into ACCOUNT (EMPLOYEE_ID, USERNAME, PASSWORD, ROLE) 
Values ('MAN001', 'Nghia_UIT', 'n', 'Manager')		  

--Select * From ACCOUNT
--Delete From ACCOUNT
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('CAT001', 'Ckhoa1', N'Nui', '2', N'Cái', N'Mèo', N'Mèo Ba tư', N'Trắng', 2.2, N'Thân đầy đặn, lông dày')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('CAT002', 'Ckhoa1', N'Chó', '1', N'Cái', N'Mèo', N'Mèo mướp', N'Xám đen', 1.8, N'Đuôi dài, thân gầy')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('CAT003', 'Cnam1', N'Meo', '2', N'Cái', N'Mèo', N'Mèo Nga', N'Xám đen', 2.4, N'Thân đầy đặn, lông dày, xám đen')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('CAT004', 'Cphung1', N'mew', '1', N'Cái', N'Mèo', N'Mèo mướp', N'Xám đen', 2.4, N'Thân đầy đặn, lông dày, xám đen')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('CAT005', 'Cnhut1', N'Min', '2', N'Đực', N'Mèo', N'Mèo tai cụp', N'Trắng xám', 1.2, N'Thân nhỏ, tai cụp, mắt to, chân ngắn')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('CAT006', 'Cnhuy1', N'Mun', '2', N'Cái', N'Mèo', N'Mèo lông ngắn Anh', N'Xám xanh dương', 2, N'Thân to, xám, mắt tròn to, chân dài')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('CAT007', 'Cphuong1', N'Bống', '3', N'Cái', N'Mèo', N'Mèo Mỹ lông ngắn', N'Trắng xanh dương', 2.3, N'Thân đầy đặn, lông ngắn, tai to')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('CAT008', 'Cquyen1', N'Bin', '2', N'Cái', N'Mèo', N'Mèo Munchkin', N'Xám trắng', 1.4, N'Nhỏ, chân ngắn, mắt to')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('CAT009', 'Cthang1', N'win', '2', N'Đực', N'Mèo', N'Mèo Somali', N'Vàng cam', 2, N'Thân dài, to, lông dày')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('CAT010', 'Cthu1', N'Mèo', '1', N'Cái', N'Mèo', N'Mèo tai cụp', N'Trắng', 2, N'Người nhỏ, chân ngắn, tai cụp')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('CAT011', 'Cthuy1', N'Mèo', '1', N'Cái', N'Mèo', N'Mèo Mỹ', N'Đen xám', 2.5, N'Người dài to, lông dày')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('CAT012', 'Ctien1', N'Mèo', '2', N'Đực', N'Mèo', N'Mèo Nebelung', N'Xám', 2.1, N'Người dài to, mắt ngươi vàng, chân dài')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('CAT013', 'Ctram1', N'Mèo', '1', N'Đực', N'Mèo', N'Mèo Korat', N'Xám đen', 1.8, N'Người dài to, mắt ngươi đen, chân dài')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('CAT014', 'Ctran1', N'Mèo', '2', N'Cái', N'Mèo', N'Mèo tất trắng', N'Trắng đen', 2.2, N'Mặt đen, thân trắng, người dài, gầy')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('CAT015', 'Ctrang1', N'Mèo', '1', N'Cái', N'Mèo', N'Mèo lông dài Anh', N'Trắng sữa', 2.3, N'Mặt đen, thân trắng, người dài, phần đầu lông dày')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('DOG001', 'Chiep1', N'Ben', '2', N'Đực', N'Chó', N'Becgie', N'Đen nâu', 13, N'To, đuôi dài, đen nâu')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('DOG002', 'Cnghia1', N'Nick', '2', N'Đực', N'Chó', N'Husky', N'Trắng đen', 10, N'Thân dài, to, nhiều lông')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('DOG003', 'Cquang1', N'Bin', '2', N'Đực', N'Chó', N'Shiba', N'Vàng', 8, N'Thân nhỏ, lông vàng tươi, mặt sắc, tai vểnh')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('DOG004', 'Cquyen2', N'Cậu vàng', '2', N'Cái', N'Chó', N'Shiba', N'Vàng tươi', 9.5, N'To, béo nhìn như cậu vàng')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('DOG005', 'Ctai1', N'Tài smile', '3', N'Đực', N'Chó', N'Alaska', N'Trắng xám', 15, N'Thân dài to, lông dày, trắng xám')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('DOG006', 'Cthi1', N'Cun', '2', N'Đực', N'Chó', N'Corgi', N'Vàng', 12, N'Thân dài, to, mông rất to, vàng ươm, lông dày')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('DOG007', 'Cthinh1', N'Chó', '2', N'Đực', N'Chó', N'Corgi', N'Vàng', 16, N'Thân dài, to, mông rất to, vàng ươm, lông dày')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('DOG008', 'Ctrung1', N'Hổ', '2', N'Đực', N'Chó', N'Bull', N'Đen', 10, N'Thân to, mặt nguy hiểm, răng nhô ra ngoài, chân ngắn')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('DOG009', 'Ctu1', N'Tú', '2', N'Đực', N'Chó', N'Chihuahua', N'Vàng nâu', 8, N'Thân dài, chân rất ngắn, mặt tam giác')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('DOG010', 'Ctuan1', N'Null', '2', N'Đực', N'Chó', N'Shiba inu', N'Vàng', 10, N'Vàng như cậu vàng')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('DOG011', 'Ckhoa1', N'Lucy', '2', N'Đực', N'Chó', N'Husky', N'Trắng', 7.5, N'Thân đầy đặn, lông dày')
Insert Into PET (PET_ID, CUSTOMER_ID, NAME, AGE, GENDER, PET_TYPE, BREED, COLOR, WEIGHT, DISTINCTION) 
Values ('MOU001', 'Csy1', N'Chít', '3', N'Đực', N'Chuột', N'Hamster', N'Vàng trắng', 1, N'Vàng, thân to, béo')

--Select * From PET
--Delete From PET
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Insert Into PRODUCT (PRODUCT_NO, PRODUCT_TYPE, NAME, SUPPLIER, NATION, PRICE)
Values ('SER_TL', N'Service', N'Tỉa lông', 'Không', 'Không', 400000);
Insert Into PRODUCT (PRODUCT_NO, PRODUCT_TYPE, NAME, SUPPLIER, NATION, PRICE)
Values ('SER_TR', N'Service', N'Tắm rửa', 'Không', 'Không', 250000);
Insert Into PRODUCT (PRODUCT_NO, PRODUCT_TYPE, NAME, SUPPLIER, NATION, PRICE)
Values ('SER_XN', N'Service', N'Xét nghiệm', 'Không', 'Không', 600000);
Insert Into PRODUCT (PRODUCT_NO, PRODUCT_TYPE, NAME, SUPPLIER, NATION, PRICE)
Values ('SER_TG', N'Service', N'Tẩy giun', 'Không', 'Không', 800000);
Insert Into PRODUCT (PRODUCT_NO, PRODUCT_TYPE, NAME, SUPPLIER, NATION, PRICE)
Values ('SER_KLS', N'Service', N'Khám lâm sàng', 'Không', 'Không', 600000);
Insert Into PRODUCT (PRODUCT_NO, PRODUCT_TYPE, NAME, SUPPLIER, NATION, PRICE)
Values ('SER_CXQ', N'Service', N'Chụp X-quang', 'Không', 'Không', 300000);
Insert Into PRODUCT (PRODUCT_NO, PRODUCT_TYPE, NAME, SUPPLIER, NATION, PRICE)
Values ('SER_NS', N'Service', N'Nội soi', 'Không', 'Không', 350000);
Insert Into PRODUCT (PRODUCT_NO, PRODUCT_TYPE, NAME, SUPPLIER, NATION, PRICE)
Values ('SER_SA', N'Service', N'Siêu âm', 'Không', 'Không', 450000);
Insert Into PRODUCT (PRODUCT_NO, PRODUCT_TYPE, NAME, SUPPLIER, NATION, PRICE)
Values ('SER_BB', N'Service', N'Bó bột', 'Không', 'Không', 150000);
Insert Into PRODUCT (PRODUCT_NO, PRODUCT_TYPE, NAME, SUPPLIER, NATION, PRICE)
Values ('PRO_TTG', N'Product', N'Thuốc tẩy giun', N'Công ty UIT', N'Nhật Bản', 50000);
Insert Into PRODUCT (PRODUCT_NO, PRODUCT_TYPE, NAME, SUPPLIER, NATION, PRICE)
Values ('PRO_TKST', N'Product', N'Thuốc điều trị kí sinh trùng', N'Công ty UIT', N'Việt Nam', 250000);
Insert Into PRODUCT (PRODUCT_NO, PRODUCT_TYPE, NAME, SUPPLIER, NATION, PRICE)
Values ('PRO_TVR', N'Product', N'Thuốc trị ve, rận', N'Công ty UIT', N'Việt Nam', 170000);
Insert Into PRODUCT (PRODUCT_NO, PRODUCT_TYPE, NAME, SUPPLIER, NATION, PRICE)
Values ('PRO_VCC', N'Product', N'Vaccine phòng dại cho chó', N'Công ty UIT', N'Việt Nam', 150000);
Insert Into PRODUCT (PRODUCT_NO, PRODUCT_TYPE, NAME, SUPPLIER, NATION, PRICE)
Values ('PRO_TKM', N'Product', N'Thuốc khử mùi', N'Công ty UIT', N'Việt Nam', 160000);
Insert Into PRODUCT (PRODUCT_NO, PRODUCT_TYPE, NAME, SUPPLIER, NATION, PRICE)
Values ('PRO_VCM', N'Product', N'Vaccine phòng dại cho mèo', N'Công ty UIT', N'Việt Nam', 150000);
Insert Into PRODUCT (PRODUCT_NO, PRODUCT_TYPE, NAME, SUPPLIER, NATION, PRICE)
Values ('PRO_TACC', N'Product', N'Thức ăn cho chó', N'Công ty UIT', N'Việt Nam', 200000);
Insert Into PRODUCT (PRODUCT_NO, PRODUCT_TYPE, NAME, SUPPLIER, NATION, PRICE)
Values ('PRO_TACM', N'Product', N'Thức ăn cho mèo', N'Công ty UIT', N'Việt Nam', 150000);

--Select * From PRODUCT
--Delete From PRODUCT
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Insert Into BOOKING (BOOKING_ID, CUSTOMER_ID, PET_ID, DATE, VET_ID)
Values ('BOO0000001', 'Ckhoa1', 'CAT001', '24/07/2020 9:30:50', 'VET001');
Insert Into BOOKING (BOOKING_ID, CUSTOMER_ID, PET_ID, DATE, VET_ID)
Values ('BOO0000002', 'Ckhoa1', 'CAT002', '27/07/2020 8:30:30', 'VET001');
Insert Into BOOKING (BOOKING_ID, CUSTOMER_ID, PET_ID, DATE, VET_ID)
Values ('BOO0000003', 'Cnam1', 'CAT003', '25/07/2020 8:00:23', 'VET013');
Insert Into BOOKING (BOOKING_ID, CUSTOMER_ID, PET_ID, DATE, VET_ID)
Values ('BOO0000004', 'Cnghia1', 'DOG002', '28/07/2020 14:00:00', 'VET003');
Insert Into BOOKING (BOOKING_ID, CUSTOMER_ID, PET_ID, DATE, VET_ID)
Values ('BOO0000005', 'Cnhut1', 'CAT005', '25/07/2020 9:00:00', 'VET001');
Insert Into BOOKING (BOOKING_ID, CUSTOMER_ID, PET_ID, DATE, VET_ID)
Values ('BOO0000006', 'Cquang1', 'DOG003', '30/07/2020 9:15:00', 'VET004');
Insert Into BOOKING (BOOKING_ID, CUSTOMER_ID, PET_ID, DATE, VET_ID)
Values ('BOO0000007', 'Cquyen1', 'CAT008', '24/07/2020 7:45:00', 'VET005');
Insert Into BOOKING (BOOKING_ID, CUSTOMER_ID, PET_ID, DATE, VET_ID)
Values ('BOO0000008', 'Cquyen2', 'DOG004', '29/07/2020 8:45:00', 'VET011');
Insert Into BOOKING (BOOKING_ID, CUSTOMER_ID, PET_ID, DATE, VET_ID)
Values ('BOO0000009', 'Csy1', 'MOU001', '31/07/2020 14:30:00', 'VET007');
Insert Into BOOKING (BOOKING_ID, CUSTOMER_ID, PET_ID, DATE, VET_ID)
Values ('BOO0000010', 'Ctai1', 'DOG005', '27/07/2020 13:30:00', 'VET008');

--Select * From BOOKING
--Delete From BOOKING
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00001', 'PRO_TTG ', 1, 50000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00001', 'SER_TG', 1, 800000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00001', 'SER_TL', 1, 400000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00001', 'SER_TR', 1, 250000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00001', 'SER_XN', 1, 600000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00002', 'PRO_TTG', 4, 200000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00002', 'SER_SA', 1, 450000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00002', 'SER_TL', 1, 400000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00002', 'SER_TR', 1, 250000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00003', 'PRO_TACM', 2, 300000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00003', 'SER_BB', 1, 150000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00003', 'SER_NS', 1, 350000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00003', 'SER_TG', 1, 800000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00003', 'SER_XN', 1, 600000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00004', 'PRO_TACC', 4, 800000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00004', 'SER_TG', 1, 800000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00004', 'SER_TL', 1, 400000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00004', 'SER_TR', 1, 250000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00004', 'SER_XN', 1, 600000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00005', 'PRO_TACM', 4, 600000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00005', 'PRO_TKM', 2, 320000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00005', 'PRO_TTG', 4, 200000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00005', 'PRO_VCM', 1, 150000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00005', 'SER_KLS', 1, 600000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00005', 'SER_TG', 1, 800000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00005', 'SER_TL', 1, 400000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00005', 'SER_TR', 1, 250000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00006', 'PRO_TACC', 2, 400000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00006', 'PRO_TVR', 2, 340000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00006', 'SER_KLS', 1, 600000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00006', 'SER_TG', 1, 800000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00006', 'SER_TR', 1, 250000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00007', 'PRO_TACM', 2, 300000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00007', 'SER_KLS', 1, 600000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00007', 'SER_TG', 1, 800000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00007', 'SER_TL', 1, 400000);
Insert Into ORDER_DETAIL (ORDER_ID, PRODUCT_NO, AMOUNT_OF_PRODUCT, TOTAL_AMOUNT)
Values ('ORDER00007', 'SER_TR', 1, 250000);

--Select * From ORDER_DETAIL
--Delete From ORDER_DETAIL
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Insert Into ORDERS (ORDER_ID, BOOKING_ID, CUSTOMER_ID, VET, PET_ID, EMPLOYEE_ID, ORDER_DATE, TOTAL_PRICE)
Values ('ORDER00001', 'BOO0000001', 'Ckhoa1', N'Nguyễn Thị Hải Ngân', 'CAT001', 'REC001', '24/07/2020 10:30:50', 2100000);
Insert Into ORDERS (ORDER_ID, BOOKING_ID, CUSTOMER_ID, VET, PET_ID, EMPLOYEE_ID, ORDER_DATE, TOTAL_PRICE)
Values ('ORDER00002', 'BOO0000002', 'Ckhoa1', N'Nguyễn Thị Hải Ngân', 'CAT002', 'REC001', '27/07/2020 8:30:30', 1300000);
Insert Into ORDERS (ORDER_ID, BOOKING_ID, CUSTOMER_ID, VET, PET_ID, EMPLOYEE_ID, ORDER_DATE, TOTAL_PRICE)
Values ('ORDER00003', 'BOO0000003', 'Cnam1', N'Nguyễn Việt Hoàng', 'CAT003', 'REC001', '25/07/2020 8:30:23', 2200000);
Insert Into ORDERS (ORDER_ID, BOOKING_ID, CUSTOMER_ID, VET, PET_ID, EMPLOYEE_ID, ORDER_DATE, TOTAL_PRICE)
Values ('ORDER00004', 'BOO0000004', 'Cnghia1', N'Nguyễn Thành Hiệp', 'DOG002', 'REC001', '28/07/2020 16:00:28', 2850000);
Insert Into ORDERS (ORDER_ID, BOOKING_ID, CUSTOMER_ID, VET, PET_ID, EMPLOYEE_ID, ORDER_DATE, TOTAL_PRICE)
Values ('ORDER00005', 'BOO0000005', 'Cnhut1', N'Nguyễn Thị Hải Ngân', 'CAT005', 'REC001', '25/07/2020 11:30:26', 3320000);
Insert Into ORDERS (ORDER_ID, BOOKING_ID, CUSTOMER_ID, VET, PET_ID, EMPLOYEE_ID, ORDER_DATE, TOTAL_PRICE)
Values ('ORDER00006', 'BOO0000006', 'Cquang1', N'Lê Thị Tiểu Linh', 'DOG003', 'REC001', '30/07/2020 10:30:00', 2390000);
Insert Into ORDERS (ORDER_ID, BOOKING_ID, CUSTOMER_ID, VET, PET_ID, EMPLOYEE_ID, ORDER_DATE, TOTAL_PRICE)
Values ('ORDER00007', 'BOO0000007', 'Cquyen1', N'Đinh Thị Hoàng Lan', 'CAT008', 'REC001', '24/07/2020 9:45:50', 2350000);

--Select * From ORDERS
--Delete From ORDERS
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

