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
using System.Runtime.Serialization.Formatters;
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


//Console.WriteLine("14. *****************");
//string s;
//for(int i = 1; i < 10; i++)
//{
//    for(int k = 1; k <= 10; k++)
//    {
//        s = "    " + i * k;
//        Console.Write(s[^4..]);
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("Unesi dva cijela broja: ");
//Console.Write("prvi broj: ");
//int b1=int.Parse(Console.ReadLine());
//Console.Write("drugi broj: ");
//int b2 = int.Parse(Console.ReadLine());

//int manji= b1 < b2 ? b1 : b2;
//int veci = b1 > b2 ? b1 : b2;

//int zbroj = 0;
//for(int i=manji;i <= veci; i++)
//{
//    zbroj=i%2==0 ? zbroj +i :zbroj;
//    Console.WriteLine(zbroj);
//}


//while (true)
//{
//    break;
//}



//for(int i = 0; i < 0; i++)
//{
//    Console.WriteLine("Nisam ušao");
//}



//while (false)
//{
//    Console.WriteLine("nisam usao");
//}


//int b=0;


////while (b < 10)
////{
////    Console.WriteLine(b++);

////}

//int t = 2;
//b= 0;
//while(t==2 && b < 10)
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
//    Console.WriteLine("Unesi cijeli broj: ");
//    b= int.Parse(Console.ReadLine());
//    if(b>0 && b<= 10) 
//    {
//        break;
//    }
//    Console.WriteLine("Morate unjeti broj izmedu 1 i 10");
//}
//Console.WriteLine("uneseni broj je: {0}",b);

//b = 2;
//while (true)
//{
//    Console.WriteLine(b);
//    b += 3;
//    if (b > 97)
//    {
//        break;
//    }
//}

//int b;
//int zbroj = 0;
//b = 0;
//while (b++ <= 100)
//{
//    zbroj += b;
//}
//Console.WriteLine(zbroj);

//do
//{
//    Console.WriteLine("01 Ušao u petlju");
//} while (false);

//int b1 = 0;

//do
//{
//    Console.WriteLine("unesi Prvi broj: ");
//     b1= int.Parse(Console.ReadLine());
//    if(b1>=10 && b1 <= 20)
//    {
//        break;
//    }
//    Console.WriteLine("nisi unje trazeni broj");

//} while (true);

//int b2 = 0; 
//do
//{
//    Console.WriteLine("unesi drugi broj: ");
//    b1 = int.Parse(Console.ReadLine());
//    if (b1 >= 10 && b1 <= 20)
//    {
//        break;
//    }
//    Console.WriteLine("nisi unje trazeni broj");

//} while (true);


//int manji = b1 < b2 ? b1 : b2;
//int veci=b1>b2 ? b1 : b2;

//int i = manji;
//do
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }

//}while(++i<=veci);

//int[] niz = { 2, 3, 3, 4, 5, 5 };





//for(int i= 0; i<niz.Length; i++)
//{
//    Console.WriteLine(niz[i]);
//}

//Console.WriteLine("*******************");



//for(int i=niz.Length-1; i>=0; i--)
//{
//    Console.WriteLine(niz[i]);
//}

//Console.WriteLine("kkkk*******************");

//foreach(int k in niz)
//{
//    Console.WriteLine(k);
//}



int redaka = 5, stupaca = 5;


Console.Write("unesi broj redova: ");
redaka=int.Parse(Console.ReadLine());


Console.WriteLine("unesi broj stupaca: ");
stupaca = int.Parse(Console.ReadLine());


int[,] matrica=new int[redaka, stupaca];




for (int i = 0; i < redaka; i++)
{
    for (int j = 0; j < stupaca; j++)
    {
        Console.Write(matrica[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("***********************");



int b = 1;


//matrica[redaka -1, stupaca-1] = b++;
//matrica[redaka-1, stupaca-2] = b++;
//matrica[redaka - 1, stupaca - 3] = b++;
//matrica[redaka - 1, stupaca - 4] = b++;
//matrica[redaka - 1, stupaca - 5] = b++;

for(int i = 1; i <= stupaca; i++)
{
    matrica[redaka - 1, redaka - i] = b++;
}



for (int i = 0; i < redaka; i++)
{
    for (int j = 0; j < stupaca; j++)
    {
        Console.Write(matrica[i, j] + " ");
    }
    Console.WriteLine();

}


Console.WriteLine("***********************");


for (int i = redaka - 2; i >= 0; i--)
{
    matrica[i,0]=b++;
}



for (int i = 0; i < redaka; i++)
{
    for (int j = 0; j < stupaca; j++)
    {
        Console.Write(matrica[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("***********************");


