//Console.Write("upisite svoje ime: ");

//string ime=Console.ReadLine();
//string s;
//string t;


////for (int h = 1; h<10; h++)
////{
////    Console.Write("-");

////}

//for(int j = 1; j < 10; j++)
//{
//    for(int g = 1; g < 10; g++)
//    {
//        Console.Write("-");
//    }

//    Console.WriteLine();
//    if (j == 1)
//    {
//        Console.Write(": : : TABLICA MNOZENJA : : :") ;
//    }
//    else
//    {
//        break;
//    }
//    Console.WriteLine();



//for (int i = 1; i < 10;i++)
//{
//    Console.Write(i+" |");
//    for (int k=1; k < 10; k++)
//    {
//        s = "    " + i * k;
//        Console.Write(s[^4..]);
//    }
//    Console.WriteLine();
//}



//Console.Write("Upiši svoje dragocjeno ime: ");
//string ime = Console.ReadLine();
//string s;
//string t;


//for(int i = 0; i < 9; i++)
//{
//    if(i == 0| i==2 | i == 4 |i== 6 | i == 8)
//    {
//        Console.WriteLine("--------------------------------");
//    }
//    else if(i==1)
//    {
//        Console.WriteLine(": : : TABLICA MNOZENJA : : :");
//    }
//    else if( i==3) 
//    {
//        Console.Write(" * |");
//        for(int k=1; k<10; k++)
//        {
//            Console.Write(" "+k);
//        }
//        Console.WriteLine();
//    }
//    else if(i==5)
//    {
//        for (int l=1; l<10; l++)
//        {
//            Console.Write(" "+l+" |");
//            for(int r=1; r<10; r++)
//            {
//                s = "   " + l * r;
//                Console.Write(s[^3..]);
//            }
//            Console.WriteLine();
//        }
//    }
//    else if(i==7)
//    {
//        t = ": : : : : : : : : : : : " + "by " + ime;
//        Console.WriteLine(t[^31..]);
//    }
//}




//int a, b, w= 3;

//bool istina = w == 3;
//Console.WriteLine(istina);



using System.ComponentModel.DataAnnotations;
using System.Runtime.ExceptionServices;
using System.Threading.Channels;

//Console.Write("Unesite broj: ");

//int broj=int.Parse(Console.ReadLine());

//broj = broj + 7;
//Console.WriteLine(broj);

//Console.WriteLine("unesi prvi broj(. za decimalni dio):");
//double broj1=double.Parse(Console.ReadLine());

//Console.WriteLine("unesi drugi broj(. za decimalni dio):");
//double broj2=double.Parse(Console.ReadLine());

//double rez= broj1 + broj2;
//Console.WriteLine(rez);



//int a = 3;  
//int b = 4;

//float re = a / (float)b;

//Console.WriteLine(re);

//int broj = 15;

//Console.WriteLine(broj/10);



//bool razlicito = 3 != 4;

//bool vece = 8 > 6;

//Console.WriteLine("{0},{1}", razlicito, vece);




//bool rez = razlicito && vece;

//Console.WriteLine(rez);



//Console.Write("Unesi broj: ");

//int x=Int16.Parse(Console.ReadLine());

//Console.WriteLine(x%2==0);


//zadnje gledao predavanje od 14.06




//int i = 0;

//bool uvjet = i > 0;


//if (uvjet)
//{
//    Console.WriteLine("Vece od 0");
//}


//if (i > 0)
//{
//    Console.WriteLine("Opet vece od 0");
//}


//string grad = "Osijek";

//if (grad == "Osijek")
//{
//    Console.WriteLine("Super");
//}
//else
//{
//    Console.WriteLine("oke");
//}

//int b = 0;

//if (grad != "Zagreb")
//{
//    b=b+1;
//}else if (grad == "Split")
//{
//    b += 1;
//}else if (grad == "Osijek")
//{
//    b += 2;
//}
//else
//{
//    b++;
//}

//Console.WriteLine(b);

//i = 5; b = 2;

//if (i > 0)
//{
//    if (b == 2)
//    {
//        Console.WriteLine("oba uvjeta su zadovoljena");
//    }
//}


//if (i == 4 || b < 0)
//{

//}


//int g = 10;


//if (g%2==0)
//{
//    Console.WriteLine("Broj je paran");
//}
//else 
//{ 
//    Console.WriteLine("broj je neparan"); 
//}



//Console.Write("Upisi cijeli broj:");

//int j=int.Parse(Console.ReadLine());

//if (j<10)
//{
//    Console.WriteLine("Osijek");
//}
//else
//{
//    Console.WriteLine("Donji miholjac");
//}


//Console.Write("Upisi  broj:");
//int k = int.Parse(Console.ReadLine());

//Console.WriteLine(k % 2 == 0?" Broj je paran":" broj je Neparan") ;


//int i = 2;

//if (i == 1)
//{
//    Console.WriteLine("Dobro");
//}else if(i == 2)
//{
//    Console.WriteLine("oke");
//}
//else
//{
//    Console.WriteLine("Ostalo");

//}

//int ocjena = 3;

//switch (ocjena)
//{
//    case 1:
//        Console.WriteLine("Nedovoljan");
//        break;
//    case 2:
//        Console.WriteLine("Dovoljan");
//        break;
//    case 3:
//        Console.WriteLine("dobar");
//        break;
//    case 4:
//        Console.WriteLine("Vrlo dobar");
//        break;
//    case 5:
//        Console.WriteLine("Odlican");
//        break;
//    default:
//        Console.WriteLine("Nije ocijena");
//        break;
//}



//int[] niz;

//niz = new int[3];

//int[] podaci = { 2, 3, 4, 5, 66, 65, 5, 3, 535, 2, 44, };

//niz[0] = 2; 
//niz[1] = 1;
//niz[2] = 3;

//Console.WriteLine(niz[^1]);
//Console.WriteLine(niz[niz.Length-1]);


//int[,] tablica= new int[3,3];


//Console.WriteLine("1.***************");
//for(int i =0; i < 10; i = i + 1)
//{
//    Console.WriteLine("osijek");
//}



//Console.WriteLine("3.**********");

//for(int i=0; i < 10;i = i + 2)
//{
//    Console.WriteLine("CSHARP");
//}

//Console.WriteLine("4.***************");

//for(int i=0 ; i < 10 ; i++)
//{
//    Console.WriteLine(i);
//}

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i+1);
//}

//Console.WriteLine("7.***************");

//int zbroj = 0;

//for(int i=1; i<=100; i++)
//{
//    zbroj += i;
//}
//Console.WriteLine(zbroj);

//Console.WriteLine("8.***************");

//for(int i=0; i <= 57; i++) 
//{
//    if (i % 2 != 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//int[] niz = { 2, 2, 34, 54, 5, 6, 76, 7, 8, 7, 8 };

//Console.WriteLine("10. *****************");
//for (int i=0; i<niz.Length; i++)
//{
//    Console.Write(niz[i]+" ");
//}


//Console.WriteLine("11. *****************");


//Console.WriteLine("Unesi koliko borjeva ces proveravati: ");
//int brojeva=int.Parse(Console.ReadLine());
//int broj;
//int najveci=int.MinValue;

//for(int i = 0; i < brojeva; i++)
//{
//    Console.Write("unesi {0}. broj: ",i+1);
//    broj= int.Parse(Console.ReadLine());
//    if (broj > najveci)
//    {
//        najveci=broj;
//    }
//}
//Console.WriteLine("Najveci broj je {0}",najveci);


Console.WriteLine("14. *****************");
string s;
for(int i = 1; i < 10; i++)
{
    for(int k = 1; k <= 10; k++)
    {
        s = "    " + i * k;
        Console.Write(s[^4..]);
    }
    Console.WriteLine();
}

Console.WriteLine("Unesi dva cijela broja: ");
Console.Write("prvi broj: ");
int b1=int.Parse(Console.ReadLine());
Console.Write("drugi broj: ");
int b2 = int.Parse(Console.ReadLine());

int manji= b1 < b2 ? b1 : b2;
int veci = b1 > b2 ? b1 : b2;

int zbroj = 0;
for(int i=manji;i <= veci; i++)
{
    zbroj=i%2==0 ? zbroj +i :zbroj;
    Console.WriteLine(zbroj);
}





