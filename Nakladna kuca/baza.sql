use master;

drop database if exists NakladnaKuca;
go

create database NakladnaKuca;
go
use NakladnaKuca;

create table nakladnik(
	sifra int not null primary key identity (1,1),
	ime varchar(50),
	oib varchar(50),
	adresa varchar(50),
	mjesto int

);

create table djelo(
	sifra int not null primary key identity (1,1),
	ime varchar(50),
	autor varchar(50)

);

create table mjesto(
	sifra int not null primary key identity (1,1),
	ime varchar(50),
	drzava varchar(50),
	opcina varchar(50),
	
);

create table nakladnik_djelo(
	nakladnik int,
	djelo int
);

alter table nakladnik_djelo add foreign key (nakladnik) references nakladnik(sifra);
alter table nakladnik_djelo add foreign key (djelo) references djelo(sifra);
alter table nakladnik add foreign key (mjesto) references mjesto (sifra);

insert into djelo(ime,autor)
values('U potrazi za staklenim gradom ', 'Borna Bebek, Željko Malnar'),
('Prstenova družina','John Ronald Reuel Tolkien'),('Pjesma leda i vatre ','George R.R. Martin');

 insert into mjesto(ime,drzava,opcina)
 values('osijek','Hrvatrska','osijecko_Baranjska' ),('zagreb','Hrvatska','Zagrebacka'),('Slavonski Brod','Hrvarska','Brodsko_Posavska');

 insert into nakladnik(ime,oib,adresa,mjesto)
 values('Mozaik','094902039','nemam pojma',2),('školska knjiga','094902039','nemam pojma',3),('lumen','094902039','nemam pojma',1);
 
