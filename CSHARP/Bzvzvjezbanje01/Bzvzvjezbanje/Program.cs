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



Console.Write("Upiši svoje dragocjeno ime: ");
string ime = Console.ReadLine();
string s;
string t;


for(int i = 0; i < 9; i++)
{
    if(i == 0| i==2 | i == 4 |i== 6 | i == 8)
    {
        Console.WriteLine("--------------------------------");
    }
    else if(i==1)
    {
        Console.WriteLine(": : : TABLICA MNOZENJA : : :");
    }
    else if( i==3) 
    {
        Console.Write(" * |");
        for(int k=1; k<10; k++)
        {
            Console.Write(" "+k);
        }
        Console.WriteLine();
    }
    else if(i==5)
    {
        for (int l=1; l<10; l++)
        {
            Console.Write(" "+l+" |");
            for(int r=1; r<10; r++)
            {
                s = "   " + l * r;
                Console.Write(s[^3..]);
            }
            Console.WriteLine();
        }
    }
    else if(i==7)
    {
        t = ": : : : : : : : : : : : " + "by " + ime;
        Console.WriteLine(t[^31..]);
    }
}