using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klase_vjezbanje
{
    internal class Mjesto
    {
        public string Naziv { get; set; }
        public int BrojStanovnika { get; set; }

        public Zupanija zupanija { get; set; }
    }
}

