use master;

drop database if exists muzej;
go
create database muzej;
go
use  muzej;


create table izlozba(
	sifra int not null primary key identity(1,1),
	naziv varchar(50),
	sponzor int,
	kustos int

);

create table kustos(
	sifra int not null primary key identity(1,1),
	ime varchar(50),
	prezime varchar(50),
	oib varchar(50)

);

create table sponzor(
	sifra int not null primary key identity(1,1),
	naziv varchar(50)

);

create table djelo(
	sifra int not null primary key identity(1,1),
	ime varchar(50),
	autor varchar(50),
	izlozba int
);

alter table izlozba add foreign key (sponzor) references sponzor(sifra);
alter table izlozba add foreign key (kustos) references kustos(sifra);
alter table djelo add foreign key (izlozba) references izlozba(sifra);
