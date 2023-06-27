

//using System.Collections.Concurrent;

//while (true)
//{
//    break;
//}

//for (int i = 0; i < 0; i++)
//{
//    Console.WriteLine("nisam usao");
//}

//while (false)
//{
//    Console.WriteLine("nisam usao");
//}

//int b= 0;   

//while (b < 10)
//{
//    Console.WriteLine(++b);
//}

//int t = 2;
//    b=0;

//while (t==2 && b < 10)
//{
//    Console.WriteLine(++b);
//}

//b= 0;

//while (true)
//{
//    if (b == 2)
//    {
//        b++;
//        continue;
//    }
//    if (b == 5)
//    {
//        break;
//    }
//    Console.WriteLine(b++);
//}

//while (true)
//{
//    Console.Write("unesi broj: ");
//    b = int.Parse(Console.ReadLine());
//    if (b > 0 && b <= 10)
//    {
//        break;
//    }
//    Console.WriteLine("morate unjeti broj izmedu 1 i 10");
//}
//Console.WriteLine("UNESIENI BROJ JE: {0}",b);

//int b = 2;

//while (b <= 97)
//{
//    Console.WriteLine(b);
//    b = b + 3; 
//}

int b = 2;

//while (true)
//{
//    Console.WriteLine(b);
//    b += 3;
//    if (b > 97)
//    {
//        break;
//    }
//}



do
{
    Console.WriteLine("usao u petlju");
} while (false);

int b1 = 0;
do
{
    Console.Write("unesi prvi cijeli broj: ");
    b1=int.Parse(Console.ReadLine());
    if(b1>=10 && b1 <= 20)
    {
        break;
    }
    Console.WriteLine("nisi unio trazeni broj");

} 
while (true);


int b2 = 0;
do
{
    Console.Write("unesi drugi cijeli broj: ");
    b2 = int.Parse(Console.ReadLine());
    if (b2 >= 10 && b2 <= 20)
    {
        break;
    }
    Console.WriteLine("nisi unio trazeni broj");

}
while (true);


int manji= b1<b2 ? b1 : b2;

if (b1 < b2)
{
    manji = b1;
}
else
{
    manji= b2;
}

int veci = b2 > b1 ? b2 : b1;

if (b2 > b1)
{
    veci = b2;
}
else { veci = b1; }

int i = manji;

do
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
} while (++i <= veci);