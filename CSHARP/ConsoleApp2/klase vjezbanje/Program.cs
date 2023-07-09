
using System.Reflection.Metadata;
using klase_vjezbanje;

Zupan zupan = new Zupan 
{
    Ime="Karlo",
    Prezime="k"
    
};

Zupanija zupanija = new Zupanija
{
    Zupan = zupan,
    Naziv="osijecko-Baranjska"
};


Mjesto mjesto = new Mjesto 
{
    zupanija= zupanija,
    Naziv="Dakovo",
    BrojStanovnika=12121212
};

Console.WriteLine(mjesto.zupanija.Zupan.Ime);


var b = new Metod();
new Metod(8);

