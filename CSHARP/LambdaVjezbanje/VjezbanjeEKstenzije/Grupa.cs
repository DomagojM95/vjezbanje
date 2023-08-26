using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeEKstenzije
{
    internal class Grupa:Entitet,ISucelje
    {
        public Smjer? Smjer { get; set; }

        public void Posao()
        {
            Console.WriteLine("Radim posao na grupi");
        }
    }
}
