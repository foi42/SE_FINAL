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
VALUES ('B01', 'S02', 'AG01', 'ACC01', 'import', GETDATE(), 36000),
('B02', 'S01', 'AG02', 'ACC03', 'export', GETDATE(), 48000),
('B03', 'S02', 'AG02', 'ACC02', 'import', GETDATE(), 450000);


INSERT INTO BILL_DETAIL(ID_detail, Bill_ID, ProID, quantity, price)
VALUES ('BD01', 'B02', 'P01', 2, 18000),
('BD02', 'B01', 'P03', 4, 120000),
('BD03', 'B02', 'P02', 5, 90000);

