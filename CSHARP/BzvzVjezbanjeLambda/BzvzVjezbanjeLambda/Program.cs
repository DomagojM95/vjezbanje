using System.Linq.Expressions;
using System.Threading.Channels;

int KlasicnaMetoda(int x)
{
    return x * x;
}

void PozivKlasicneMEtode()
{
    Console.WriteLine(KlasicnaMetoda(5));
}

PozivKlasicneMEtode();


var kvadrat = (int x) => x * x;

Console.WriteLine(kvadrat(5));

var algoritam = (int x, int y) =>
{
    var t = x++ + --y;
    return x + y - t;
};




int[] brojevi = { 2, 7, 8, 4, 7, 5 };

int ukupno=brojevi.Count(x=>x==7);

Console.WriteLine("Ukupno brojeva 7: "+ukupno);

Console.WriteLine("ukupno brojeva vecih ili jednako 7: "
    +brojevi.Count(b=> b>=7));


for(int i = 0; i < brojevi.Length; i++)
{
    Console.WriteLine(brojevi[i]);
}
Console.WriteLine("-------------------------------");

foreach(int b in brojevi)
{
    Console.WriteLine(b);
}
Console.WriteLine("-------------------------------");

Array.ForEach(brojevi,Console.WriteLine);



Array.ForEach(brojevi, b =>
{
    Console.WriteLine(b+10);
});


var lista = new List<int> { 2, 7, 8, 4, 7, 5 };

for(int i = 0;i < lista.Count; i++)
{
    Console.WriteLine(lista[i]);
}
Console.WriteLine("-------------------------------");
foreach(int b in lista)
{
    Console.WriteLine(b);
}

Console.WriteLine("-------------------------------");


lista.ForEach(Console.WriteLine);

Console.WriteLine("-------------------------------");


lista.ForEach(b => Console.WriteLine(b + 10));