using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezbanje07
{
    internal class Osoba
    {
        //public string ime;
        //    internal string prezime;
        //int godine;

        public Osoba()
        {
            Console.WriteLine("konstruktor klase osoba");
        }

        public Osoba(string name)
        {
            Console.WriteLine(name);
        }
    } 
}
