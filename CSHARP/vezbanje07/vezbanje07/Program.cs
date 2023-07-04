


using System.Diagnostics.Tracing;
using System.Linq.Expressions;
using vezbanje07;

string ime = "pero";
string prezime = "perić";
int godine = 24;


ime = "marija";


Osoba osoba = new Osoba();


osoba=new Osoba("Pero");

//Dokument dokument = new Dokument();

//dokument = new Dokument("ivan");

Dokument[] dokument = new Dokument[3];

dokument[0] = new Dokument();
dokument[1] = new Dokument();
dokument[2] = new Dokument("racun");


Smjer smjer=new Smjer("wp",56);

Grupa grupa;
for(int i = 0; i < 128; i++)
{
    grupa= new Grupa();

}


