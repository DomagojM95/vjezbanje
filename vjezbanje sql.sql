use master;

 drop database if exists organizacija;

 go
 create database organizacija;
 go
 use organizacija;

 create table udruga(
	sifra int not null  primary key identity (1,1),
	ime varchar(50)not null,
	adresa varchar(50)not null,
	radnovrijeme time not  null,
	
 );

 create table sticenki(
	sifra int not null  primary key identity (1,1),
	ime varchar (50),
	prezime varchar(50),
	zivotinja int not null,
	prostor int not null,
	udruga int not null
 );

 create table prostor(
	sifra int  not null primary key identity (1,1),
	oznaka int not null,
	sticenik int not null
 );

 create table zivotinja(
	sifra int not null primary key identity (1,1),
	ime varchar(50),
	vrsta varchar(50)
 );

alter table prostor add foreign key (sticenik) references sticenik(sifra);