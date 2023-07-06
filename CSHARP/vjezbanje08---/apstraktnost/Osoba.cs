using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apstraktnost
{
    internal abstract class Osoba
    {
        public abstract void Pozdravi();

   

        public int  sifra { get; set; }
        public string Ime { get; set; }
        public string przime { get; set; }

        public override string ToString()
        {
            return Ime + " " + przime;
        }

    }
}
