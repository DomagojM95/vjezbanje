use master;
drop database if exists taxi;
 go
 create database taxi;
go
use taxi;

create table vozilo(
	sifra int  not null primary key identity(1,1),
	marka varchar(50),
	registracija varchar(50),
	vozac int

);

create table vozac(
	sifra int  not null primary key identity(1,1),
	ime varchar(50),
	prezime varchar(50),
	oib varchar(50)

);

create table putnik(
	sifra int  not null primary key identity(1,1),
	ime varchar(50),
	prezime varchar(50),
	oib varchar(50)
);

create table voznja(
	sifra int  not null primary key identity(1,1),
	vozilo varchar(50),
	vozac int,
	putnik int,
	destinacija varchar(50)
);

create table putnik_voznja(
	voznja int,
	putnik int
);



alter table vozilo add foreign key (vozac) references vozac(sifra);
alter table putnik_voznja add foreign key(putnik) references putnik(sifra);
alter table putnik_voznja add foreign key (voznja) references voznja(sifra);
alter table voznja add foreign key (vozac) references vozac(sifra);
