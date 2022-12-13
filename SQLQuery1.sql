CREATE DATABASE SUPPLEMENT_STORE

CREATE TABLE ACCOUNTANT(
	AccID varchar(30) PRIMARY KEY,
	Accname varchar(50),
	phone varchar(30),
	pass varchar(30)
);

CREATE TABLE PRODUCT(
	ProID varchar(30) PRIMARY KEY,
	ProName varchar(50),
	unit varchar(30),
	price float,
	quantity int
);

CREATE TABLE AGENCY(
	AgenID varchar(30) PRIMARY KEY,
	AgenName varchar(50),
	phone varchar(13)
);

CREATE TABLE SUPPLIER(
	SuppID varchar(30) PRIMARY KEY,
	SName varchar(50),
	phone varchar(13)
);

CREATE TABLE BILL(
	Bill_ID varchar(30) PRIMARY KEY,
	SuppID varchar(30) FOREIGN KEY REFERENCES SUPPLIER(SuppID),
	AgenID varchar(30) FOREIGN KEY REFERENCES AGENCY(AgenID),
	AccID varchar(30) FOREIGN KEY REFERENCES ACCOUNTANT(AccID),
	billType varchar(30),
	Bdate date,
	total float
);

CREATE TABLE BILL_DETAIL(
	ID_detail varchar(30) PRIMARY KEY,
	Bill_ID varchar(30) FOREIGN KEY REFERENCES BILL(Bill_ID),
	ProID varchar(30) FOREIGN KEY REFERENCES PRODUCT(ProID),
	quantity int,
	price float
);

INSERT INTO ACCOUNTANT(AccID, Accname, phone, pass)
VALUES ('ACC01', 'Alice', '0928421412', 'hello123'),
('ACC02', 'Dylis', '0122445482', 'mango'),
('ACC03', 'Ken', '0384348354', 'momo');
	

INSERT INTO AGENCY(AgenID, AgenName, phone)
VALUES ('AG01', 'Agen 1', '034834736'),
('AG02', 'Agen 2', '0421345534'),
('AG03', 'Agen 3', '0745285345');

INSERT INTO PRODUCT(ProID, ProName, unit, price, quantity)
VALUES('P01', 'VitaminC', 'pack', 18000, 200),
('P02', 'Protein', 'bottle', 90000, 500),
('P03', 'DHA', 'bottle', 120000, 130);

INSERT INTO SUPPLIER(SuppID, SName, phone)
VALUES ('S01', 'ST Com', '045234546'),
('S02', 'HA DEL', '045348532'),
('S03', 'OOP GEE', '0534573453');

INSERT INTO BILL(Bill_ID, SuppID, AgenID, AccID, billType, Bdate, total)
VALUES 
(dbo.fn_autoIDBill('I'), 'S02', null, 'ACC01', 'import', GETDATE(), 36000),
(dbo.fn_autoIDBill('E'), null, 'AG02', 'ACC03', 'export', GETDATE(), 48000),
(dbo.fn_autoIDBill('I'), 'S02', null, 'ACC02', 'import', GETDATE(), 450000);

Select * from BILL 
delete from BILL

INSERT INTO BILL_DETAIL(ID_detail, Bill_ID, ProID, quantity, price)
VALUES (dbo.fn_autoIDBillDetail('E13122022001'), 'E13122022001', 'P01', 2, 18000),
(dbo.fn_autoIDBillDetail('I13122022001'), 'I13122022001', 'P03', 4, 120000),
(dbo.fn_autoIDBillDetail('E13122022001'), 'E13122022001', 'P02', 5, 90000);

SELECT * FROM BILL_DETAIL
delete from BILL_DETAIL

-----------------------------------------------------------------------
create function fn_autoIDBill(@formType varchar(10))
returns varchar(MAX)
as
begin
	declare @today date = getDate();
	declare @day varchar(3); set @day = day(@today);
	declare @month varchar(3); set @month = month(@today);
	declare @date varchar(MAX);
	set @date = CONCAT(@day,@month,year(@today));

	declare @ID varchar(MAX);
	set @ID = CONCAT(@formType,@date,'001')
	if(@ID in (select Bill_ID from BILL))
	begin
		declare @findID varchar(MAX);
		set @findID = LEFT(@ID, LEN(@ID)-3)
		set @ID = (select max(Bill_ID) from BILL where Bill_ID Like concat(@findID,'%'));
		declare @num int;
		set @num = convert(float,substring(@ID,LEN(@ID)-2,3));
		set @num = @num + 1;
		set @ID = CONCAT(substring(@ID,1,LEN(@ID)-convert(int, LOG10(@num)+1)), @num);
		set @ID = RIGHT(@ID, LEN(@ID) - 1)
		set @ID = CONCAT(@formType,@ID);
	end
	return @ID
end
go

-----------------------------------------------------------------------
create function fn_autoIDBillDetail(@BID varchar(30))
returns varchar(MAX)
as
begin
	declare @today date = getDate();
	declare @day varchar(3); set @day = day(@today);
	declare @month varchar(3); set @month = month(@today);
	declare @date varchar(MAX);
	set @date = CONCAT(@day,@month,year(@today));

	declare @ID varchar(MAX);
	set @BID = LEFT(@BID, 1)
	set @ID = CONCAT('BD',@BID,@date,'001')
	if(@ID in (select ID_detail from BILL_DETAIL))
	begin
		declare @findID varchar(MAX);
		set @findID = LEFT(@ID, LEN(@ID)-3)
		set @ID = (select max(ID_detail) from BILL_DETAIL where ID_detail Like concat(@findID,'%'));
		declare @num int;
		set @num = convert(float,substring(@ID,LEN(@ID)-2,3));
		set @num = @num + 1;
		set @ID = CONCAT(substring(@ID,1,LEN(@ID)-convert(int, LOG10(@num)+1)), @num);
		set @ID = RIGHT(@ID, LEN(@ID) - 3)
		set @ID = CONCAT('BD',@BID,@ID);
	end
	return @ID
end
go

----------------------------------------------------------------
