



using Polimorfizam;

Osoba[] osobe=new Osoba[3];

osobe[0] = new Polaznik { Ime = "pero" };
osobe[1] = new Polaznik { Ime = "kata" };
osobe[2] = new Predavac { Ime = "mata" };

void pozdraviSve(Osoba[] o) 
{
    foreach (Osoba osoba in o)
    {
        Console.WriteLine(osoba.Pozdravi());
    }
}

pozdraviSve(osobe);