for(int i=0; i <10; i = i + 1)
{
    Console.WriteLine("osijek");
}

Console.WriteLine("2. **********");

int j = 0;
for(j=10; j>0; j--)
{
    Console.WriteLine("edunova");
}

for(int i=0;i <10; i=i+2)
{
    Console.WriteLine("csharp");
}
int[] niz = { 2, 3, 4, 5, 6, 8, 9, 42, 3 };

for( int i=0; i< niz.Length; i++)
{
    Console.WriteLine(niz[i]);
}

Console.WriteLine("unesi koliko brojeva provjeravas");
int brojeva= int.Parse(Console.ReadLine()); 

for(int i =0; i<brojeva; i++)
{
    Console.Write("unesi broj");

}