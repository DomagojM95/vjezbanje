using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apstraktnost;

namespace apstraktnost
{
    internal class Polaznik : Osoba
    {
        public string  BrojUgovora { get; set; }
        public string Spol { get; set; }    

        public override void Pozdravi()
        {
          Console.WriteLine((Spol.Equals("ženski") ? "Dobar dan gospodo" : "Dobar dan gospodine")+" "+ToString());
           
        }
    }
}


