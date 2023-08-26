using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeDelegati
{
    internal class PrimjerKroistenje1
    {

        public PrimjerKroistenje1()
        {
            ObradaSmjer os=new ObradaSmjer();
            os.IspisSmjer(MojIpisUOvojKlasi);
        }

        private void MojIpisUOvojKlasi(Smjer s)
        {
            Console.WriteLine(s.Naziv);
        }

    }
}
 