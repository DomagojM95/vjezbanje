using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbanje08
{
    public class Metoda
    {
        public Metoda() 
        {
            Console.WriteLine("ispisi iz konstruktora");
        }

        public Metoda(int i) 
        {
            Console.WriteLine("ispisi iz konstruktora, primio sam {0}",i);
        }

    }
}
