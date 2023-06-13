use master;

drop database if exists trgovackicentar;
go

create database trgovackicentar;
go
use trgovackicentar;


create table trgovina(
	sifra int not null primary key identity (1,1),
	ime varchar(50),
	radnovrijeme time

);

create table osoba(
	sifra int not null primary key identity (1,1),
	ime varchar(50),
	prezime varchar(50),
	oib varchar(50)
);

create table sef(
	sifra int not null primary key identity (1,1),
	osoba int,
	trgovina int
);

create table trgovina_osoba(
	osoba int,
	trgovina int
);

alter table trgovina_osoba add foreign key (osoba ) references osoba(sifra);
alter table trgovina_osoba add foreign key (trgovina ) references trgovina (sifra);
alter table sef add foreign key (trgovina) references trgovina (sifra);
alter table sef add foreign key (osoba) references osoba (sifra);