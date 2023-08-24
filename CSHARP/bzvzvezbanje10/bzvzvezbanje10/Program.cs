

using System.Threading.Channels;
using bzvzvezbanje10;

int KlasicnaMetoda(int b)
{
    return b * b;
}

Console.WriteLine(KlasicnaMetoda(5));

var kvadrat = (int b) => b * b;

Console.WriteLine(kvadrat(5));

var algoritam = (int x, int y) =>
{
    var t = x++ + --y;
    return x + y - t;
};


Console.WriteLine(algoritam(1,2));



int[] brojevi = { 2, 3, 4, 3, 2, 3, 4, 3 };

int tri = 0;

for(int i=0;i<brojevi.Length;i++)
{
    if (brojevi[i] == 3)
    {
        tri++;  
    }
    
}

Console.WriteLine(tri);

Console.WriteLine(brojevi.Count(b=> b>3));



for(int i = 0; i < brojevi.Length; i++)
{
    Console.WriteLine(brojevi[i]);
}

Console.WriteLine("---------------------------");


foreach (int k in brojevi)
{
    Console.WriteLine(k);
}

Console.WriteLine("-----------------------------");

Array.ForEach(brojevi, Console.WriteLine);

Console.WriteLine("-----------------------------");

Array.ForEach(brojevi, b =>
{
    Console.WriteLine(b + 1);
});
Console.WriteLine("-----------------------------");
var lista=new List<int>() { 2,3,4,5,4};

lista.ForEach(Console.WriteLine);



var smjerovi= new List<Smjer>() { 
    new () { Naziv="Prvi"},
    new () { Naziv="Drugi" }
};


smjerovi.ForEach(Console.WriteLine);


