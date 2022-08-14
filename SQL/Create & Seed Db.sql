Use [db_name]
go

Create table Customers(
Id int Not null identity(1,1) primary key,
Name varchar(100) Not null
)

Create table Orders(
Id int Not null identity(1,1) primary key,
CustomerId int Not null foreign key references Customers(Id)
)

go

insert into Customers(Name)
values('Max'),('Pavel'), ('Ivan'), ('Leonid ')

insert into Orders(CustomerId)
values(2),(4)