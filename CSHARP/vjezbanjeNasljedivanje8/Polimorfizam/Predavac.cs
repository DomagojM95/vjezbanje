﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    internal class Predavac : Osoba
    {
        public override string Pozdravi()
        {
            return "Dobar dan predavacu" + Ime;
        }
    }
}
