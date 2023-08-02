using vjezbanjeucahurivanje;

Osoba osoba=new Osoba();
osoba.setIme("Pero");
osoba.Prezime = "peric";

Console.WriteLine("{0} {1}",osoba.Prezime,osoba.setIme);


Smijer smjer=new Smijer();
smjer.Sifra = 1;
smjer.Naziv = "web programiranje";
smjer.Trajanje = 250;


smjer = new Smijer
{
    Sifra = 1,
    Naziv = "java programiranje"
};

Zupanija obz = new Zupanija
{
    Naziv = "ODIJECKO BARANJSKA   ",
    Zupan = "anusic"

};


Grad grad = new Grad 
{
    Naziv="osijek",
    zupanija=obz
};

Console.WriteLine("grad je {0}, zupanija je{1 ", grad.Naziv,grad.zupanija.Naziv);