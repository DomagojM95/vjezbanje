

using System.Diagnostics.Tracing;
using bzvzvvjezbanej02;

void Tip1()
{
    Console.WriteLine("Dobrodošli u program");
}

Tip1();

void Tip2(string poruka)
{
    Console.WriteLine(poruka);
}
Tip2("ovo je vrijednost koju prosljedujem");
string s = "vrijednost varijable s";

Tip2(s);


int Tip3()
{
    return new Random().Next();
}

Tip3();
Console.WriteLine(Tip3());


int sb = Tip3();
Console.WriteLine(sb);



int Tip4(int min , int max)
{
    int manji= min <max ? min : max;
    int veci = max >min ? max : min;
    sb = 3;
    return new Random().Next(manji,veci);
}


Console.WriteLine(Tip4(20,30));
Console.WriteLine(Tip4(-20, -30));




void ispis()
{
    Console.WriteLine("HELLO WORLD");
}

//void ispis(string poruka)
//{

//}

Metode m= new Metode();
m.ispis();
m.ispis("12");
m.ispis(12);

Console.WriteLine( Metode.izracunaj(23, 12));


int[,] t = new int[5, 5];


Metode.IspisiMatricu(t);

t[2, 4] = 7;

Metode.IspisiMatricu(t);

//stao na predavanju 28.06, 49 minuta