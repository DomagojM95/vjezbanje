use master;

drop database if exists samsotan;
 go
 create database samostan;
 go
 use samostan;

 create table svecenik(
	sifra int not null primary key identity (1,1),
	ime varchar(50),
	prezime varchar(50),
	posao int,
	nadredeni int
 );

 create table posao(
	sifra int not null primary key identity (1,1),
	naziv varchar(50),
	svecenik int,
	trajanje time,
	
 );

 create table posao_svecenik(
	svecenik int,
	posao int
 );

 alter table svecenik add foreign key (nadredeni) references svecenik(sifra);
 alter table posao_svecenik add foreign key (svecenik ) references svecenik(sifra);
 alter table posao_svecenik add foreign key (posao) references posao (sifra);