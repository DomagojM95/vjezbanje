use master;
drop database if exists hijararhija;
go
create database hijararhija;
go
use hijararhija;

create table zaposlenik(
	sifra int not null primary key identity (1,1),
	ime varchar(50),
	prezime varchar(50),
	placa money,
	nadredeni int
);
alter table zaposlenik add foreign key (nadredeni) references zaposlenik(sifra);