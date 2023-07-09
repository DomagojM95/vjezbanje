//for(int i = 0; i < 10; i++)
//{
//    for(int j = 0; j < 10; j++)
//    {
//        Console.WriteLine("{0} ",(i+1)*(j+1));
//    }
//    Console.WriteLine();
//}


//string s;
//for(int i = 0; i < 10; i++)
//{
//    for(int j = 0; j < 10; j++)
//    {
//        var b=(i+1)*(j+1);
//        s = " " + b;
//        Console.Write("{0}",s[^4..]);
//    }
//    Console.WriteLine();
//}


//for(int i = 0; i < 10; i++)
//{
//    if (i == 3)
//    {
//        continue;
//    }
//    Console.WriteLine(i);
//}


for(int i =0; i < 5; i++)
{
    for(int j = 0; j < 5; j++)
    {
        if (j == 2)
        {
            goto label;
        }
        Console.WriteLine("i={0},j={1}",i,j);
    }
label:;
}


int[] hohheh = {234,434,5,4,3,343,2,3,2,3456,6 };

foreach(int i in hohheh)
{
    Console.Write(i+" ");
}
