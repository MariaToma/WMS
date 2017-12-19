create table Clients(
ClientID int identity(1,1) primary key,
Name nvarchar(50),
Address nvarchar(100)
)

Create table Warehouses(
WarehouseID int identity(1,1) primary key,
Address nvarchar(100),
NumberOfRows int default 50
)



Create table Rows(
RowID int primary key, 
constraint CHK_RowID check (RowID <=50), -- nr maxim de randuri dintr-un depozit, un rand poate avea oricate rafturi
MaxProductsPerShelf int default 20-- numar maxim de produse pe raft
)


Create table ClientOrders(   -- comenzile de la clienti
OrderID int identity (1,1),
ClientID int,
OrderState nvarchar(20) default 'unprocessed',   -- apoi o sa fie 'processed'
constraint PK_OrderClient primary key (OrderID, ClientID),
constraint FK_Clients foreign key (ClientID) references Clients(ClientID)
);


create table Products(
ProductID int,
ProductName nvarchar(50),
UnitPrice money,
UnitsInStock int,
WarehouseID int,
RowID int,
constraint PK_Products primary key (ProductID,WarehouseID,RowID),
constraint FK_Warehouse foreign key(WarehouseID) references Warehouses(WarehouseID),
constraint FK_Row foreign key(RowID) references Rows(RowID) 

);

drop table Products

create table ClientOrderDetails(
OrderID int,
ClientID int,
ProductID int,
Quantity int,
constraint PK_OrderProduct primary key(OrderID,ProductID),
constraint CHK_Quantity1 check(Quantity>0),
constraint FK_Order1 foreign key (OrderID,ClientID) references ClientOrders(OrderID,ClientID)
)

drop table ClientOrderDetails

create table RefillOrders(
OrderID int identity(1,1) primary key,
OrderSource int -- poate sa fie (0 sau 1 sau 2 sau .......)
-- daca e 0 e de la fabrica
-- daca e 1 sau 2 sau 3 -- asta e ID-ul depozitului de la care ia marfa

);

Create table RefillOrderDetails(
OrderID int,
ProductID int,
Quantity int,
constraint PK_Order_Product primary key(OrderID,ProductID),
constraint CHK_Quantity check (Quantity>0),
constraint FK_Order foreign key (OrderID) references RefillOrders(OrderID)
);