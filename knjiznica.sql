use master;
drop database if exists knjiznica;
go
create database knjiznica;
go
use knjiznica;

create table katalog(
	sifra int not null primary key identity(1,1),
	autor int,
	naslov varchar(50),
	izdavac int,
	mjesto int
);

create table autor(
		sifra int not null  primary key identity(1,1),
		ime varchar(50),
		prezime varchar(50),
		datumrodenja datetime,

);

create table izdavac(
		sifra int not null primary key identity(1,1),
		naziv varchar(50),
		aktivan varchar(50),
);

create table mjesto(
		sifra int not null primary key identity(1,1),
		naziv varchar(50),
		drzava varchar(50)
);

alter table katalog add foreign key (autor) references autor(sifra);
alter table katalog add foreign key (izdavac) references izdavac(sifra);
alter table katalog add foreign key (mjesto) references mjesto(sifra);