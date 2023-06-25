// deset puta ispiši   Osijek


//Console.WriteLine("osijek");


//for (Od kuda;do kuda;korak)

Console.WriteLine("1. *******");

for(int i = 0; i < 10; i = i + 1)
{
    Console.WriteLine("osijek");
}

Console.WriteLine("2.*********");


int j= 0;

for(j = 10; j>0; j--)
{
    Console.WriteLine("edunova");
}



Console.WriteLine("3. ********");

for(int i = 0; i < 10; i = i + 2)
{
    Console.WriteLine("csharp");
}

Console.WriteLine("4. *******");

for(int i =0;i<10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("5.*******0");

for(int i=0; i < 10; i++)
{
    Console.WriteLine(i+1);
}


// ne koristiti 

Console.WriteLine("6.*********");

//for(int i =1; 1<= 10; i++)
//{
//    Console.WriteLine(i);
//}


Console.WriteLine("7.**********");
// zbroj prvih 100 brojeva

int zbroj = 0;
for(int i=1; i<= 100; i++)
{
    Console.WriteLine(i);
    zbroj += i;
    Console.WriteLine(zbroj);
}

Console.WriteLine("8.******");

for(int i=1; i < 57; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("9.******");

zbroj = 0; 

for(int i =2; i<=18; i++)
{
    if (i % 2 == 0)
    {
        zbroj += i;
    }
}
Console.WriteLine(zbroj);

int[] niz = { 7, 8, 9, 1, 12, 76, 8, 8, 45 };


Console.WriteLine("10.*******");

for(int i =0; i<niz.Length; i++)
{
    Console.WriteLine(niz[i]);
}

Console.WriteLine("11.******");
//Console.Write("Unesi koliko brojeva provjeravas: ");
// int brojeva= int.Parse(Console.ReadLine());
//int broj;
//int najveci = int.MinValue;
//for(int i=0; i< brojeva; i++)
//{
//    Console.Write("unesi {0}. broj:  ",i+1);
//    broj= int.Parse(Console.ReadLine());

//    if(broj> najveci)
//    {
//        najveci= broj;
//    }
//}

//Console.WriteLine("najveci broj je {0}", najveci);




Console.WriteLine("12.********");

//for(; ; )
//{
//    Console.WriteLine(new Random().NextDouble());
//    break;
//}

for(int i=0; i < 10; i++)
{
    if (i == 3)
    {
        break;
    }
    Console.WriteLine(i);
}


Console.WriteLine("13.*******");

for(int i=0; i < 10; i++)
{
    if(i==2 || i == 5)
    {
        continue;
    }
    Console.WriteLine(i);
}

Console.WriteLine("14.******");

string s;

for(int i=1; i<=10; i++)
{
    for (int k = 1; k <= 10; k++) 
    {
        s = "   " + i * k;
        Console.Write(s[^4..]);
    }
    Console.WriteLine();
}


//Console.WriteLine("15.********");

//for (int i = 0; i < 10; i++)
//{
//    for (int k = 0; k <= 10; k++) ;
//    {
//        goto labela;
//    }
//}

//labela;

// 9 različitih načina zbaranja prvih 100 brojeva

//int i, s=0; for(i=1;i<=100;i++) s+=i;

// int i, s; for(i=1, s=0;i<=100; s+=i, i++);
//
// int i=1, s=0; for( ; i<=100; i++){ s+=i; }
//
//		 int i, s=0; for(i=1; ; i++){ if(i<=100) s+=i; else break;}
//
//		 int i, s=0; for(i=1;i<=100;){ s+=i; i++;}
//
//		 int i, s=0; for(i=1; ; ){ if(i<=100) {s+=i; i++;} else break;}
//
//		 int i=1, s=0; for( ; i<=100 ; ){ s+=i; i++;}
//
//		  int i=1, s=0; for( ; ; i++){if(i<=100)  s+=i; else break;}
//
//		 int i=1, s=0; for( ;  ; ){if(i<=100) {s+=i; i++;} else break;} 
//		


// 1. zadatak
// Korisnik unosi dva cijela broja
// Program ispisuje 
// zbroj svih parnih brojeva
// između dva unesena broja



// U for petlju se ne mora ući

int t = 100;

for (int i = 0; i > t; i++)
{
    Console.WriteLine("Ušao u petlju");
}



// 2. zadatak
// Program ispisuje brojeve od 100 do 1
// u istom redu odvojeno zarezom
