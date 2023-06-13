use master;

drop database if exists postolar;
go

create database postolar;
go
use postolar;

create table popravak(
	sifra int primary key identity(1,1),
	cijena decimal,
	obuca int,
	segrt int
);

create table segrt(
	sifra int primary key identity(1,1),
	ime varchar(50),
	prezime varchar(50),

);

create table musterija(
	sifra int primary key identity(1,1),
	ime varchar(50),
	prezime varchar(50),

);

create table obuca(
	sifra int primary key identity(1,1),
	vrsta varchar(50),
	musterija int
);

create table popravak_obuca(
	obuca int,
	popravak int
);

alter table popravak_obuca add foreign key (popravak) references popravak(sifra);
alter table popravak_obuca add foreign key  (obuca) references obuca(sifra);
alter table obuca add foreign key (musterija) references musterija(sifra);
alter table popravak add foreign key (segrt) references segrt(sifra);