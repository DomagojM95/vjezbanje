use master;
drop database if exists edunovawp1;

create database edunovawp1;

use edunovawp1;

create table smjer(
 sifra int not null primary key identity (1,1),
 naziv varchar(50) not null,
 trajanje int not null,
 cijena decimal (18,2),
 upisnina decimal (18,2),
 verficiranost bit
);

create table grupa(
	 sifra int not null primary key identity (1,1),
	 naziv varchar(50) not null,
	 smjer int not null,
	 datumpocetka datetime  not null
	 );

	 create table polaznik(
		 sifra int not null primary key identity (1,1),
		 ime varchar(50) not null,
		 prezime varchar (50) not null,
		 oib int,
		 email varchar(50)

	 );

create table  clan(
	grupa int not null,
	polaznik int not null

);

create table zupanija(
	sifra add primary key identity (1,1),
	ime varchar(50),
	prezime varchar(50),
	zupan int

);

alter table grupa add foreign key (smjer) references smjer(sifra);

alter table clan add foreign key (grupa) references grupa(sifra);

alter table clan add foreign key (polaznik) references polaznik(sifra)

