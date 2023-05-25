use knjiznica;

select * from autor where ime='Domagoj';

select  * from katalog where naslov like '%Ljubav%'
and sifra in (2680,2541,3031);


select * from autor where datumrodenja between '1980-01-01' and '1980-12-31'
and ime like '%a';

select * from autor where datumrodenja is null;

select * from autor;
insert into autor(sifra,ime, prezime,datumrodenja)
values (4,'Domagoj','marković','1995-11-10');


select * from izdavac;

delete from katalog where izdavac=390;

delete from izdavac where sifra=390;

delete from katalog where izdavac=394;
delete from izdavac where sifra=394;




