use master;

drop database if exists vodoinstalater;
go

create database vodoinstalater;
go

use vodoinstalater;

create table popravak(
	sifra int not null primary key identity(1,1),
	cijena decimal,
	trajanje time,
	radnik int
);

create table radnik(
	sifra int not null primary key identity(1,1),
	ime varchar(50),
	prezime varchar(50),
	oib varchar(50),
	kontakt varchar(50),
	strucnasprema int
);

create table kvar(
	sifra int not null primary key identity(1,1),
	vrsta varchar(50),
	naziv varchar(50)

);


create table strucnasprema(
		sifra int not null primary key identity(1,1),
		stupanj varchar(50)
);

create table kvar_popravak(
	popravak int,
	kvar int
);

alter table kvar_popravak add foreign key (popravak) references popravak(sifra);
alter table kvar_popravak add foreign key (kvar) references kvar(sifra);
alter table radnik add foreign key (strucnasprema) references strucnasprema(sifra);
alter table popravak add foreign key (radnik) references radnik(sifra);