select b.naslov
from autor a inner join katalog b on b.autor=a.sifra
where a.ime='ivana'  and a.prezime='Brlić Mažuranić';

 

 select distinct c.naziv
 from autor a inner join katalog b on b.autor=a.sifra
 inner join  mjesto c on b.mjesto=c.sifra
 where a.ime='august' and a.prezime='šenoa';

 select a.naziv, b.naslov
 from izdavac a inner join katalog b on  b.izdavac=a.sifra
 where a.naziv  like 'E%' order by 2;

 select distinct a.ime
 from autor a left join katalog b on a.sifra=b.autor
 where b.sifra is null;