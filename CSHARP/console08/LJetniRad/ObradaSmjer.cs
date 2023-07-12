using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LJetniRad
{
    internal class ObradaSmjer

    {
        public  List<Smjer>Smjerovi { get;  }
        
        public ObradaSmjer() 
        {

            Smjerovi = new List<Smjer>();
            TestniPodaci();

        }
        public void PrikaziIzbornik()
        {
            Console.WriteLine("izbornik za rad s smjerovima");
            Console.WriteLine("1. pregled postojecih smjerova");
            Console.WriteLine("2. Unos novog smijera");
            Console.WriteLine("3. Promjena postojeceg smjera");
            Console.WriteLine("4. Brisanje smjera");
            Console.WriteLine("5. Povratak na glavni izbornik");

            switch(Pomocno.UcitajBrojRaspon("odaberite stavku izbornika smjera","Odabir mora biti 1-5",1,5))
            {
                case 1:
                    PrikaziSmjerove();
                    PrikaziIzbornik();
                    break;
                    case 2:
                    UnosNovogSmjera();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.WriteLine("Gotov rad s smjerovima");
                    break;

            }

        }

        private void UnosNovogSmjera()
        {
            var s = new Smjer();
            s.Sifra = Pomocno.UcitajBrojRaspon("unesite broj",
                "unos mora biti cijeli pozitivni broj");
            s.Naziv = Pomocno.UcitajString("unesite naziv smjera", "Unos obavezan");
            s.Trajanje = Pomocno.UcitajBrojRaspon("Unesi trajanje smjera u satima: ",
                "unos mora biti cijeli pozitivni broj");
            Smjerovi.Add(s);
        }

        private void PrikaziSmjerove()
        {
          foreach(Smjer smjer in Smjerovi)
            {
                Console.WriteLine(smjer.Naziv);
            }

          
        }
        private void TestniPodaci()
        {
            Smjerovi.Add(new Smjer { Naziv = "web programiranje" });
        }
    }


}
 