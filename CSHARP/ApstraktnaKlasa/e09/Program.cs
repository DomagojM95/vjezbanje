using e09;

var p = new Polaznik
{
    Ime = "pero",
    Spol="muško"
};
Console.WriteLine(p.Ime);

var pr = new Predavac
{
    Ime="mario",
    Goidne=23
};

void ispis(Osoba o)
{
   o.Pozdravi();
}

ispis(p);
ispis(pr+);