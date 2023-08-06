using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LjetniRad
{
    internal class Izbornik
    {
        public ObradaSmjer ObradaSmjer { get; }
        public ObradaPolaznik ObradaPolaznik { get; }
        private ObradaGrupa ObradaGrupa;
        public Izbornik() 
        {
            ObradaSmjer = new ObradaSmjer();
            ObradaPolaznik= new ObradaPolaznik();
            ObradaGrupa= new ObradaGrupa(this);
            PozdravnaPoruka();
            PrikaziIzbornik();
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("********************************");
            Console.WriteLine("****Edunova Console APP v1.0****");
            Console.WriteLine("********************************");
            
        }

        private void PrikaziIzbornik()
        {
            Console.WriteLine("Glavni izbornik");
            Console.WriteLine("1. Smjerovi");
            Console.WriteLine("2. Polaznici");
            Console.WriteLine("3. Grupe");
            Console.WriteLine("4.Izlaz iz programa");

            switch(Pomocno.UcitajBrojRaspon("odaberite stavku izbornika: ",
                "Odabir mora biti od 1 do 4", 1, 4))
            {
                case 1:
                    ObradaSmjer.PrikaziIzbornik();
                    Console.WriteLine("Rad s smjerovima");
                    PrikaziIzbornik();
                    break;
                case 2:
                    ObradaPolaznik.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 3:
                    ObradaGrupa.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 4:
                    Console.WriteLine("hvala na koristenju dovidenja");
                    break;

            }
        }
      
    }
}
