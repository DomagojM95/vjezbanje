use master;

drop database if exists kolkovi;
go

create database kolokvi;
 go
 use kolokvi;

 create table brat(
	sifra int not null primary key identity(1,1),
	suknaj varchar(47),
	ogrlica int not null,
	asocijalno int not null,
	neprijatelj int not null
 );

 create table neprijatelj(
	sifra int not null primary key identity(1,1),
	majica varchar(32),
	haljina varchar(43) not null,
	lipa decimal(16,8),
	modelnaocala varchar(49),
	kuna decimal(12,6),
	jmbag char(11)not null,
	cura int not null

 );

 create table cura(
	sifra int not null primary key identity(1,1),
	haljina varchar(33)not null,
	drugiputa datetime not null,
	suknja varchar(38),
	narukvica int ,
	introvertno bit ,
	majica varchar(40)not null,
	decko int not null
	);

	create table decko(
		sifra int not null primary key identity(1,1),
		indiferentno bit,
		vesta varchar(34),
		asocijalno bit not null

	);

	create table decko_zarucnica(
		sifra int not null primary key identity(1,1),
		decko int not null,
		zarucnica int not null

	);

create table zarucnica(
	sifra int not null primary key identity(1,1),
	narukvica int,
	bojakose varchar(37)not null,
	novcica decimal(15,9),
	lipa decimal(15,8)not null,
	indiferentno bit not null

);

create table prijatelj(
	sifra int not null primary key identity(1,1),
	modelnaocala varchar(37),
	treciputa datetime not null,
	ekstroventno bit not null,
	prviputa datetime,
	svekar int not null
);

create table svekar(
	sifra int not null primary key identity(1,1),
	stilfrizura varchar(48),
	ogrlica int not null,
	asocijalno bit not null
);

alter table prijatelj add foreign key (svekar) references svekar(sifra);
alter table brat add foreign key (neprijatelj) references neprijatelj(sifra);
alter table neprijatelj add foreign key (cura) references cura(sifra);
alter table cura add foreign key (decko) references decko(sifra);
alter table decko_zarucnica add foreign key (decko) references decko(sifra);
alter table decko_zarucnica add foreign key (zarucnica) references zarucnica(sifra);


insert into decko_zarucnica(decko,zarucnica)
values(1,1),(2,2),(3,3);

insert into zarucnica(narukvica,bojakose,novcica,lipa,indiferentno)
values(10,'crvena',15.8,10.10,1),(10,'crvena',15.8,10.10,1),(10,'crvena',15.8,10.10,1);


insert into decko(indiferentno,vesta,asocijalno)
values(1,'plava',3),(1,'plava',3),(1,'plava',3);


insert into cura(haljina,drugiputa,suknja,narukvica,introvertno,majica,decko)
values('crna','2023-08-12','bijela',1,3,'crvena',1),
('crna','2023-08-12','bijela',1,3,'crvena',2),
('crna','2023-08-12','bijela',1,3,'crvena',3);

insert into neprijatelj(majica,haljina,lipa,modelnaocala,kuna,jmbag,cura)
values('plava','roza',18.9,'kockasti',15.7,'11111111111',1),
('plava','roza',18.9,'kockasti',15.7,'22222222222',2),
('plava','roza',18.9,'kockasti',15.7,'33333333333',3);

insert into prijatelj(modelnaocala,treciputa,ekstroventno,prviputa,svekar)
values('kockasti','2024-12-12',1,'2012-12-12',1),
('kockasti','2024-12-12',1,'2012-12-12',2),
('kockasti','2024-12-12',1,'2012-12-12',3);

insert into svekar(stilfrizura,ogrlica,asocijalno)
values('duga',3,4),('duga',3,4),('duga',3,4);

select * from prijatelj;

update prijatelj set treciputa='2023-12-12';

insert into brat(suknaj,ogrlica,asocijalno,neprijatelj)
values('plava',4,2,1),('plava',4,2,2),('plava',4,2,3);

select * from cura

delete from brat where sifra=3;

select suknja from cura;

select * from  brat


select a.novcica, f.neprijatelj, e.haljina
from zarucnica a inner join decko_zarucnica b on b.zarucnica=a.sifra
inner join decko c on b.decko=c.sifra
inner join cura d on d.decko=c.sifra
inner join neprijatelj e on e.cura=d.sifra
inner join brat f on f.neprijatelj=e.sifra
where d.drugiputa is not null and c.vesta like '%a%'
order by 3;




