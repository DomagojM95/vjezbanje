
//for(int i = 0; i < 0; i++)
//{
//    Console.WriteLine("nisam usao");
//}


//while (false)
//{
//    Console.WriteLine("hah");
//}

//int b=0;

//while(b < 10)
//{
//    Console.WriteLine(++b);
//}

//b = 0;

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
//    Console.Write("unesi cijeli broj; ");
//    b=int.Parse(Console.ReadLine());
//    if(b>0 && b <= 10)
//    {
//        break;
//    }
//    Console.WriteLine("morate unjeti broj izmedu 1 i 10");
//}

//Console.WriteLine("uneseni broj je: {0}",b) ;

//using System.Collections.Concurrent;

//int k = 2;
//while (k <= 97)
//{
//    Console.WriteLine(k);
//    k = k + 3;
//}

//int b = 2;

//while (true)
//{
//    Console.WriteLine(b);
//    b = b + 3;
//    if (b > 97)
//    {
//        break;
//    }
//}

//int j = 1;
//int zbroj = 0;

//while (j <= 100)
//{
//    zbroj += j;
//    j++;
//}
//Console.WriteLine("zbroj prvih 100 brojeva je: {0}",zbroj);



//do
//{
//    Console.WriteLine("ušao u petlju");
//} while (false);


//int br1 = 0;
//int br2 = 0;




//do
//{
//    Console.Write("Unesi prvi cijeli broj: ");
//    br1 = int.Parse(Console.ReadLine());
//    if (br1 >= 10 && br1 <= 20)
//    {
//        break;
//    }
//    Console.WriteLine("Broj nije između 10 i 20!");

//} while (true);


//do
//{
//    Console.Write("Unesi drugi cijeli broj: ");
//    br2 = int.Parse(Console.ReadLine());
//    if (br2 >= 10 && br2 <= 20)
//    {
//        break;
//    }
//    Console.WriteLine("Broj nije između 10 i 20!");

//} while (true);


//int manji = br1 < br2 ? br1 : br2;
//int veci = br2>br1? br2:br1;
//int i = manji;

//do
//{
//    if (i % 2 == 0)
//    {
//        Console.Write(i);
//    }
//} while (++i <= veci);



int[] niz = { 2, 3, 45, 5, 6, 4 };
for(int i =0; i < niz.Length; i++)
{
    Console.WriteLine(niz[i]);
}

for(int i = niz.Length - 1; i >= 0; i--)
{
    Console.WriteLine(niz[i]);
}

foreach(int en in niz)
{
    Console.WriteLine(en);
}

int redaka, stupaca;

Console.Write("unesi broj redova: ");
redaka=int.Parse(Console.ReadLine());

Console.Write("unesi broj stupaca: ");
stupaca=int.Parse(Console.ReadLine());

int[,] matrica= new int[redaka, stupaca];

for(int i = 0; i < redaka; i++)
{
    for(int j= 0;j< stupaca; j++)
    {
        Console.Write(matrica[i, j] + " ");
    }
    Console.WriteLine();
}

int b = 1;
for(int i= 1;i <=stupaca; i++)
{
    matrica[redaka - 1, stupaca - i] = b++;
}


for(int i = 0; i < redaka; i++)
{
    for(int j=0; j < stupaca; j++)
    {
        Console.Write(matrica[i, j] + " ");
    }
    Console.WriteLine();
}
