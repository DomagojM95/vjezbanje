﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    internal class Polaznik : Osoba
    {
        public override string Pozdravi()
        {
            return "dobar dan polaznice" + Ime;
        }
    }
}
