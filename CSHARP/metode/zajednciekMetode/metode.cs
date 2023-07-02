﻿

using System.Data;

namespace zajednickeMetod
{
    public class metode
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
            Console.WriteLine(poruka);
        }


        /// <summary>
        /// zbrajanje brojeva
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int izracunaj(int a, int b)
        {
            return a + b;
        }



        public static void ispisiMatricu(int[,] matrica)
        {
            for(int i = 0; i < matrica.GetLength(0); i++)
            {
                for(int j = 0; j < matrica.GetLength(1); j++)
                {
                    Console.Write(matrica[i,j]+ " ");
                }
                Console.WriteLine();
            }

            string s = "";
            for(int i=0; i< (matrica.GetLength(1)*2)-1; i++)
            {
                s += "*";
            }
            Console.WriteLine(s);
        }


        public static int faktorijel(int broj)
        {
            if (broj == 1)
            {
                return broj;
            }
            return broj * faktorijel(broj - 1);
        }

    }
}

