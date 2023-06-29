

//using System.Runtime.Serialization.Formatters;

//for (int i=0; i < 10; i++)
//{
//    Console.WriteLine("osijek");
//}



//for(int j = 10; j > 0; j--)
//{
//    Console.WriteLine("**");
//}

//for(int i=0; i < 11; i = i + 2)
//{
//    Console.WriteLine("ja");
//}

//for(int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i+1);
//}


//int zbroj = 0;

//for(int i=1; i<=100; i++)
//{
//    zbroj=zbroj+i;
//}

//Console.WriteLine(zbroj);

//for(int i = 1; i <= 57; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//zbroj = 0;
//for(int i = 2; i <= 18; i++)
//{
//    if(i % 2 == 0)
//    {
//        zbroj=zbroj+i;
//    }
//}

//Console.WriteLine(zbroj);

//using System.Runtime.Serialization.Formatters;

//int[] niz = { 2, 2, 34, 54, 5, 6, 76, 7 };

//// jedno ispod drugog ispisati svaki element niza

//for(int i = 0; i < niz.Length; i++)
//{
//    Console.WriteLine(niz[i]);

//}


// Program učitava koliko će se brojeva unijeti
// Program učitava brojeve za provjeru
// Program ispisuje najveći uneseni broj

//Console.Write("unesi koliko brojeva provjeravaš: ");

//int brojeva=int.Parse(Console.ReadLine());
//int broj;
//int najveci = int.MinValue;


//for(int i = 0; i < brojeva; i++)
//{
//    Console.Write("unesi {0} broj: ", i + 1);
//    broj= int.Parse(Console.ReadLine());
//    if (broj > najveci) {
//        najveci= broj;
//    }
//}
//Console.WriteLine("najveci broj je {0}", najveci);



//using System.Text;

//for (int i = 0; i < 10; i++)
//{
//    if (i == 3)
//    {
//        break;
//    }
//    Console.WriteLine(i);
//}

//for (int i = 1; i <= 10; i++)
//{
//    if (i == 2 || i == 5)
//    {
//        continue;
//    }
//    Console.WriteLine(i);
//}


//string s;
//for(int i = 1;i <= 10; i++)
//{
//    for(int k=1;k<=10; k++)
//    {
//        s = "   " + i * k;
//        Console.Write(s[^4..]);
//    }
//    Console.WriteLine();
//}

string s;
string b;
for (int i = 1; i <= 9; i++)
{
    Console.Write("-");
    Console.Write(i + (" ")+("|"));
    for (int k = 1; k <= 10; k++)
    {
        s = "   " + i * k;
        Console.Write(s[^4..]);
    }
    Console.WriteLine();
}



//for(int i=0; i < 10; i++)
//{
//    for(int k=0; k<10; k++)
//    {
//        goto labela;
//    }
//}

//labela:;

//int i, s = 0; for (i = 1; ; i++) { if (i <= 100) s += i; else break; }

//Console.WriteLine(s);



//Console.WriteLine("unesi prvi broj; ");
//int b1=int.Parse(Console.ReadLine());
//Console.WriteLine("unesi drugi broj: ");
//int b2=int.Parse(Console.ReadLine());

//int manji = b1 < b2 ? b1 : b2;
//int veci = b1 > b2 ? b1 : b2;

//for(int i = manji; i <= veci; i++)
//{
//    zbroj = i % 2 == 0 ? zbroj + i : zbroj;
//}

//Console.WriteLine(zbroj);

//int t = 100;
//for(int i = 0; i > t; i++)
//{
//    Console.WriteLine("usao u petlju");
//}

//for(int i = 100; i > 0; i--)

//    Console.Write(i + (i != 1 ? "," : " "));
