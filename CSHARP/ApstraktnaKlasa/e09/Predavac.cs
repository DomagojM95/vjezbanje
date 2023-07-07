using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e09
{
    internal class Predavac : Osoba
    {

        public int  Goidne { get; set; }
        public override void Pozdravi()
        {
            Console.WriteLine(Goidne>124?"Dobar dan punoljetni":"Dobar dan mladicu");

        }
    }
}
