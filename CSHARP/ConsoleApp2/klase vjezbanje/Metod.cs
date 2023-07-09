using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klase_vjezbanje
{
    internal class Metod
    {
        public Metod()
        {
            Console.WriteLine("Ispisi iz konstruktora");
        }

        public Metod(int i)
        {
            Console.WriteLine("ispiši iz konstruktora primio sam {0}",i);
        }

    }
}
