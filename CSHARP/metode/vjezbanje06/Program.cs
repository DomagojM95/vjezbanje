

using System.Collections.Concurrent;
using System.Diagnostics.Tracing;
using zajednickeMetod;

void tip1()
{
    Console.WriteLine("Dobro došli u program");
}


//tip1();

void tip2(string poruka)
{
    Console.WriteLine(poruka);
}


tip2("ovo je bbalbalbalblablba");

string s = "hahhahaha";

tip2(s);

int tip3()
{
    return new Random().Next();
}

tip3();

Console.WriteLine(tip3());

int broj = tip3();

Console.WriteLine(broj);    



int tip4(int min, int max)
{
    int manji=min<max? min : max;
    int veci=max>min?max:min;
    broj = 3;
    return new Random().Next(manji,veci);
}

Console.WriteLine(tip4(20,30));
Console.WriteLine(tip4(-20,-30));


void ispis()
{
    Console.WriteLine("hello world");
}

//void ispis(string poruka)
//{

//}

metode m = new metode();

m.ispis();

Console.WriteLine(metode.izracunaj(2,8));

m.ispis(12);


int[,] t = new int[5, 5];

metode.ispisiMatricu(t);

t[2, 4] = 7;


metode.ispisiMatricu(t);

Console.WriteLine(metode.faktorijel(5));


