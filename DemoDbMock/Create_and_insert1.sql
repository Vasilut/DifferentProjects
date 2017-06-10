create database X

create table Products(
	ProductId int not null IDENTITY(1,1),
	Name nvarchar(max),
	primary key (ProductId)
)

create table Links(
	LinkId int not null IDENTITY(1,1),
	StoreId int not null,
	Url nvarchar(max),
	primary key (LinkId)
)

create table Stores(
	StoreId int not null IDENTITY(1,1),
	Name nvarchar(max),
	RootUrl nvarchar(max),
	PriceRegex nvarchar(max),
	primary key (StoreId)
)

create table Matches(
	MatcheId int not null IDENTITY(1,1),
	ProductId int not null,
	LinkId int not null,
	primary key (MatcheId)
)

create table Details(
	DetailId int not null IDENTITY(1,1),
	MatcheId int not null,
	FoundDate date, 
	Price float,
	primary key (DetailId) 
)

alter table Links add foreign key (StoreId) references Stores(StoreId)
	 
alter table Matches add foreign key (ProductId) references Products(ProductId)
alter table Matches add foreign key (LinkId) references Links(LinkId)

alter table Details add foreign key (MatcheId) references Matches(MatcheId)

insert into Products(Name) values ('Iphone5')
insert into Products(Name) values ('Iphone5s')
insert into Products(Name) values ('Iphone5M')

insert into Stores(Name) values ('Emag')
insert into Stores(Name) values ('Flanco')
insert into Stores(Name) values ('F64')

insert into Links(Url,StoreId) values('emag.ro/iphone5',1)
insert into Links(Url,StoreId) values('flanco.ro/iphone5',2)
insert into Links(Url,StoreId) values('f64.ro/iphone5',3)

insert into Links(Url,StoreId) values('emag.ro/iphone5s',1)
insert into Links(Url,StoreId) values('flanco.ro/iphone5s',2)
insert into Links(Url,StoreId) values('f64.ro/iphone5s',3)

insert into Links(Url,StoreId) values('emag.ro/iphone5M',1)
insert into Links(Url,StoreId) values('flanco.ro/iphone5M',2)
insert into Links(Url,StoreId) values('f64.ro/iphone5M',3)


insert into Matches(LinkId,ProductId) values(1,1)
insert into Matches(LinkId,ProductId) values(2,1)
insert into Matches(LinkId,ProductId) values(3,1)

insert into Matches(LinkId,ProductId) values(4,2)
insert into Matches(LinkId,ProductId) values(5,2)
insert into Matches(LinkId,ProductId) values(6,2)

insert into Matches(LinkId,ProductId) values(7,3)
insert into Matches(LinkId,ProductId) values(8,3)
insert into Matches(LinkId,ProductId) values(9,3)

insert into Details(MatcheId) values(1)
insert into Details(MatcheId) values(2)
insert into Details(MatcheId) values(3)

insert into Details(MatcheId) values(4)
insert into Details(MatcheId) values(5)
insert into Details(MatcheId) values(6)

insert into Details(MatcheId) values(7)
insert into Details(MatcheId) values(8)
insert into Details(MatcheId) values(9)