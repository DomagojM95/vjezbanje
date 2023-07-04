using Ucahurivanje;

Osoba osoba=new Osoba();
osoba.ime="pero";
osoba.prezime = "perić";

Console.WriteLine("{0} {1}",osoba.prezime,osoba.ime);



Smjer smjer=new Smjer();
smjer = new Smjer {

    Sifra = 1,
    naziv="wp",
    upisnina = 200
};

Console.WriteLine("smjer je {0}, naziv je{1}",smjer.Sifra,smjer.naziv);

Zupanija zupanija = new Zupanija {

    naziv="osijecko-baranjska",
    Zupan="anušić"
};

Grad grad = new Grad 
{
    Naziv="osijek",
    zupanija=zupanija
};

Console.WriteLine("grad je {0},zupanija je {1}",grad.Naziv,grad.zupanija.naziv);