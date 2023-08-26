using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeDelegati
{
    internal class PrimjerKoristenje2
    {
        public PrimjerKoristenje2()
        {
            ObradaSmjer os = new();
            os.IspisSmjer(NijeBitno);
        }
        private void NijeBitno(Smjer s)
        {
            Console.WriteLine("Drugi nacin: "+ s.Naziv);
        }
    }
}
