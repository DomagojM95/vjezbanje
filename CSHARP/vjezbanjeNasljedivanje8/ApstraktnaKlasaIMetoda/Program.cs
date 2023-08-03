


using ApstraktnaKlasaIMetoda;

var p = new Polaznik
{
    Ime = "pero",
    Spol="Muško"
};

var pr = new Predavac
{
    Ime = "mario",
    Godine=24

};

void ispis(Osoba o)
{
    o.Pozdravi();
}

ispis(p);
ispis(pr);


