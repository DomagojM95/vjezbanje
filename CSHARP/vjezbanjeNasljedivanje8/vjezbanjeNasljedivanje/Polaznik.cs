using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbanjeNasljedivanje
{
    internal class Polaznik :Osoba
    {
        public string BrojUgovora { get; set; }

        public override string ToString()
        {
            //base.uvjet = true;
            return base.ToString() + " " + BrojUgovora;
        }


    }
}
