
using System.Data;

namespace bzvzvvjezbanej02
{
    internal class Metode
    {

        public void ispis()
        {
            Console.WriteLine("hello");
        }

        public void ispis(string poruka)
        {
            Console.WriteLine(poruka);
        }

        public void ispis(int poruka)
        {

        }

        public static int izracunaj(int a, int b)
        {
            return a+b;
        }


        public static void IspisiMatricu(int[,]matrica)
        {
            for(int i = 0; i < matrica.GetLength(0); i++)
            {
                for(int j = 0;j< matrica.GetLength(1); j++)
                {
                    Console.Write(matrica[i,j]+" ");

                }
                Console.WriteLine();
            }
            string s = "";
            for(int i = 0; i < matrica.GetLength(1) * 2; i++)
            {
                s += "*";
            }
            Console.WriteLine(s);
        }
    }
}
