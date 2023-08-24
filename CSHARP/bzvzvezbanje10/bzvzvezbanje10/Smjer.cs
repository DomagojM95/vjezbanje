using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace bzvzvezbanje10
{
    internal class Smjer
    {
        public int Sifra { get; set; }
        public String? Naziv { get; set; }

        public override string ToString()
        {
            return Naziv==null?"":Naziv;
        }


    }
}


