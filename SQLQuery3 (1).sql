
create database DBProject1
GO
use DBProject1

create table OwnerOfGarage(OwnerId int not null,
				   TotalProfit Decimal(7,2),
				    password Varchar(20), 
					Email varchar(50) unique, 
					primary key(OwnerId))

Create table Car(CarID Varchar(20) not null, 
				 Type Varchar(20),
				 Color varchar(30),
				 needWash int,
				 needRepair int,
				 primary key (CarID));

Create table Garage(G_ID int not null, 
				 TotalProfit Decimal(7,2),
				 WorkersNum int not null,
				 Address varchar(40) not null,
				 City varchar(20) not null,
				 NumOfSlots int not null,
				 RatingValue int ,
				 SoltCostPerHour Decimal(7,2) not null,
				 NumOfFreeSlots int,
				 OwnerId int not null,
				 primary key (G_ID) ,
				 Foreign Key (OwnerId) References OwnerOfGarage)

Create table Worker(W_ID int not null, 
				 Name Varchar(20) not null,
				 Salary Decimal(7,2) not null,
				 TimeShift Time not null,
				 Password VarChar(40) not null,
				 Address Varchar(40) not null,
				 G_ID int not null,
				 Email varchar(50) unique,
				 primary key (W_ID), 
				 Foreign Key(G_ID) References Garage);



Create table Slots(Slot_ID int not null,
G_ID int not null,
Foreign Key (G_ID) References Garage,
State int not null DEFAULT 0,
StartUse Time ,
EndUse Time, 
Primary Key(G_ID, Slot_ID) )

Create table Customer(UserName VarChar(40) not null, 
				 Email Varchar(20) not null unique,
				 PassWord VarChar(40) not null,
				 AllTimesHeWasIn int DEFAULT 0,
				 BirthDate DateTime ,
				 Address Varchar(40) not null,
				 Slot_ID int,
				 G_ID int,
				 primary key (UserName),
				 Foreign Key (G_ID,Slot_ID )References Slots, 
				 Cost Decimal (7,2),
				 Duration Decimal(7,2),
				 Active_PromoCode int);

Create table OrderOfWorkShop(G_ID int not null,
Order_ID int not null,
Cost Decimal(7,2) ,
FixedOrNot int not null DEFAULT 0,
DesBefore VarChar(200) not null,
DesAfter VarChar(200) not null,
Car_ID Varchar(20) not null,
Foreign Key(Car_ID) References Car)

Create table OrderOfWash(G_ID int not null,
Order_ID int not null,
Cost Decimal(7,2),
DoneOrNot int not null DEFAULT 0,
Car_ID Varchar(20) not null,
Foreign Key(Car_ID) References Car)

Create table Archive(Archive_ID int not null, 
				 Cost Decimal(7,2) not null,
				 DesBefore VarChar(200) not null,
				 DesAfter VarChar(200) not null,
				 primary key (Archive_ID));

Create table Dependent(CustomerUserName VarChar(40) not null,
Name VarChar(40) not null,
Foreign Key (CustomerUserName) References Customer,
Primary Key (CustomerUserName,Name))



Create table Rate(G_ID int not null,
CustomerUserName Varchar(40) not null,
RatingValue int not null,
Foreign Key (G_ID) References Garage,
Foreign Key (CustomerUserName) References Customer,
Primary Key(G_ID,CustomerUserName))

Create table PromoCode(Promocode int not null,
CustomerUserName Varchar(40) not null,
RatingValue int not null
Foreign Key (CustomerUserName) References Customer,
Primary Key(PromoCode,CustomerUserName))

create  table  Admin (	AdminID int not null,
						Email varchar(50) not null unique,
						password varchar(50) not null
						primary key (AdminID)
						)

Alter Table Car Add CustomerUserName VarChar(40), 
FoReign Key(CustomerUserName) References Customer; 

alter table Slots add Request int DEFAULT 0
alter table Garage add Garage_Name varchar(50)

alter table Archive add carid int 





insert into Garage(G_ID,Address,NumOfSlots,SoltCostPerHour,OwnerId,NumOfFreeSlots,WorkersNum,Garage_Name, City) values(1,'as',10,5,1,10,15,'ahmed','asd');

insert into PromoCode (Promocode,CustomerUserName) values  (1,'salmaa');

DELETE FROM PromoCode WHERE Promocode=1   AND CustomerUserName='salma'

select DISTINCT carid from Archive 

SELECT dbo.OwnerOfGarage.Email,SUM(dbo.Garage.TotalProfit) FROM dbo.Garage,dbo.OwnerOfGarage WHERE Garage.OwnerId=OwnerOfGarage.OwnerId GROUP BY Email

INSERT INTO dbo.Worker ( W_ID, Name,Salary,TimeShift,Password, Address,G_ID,Email) VALUES





