use master;
 drop database if exists vrtic;
 go
create database vrtic;

go
use vrtic;

create table skupina(
	ID int  not null primary key identity(1,1),
	ime varchar(50),
	odgajateljica int
);

create table strucnasprema(
	ID int  not null primary key identity(1,1),
	ime varchar(50),
	odgajateljica int not null
);

create table odgajateljica(
	ID int  not null primary key identity(1,1),
	ime varchar(50),
	prezime varchar(50),
	strucnasprema int not null
);

alter table skupina add foreign key (odgajateljica) references odgajateljica(ID);
alter table odgajateljica add foreign key (strucnasprema) references strucnasprema(ID);