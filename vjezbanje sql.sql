--create database frizerskisalon;
use frizerskisalon;

create table termin(
	sifra int not null primary key identity (1,1),
	datum datetime not null,
	korisnik int not null,
	usluga int not null,
	djelatnica int not null
);

create table djelatnica(
	 sifra  int not null primary key identity (1,1),
	 ime varchar(50),
	 prezime varchar(50)

);

create table usluga(
	sifra int not  null primary key identity (1,1),
	cijena decimal(18,2),
	naziv varchar(50),
	);

create table korisnik(
	sifra int not null primary key identity (1,1),
	ime varchar(50) not null,
	prezime varchar(50) not null,
	spol varchar(50)not null,
	duzinakose int
	);

	create table zupanija(
	sifra int primary key identity (1,1),
	ime varchar(50),
	prezime varchar(50),
	zupan int

);




alter table termin add foreign key (korisnik) references korisnik(sifra);