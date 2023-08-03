

using vjezbanjeNasljedivanje;

var o = new Osoba
{
    Sifra = 1,
    Ime = "Pero",
    Prezime = "Perić"
};


Console.WriteLine(o);

var drugaOsoba = new Osoba
{
    Sifra = 1,
    Ime = "Marina",
    Prezime = "Marić"
};

Console.WriteLine(o.Equals(drugaOsoba));

var p = new Polaznik
{
    Sifra = 1,
    Ime = "marko",
    Prezime = "hohohe",
    BrojUgovora="2023/56"
};


Console.WriteLine(p);

var pr = new Predavac
{
    Sifra = 1,
    Ime = "rita",
    Prezime = "man",
    Iban = "hr563464354353543"
};

Console.WriteLine(pr);

