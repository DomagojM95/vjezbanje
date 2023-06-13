use master;
drop database if exists rodbina;
go

create database rodbina;
go
use rodbina;

create table punac(
	sifra int not null primary key identity (1,1),
	ogrlica int,
	gustoca decimal(14,9),
	hlace varchar(41) not null
);

create table cura(
	sifra int not null primary key identity (1,1),
	novcica decimal(16,5)not null,
	gustoca decimal(18,6)not null,
	lipa decimal(13,10),
	ogrlica int not null,
	bojakose varchar(38),
	suknja varchar(36),
	punac int
);

create table sestra(
	sifra int not null primary key identity (1,1),
	introvertno bit,
	haljina varchar(31)not null,
	maraka decimal(16,6),
	hlace varchar(46)not null,
	rukavice int not null
);

create table zena(
	sifra int not null primary key identity (1,1),
	treciputa datetime,
	hlace varchar(46),
	kratkamajica varchar(31) not null,
	jmbag char(11)not null,
	bojaociju varchar(39)not null,
	haljina varchar(44),
	sestra int not null

);

create table sestra_svekar(
	sifra int not null primary key identity (1,1),
	sestra int not null,
	svekar int not null
);

create table svekar(
	sifra int not null primary key identity (1,1),
	bojaociju varchar(40)not null,
	prstena int,
	dukserica varchar(41),
	lipa decimal(13,8),
	eura decimal(12,8),
	majica varchar(35)
);

create table muskarac(
	sifra int not null primary key identity (1,1),
	bojaociju varchar(50)not null,
	hlace varchar(30),
	modelnaocala varchar(43),
	marka decimal(14,5) not null,
	zena int not null
);

create table mladic(
	sifra int not null primary key identity (1,1),
	suknja varchar(50)not null,
	kuna decimal(16,8)not null,
	drugiputa datetime,
	asocijalno bit,
	ekstroventno bit not null,
	dukserica varchar(48)not null,
	muskarac int 
);

alter table cura add foreign key (punac) references punac(sifra);
alter table zena add foreign key (sestra) references sestra(sifra);
alter table sestra_svekar add foreign key (sestra) references sestra(sifra);
alter table sestra_svekar add foreign key (svekar) references svekar(sifra);
alter table muskarac add foreign key (zena) references zena(sifra);
alter table mladic add foreign key (muskarac) references muskarac(sifra);

select * from muskarac
select * from zena where sestra=2
select *from sestra
select * from svekar

insert into svekar(bojaociju,prstena,dukserica,lipa,eura,majica)
values('crna',2,'crna',14.4,16.5,'siva'),
('crna',2,'crna',14.4,16.5,'siva'),
('crna',2,'crna',14.4,16.5,'siva');

insert into sestra(introvertno,haljina,maraka,hlace,rukavice)
values(1,'plava',100.89,'crne',1),
(1,'zelena',100.89,'crne',1),
(1,'crna',100.89,'crne',1);

insert into zena(treciputa,hlace,kratkamajica,jmbag,bojaociju,haljina,sestra)
values('2023-03-03','sive','plava',010201230,'crna','crvena',2),
('2023-10-20','sive','plava',010201230,'crna','crvena',4),
('2023-01-10','sive','plava',010201230,'crna','crvena',3);

insert into muskarac(bojaociju,hlace,modelnaocala,marka,zena)
values('plava','crne','uski',17.8,3),
('crna','crne','uski',18.10,4),
('roza','crne','uski',19.9,2);

select * from sestra_svekar

insert into sestra_svekar(sestra,svekar)
values(2,1),(3,2),(4,3);

select*from cura
select*from punac

insert into cura(novcica,gustoca,lipa,ogrlica,bojakose,suknja,punac)
values(18.8,20.8,8.9,1,'plava','crna',1),(18.8,20.8,8.9,1,'plava','crna',2),(18.8,20.8,8.9,1,'plava','crna',3);

insert into punac(ogrlica,gustoca,hlace)
values(3,19.0,'crne'),(3,19.0,'crne'),(3,19.0,'crne');

update  cura set gustoca=15.77; 