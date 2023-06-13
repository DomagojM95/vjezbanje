use master;

drop database if exists opg;
go

create database opg;
go
 use opg;

 create table proizvod(
	sifra int not null primary key identity(1,1),
	ime varchar(50),
	sastojci varchar(50),
	djelatnik int
 );

 create table sirovina (
	sifra int not null primary key identity(1,1),
	ime varchar(50),
	rok_trajanja datetime
 );

 create table djelatnik(
	sifra int not null primary key identity(1,1),
	ime varchar(50),
	prezime varchar(50),
 );

 create table proizvod_sirovina(
	sifra int not null primary key identity(1,1),
	sirovina int,
	proizvod int
 );

 alter table proizvod_sirovina add foreign key (sirovina) references sirovina(sifra);
 alter table proizvod_sirovina add foreign key (proizvod) references proizvod(sifra);
 alter table proizvod add foreign key (djelatnik) references djelatnik(sifra);