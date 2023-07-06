using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profesor
{
    internal class Student:Osoba
    {
        public string  JMBAG { get; set; }

        public override string ToString()
        {
            return base.Ime +" "+Prezime+" ("+JMBAG+")";
        }
    }
}
