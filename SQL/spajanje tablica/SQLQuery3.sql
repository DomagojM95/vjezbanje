select * from smjer where naziv='web programiranje';

select * from grupa where smjer=1;

select a.naziv as smjer,b.naziv
from smjer a inner join grupa b on a.sifra=b.smjer
where
a.naziv='web programiranje';

insert into grupa(naziv,smjer)
values('wp3',1);

select a.naziv as smjer,b.naziv
from smjer a inner join grupa b on a.sifra=b.smjer
order by 1;


select a.ime, a.prezime
from polaznik a inner join clan b on a.sifra=b.polaznik
inner join grupa c on b.grupa=c.sifra inner join
smjer d on c.smjer=d.sifra
where d.naziv='web programiranje';S