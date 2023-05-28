use master;

drop database if exists vatrugasci;

go

create database vatrugasci;

go

use vatrugasci;

create table naslovnica(
	sifra int not null primary key identity(1,1),
	naslov varchar(50),
	ime varchar(50),
	vijest int,
	dogadaj int,
	prijavnica int,
	mail varchar(50),
	mob int,
	fotografija int,
	baza_drustva int

);

create table prijavnica(
	sifra int not null primary key identity(1,1),
	ime varchar(50),
	prezime varchar(50),
	email varchar(50),
	mob int,
	oib varchar(50),
	korisnik int
);


create table dogadaj(
	sifra int not null primary key identity(1,1),
	ime varchar(50),
	datum datetime,
	vrijeme_pocetka time
	
);


create table vijest(
	sifra int not null primary key identity(1,1),
	naslov varchar(50),
	opis varchar(50),
	slika varchar(50)

);

create table fotografija(
	sifra int not null primary key identity(1,1),
	datum_objave datetime,
	opis varchar(50)


);

create table korisnik(
	sifra int not null primary key identity(1,1),
	korisnicko_ime varchar(50),
	lozinka varchar(50)
);

create table baza_drustva(
	sifra int not null primary key identity(1,1),
	drustva varchar(50)
);


alter table naslovnica add foreign key (dogadaj) references dogadaj(sifra);
alter table naslovnica add foreign key (vijest) references vijest(sifra);
alter table naslovnica add foreign key (prijavnica) references prijavnica (sifra);
alter table naslovnica add foreign key (fotografija) references fotografija(sifra);
alter table naslovnica add foreign key (baza_drustva) references baza_drustva(sifra);

alter table prijavnica add foreign key (korisnik) references korisnik(sifra);

