use master;

drop database if exists zupanijaa;
go

create database zupanijaa;

go

use zupanijaa;

create table zupanija(
	sifra int not null primary key identity (1,1),
	naziv varchar(50),
	zupan int
);

create table zupan(
	sifra int not null primary key identity (1,1),
	ime varchar(50),
	prezime varchar(50)

);

create table opcina(
	sifra int not null primary key identity (1,1),
	zupanija int,
	naziv varchar(50)

);

create table mjesto(
	sifra int not null primary key identity (1,1),
	opcina int,
	naziv varchar(50),
);

alter table zupanija add foreign key (zupan) references zupan(sifra);
alter table opcina add foreign key (zupanija) references zupanija(sifra);
alter table mjesto add foreign key (opcina) references opcina (sifra);
