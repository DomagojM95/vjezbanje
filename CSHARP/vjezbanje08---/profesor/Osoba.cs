﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profesor
{
    internal class Osoba
    {

        public string Ime { get; set; }
        public string Prezime { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }

    }
}

