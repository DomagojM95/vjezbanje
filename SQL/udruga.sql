use master;

drop database if exists udruga;
go
create database udruga;
go
use udruga;

create table sticenki(
	sifra int not null primary key identity (1,1),
	ime varchar(50)not null,  
	prostor int
);

create table osoba(
	sifra int not null primary key identity (1,1),
	ime varchar(50) not null,
	prezime varchar(50) not null, 
	sticenkin int,
	prostor int
);

create table prostor(
	sifra int not null primary key identity (1,1),
	oznaka int,
	sticenik int
);


alter table osoba add foreign key (prostor) references prostor(sifra);
alter table prostor add foreign key (sticenik) references sticenik(sifra);
