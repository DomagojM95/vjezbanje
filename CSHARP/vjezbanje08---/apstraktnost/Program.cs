

using apstraktnost;

var p = new Polaznik
{
    Ime="pero",
    przime="k",
    Spol="Muško"
};

void ispis(Osoba o)
{
    o.Pozdravi();
}

ispis(p);