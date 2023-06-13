select b.naslov

from autor a inner join katalog b on b.autor=a.sifra
where a.ime='ivana' and a.prezime='brlić mažuranić';

