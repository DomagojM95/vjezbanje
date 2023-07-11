using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LJetniRad
{
    internal class Izbornik
    {
        public Izbornik() 
        {
            PozdravnaPoruka();
            PrikaziIzbornik();

        }
        private void PozdravnaPoruka()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("******Edunova Console app v 1.0******");
            Console.WriteLine("*************************************");
            
        }
        private void PrikaziIzbornik() 
        {
            Console.WriteLine("Glavni izbornik");
            Console.WriteLine("1. Smjerovi");
            Console.WriteLine("2. Polaznici");
            Console.WriteLine("3. Grupe");
            Console.WriteLine("4. Izlaz iz grupe");
           
            switch(Pomocno.UcitajBrojRaspon("odaberite stavku izborinika", "Odabir mora biti 1-4", 1, 4))
            {
                case 1:
                    Console.WriteLine("Rad sa smjerovima");
                    PrikaziIzbornik();
                    break;
                case 2:
                    Console.WriteLine("rad s polaznicima");
                    PrikaziIzbornik();
                    break;
                case 3:
                    Console.WriteLine("rad s grupama");
                    PrikaziIzbornik();
                    break;
                case 4:
                    Console.WriteLine("hvala na koristenju, dovidenja");
                    break;
            }
        }
    }
}
