using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profesor
{
    internal class Profesor:Osoba
    {
        public int RedniBrojZnanstvenika { get; set; }
        public override string ToString()
        {
            return base.Ime + " " + Prezime + " (" + RedniBrojZnanstvenika + ")";
        }
    }
}
