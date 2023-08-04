using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LjetniRad
{
    internal class ObradaPolaznik
    {
        public List<Polaznik> Polaznici { get; }


        public ObradaPolaznik() 
        {
            Polaznici=new List<Polaznik>();
        }
        public void PrikaziIzbornik()
        {
            Console.WriteLine("izbornik za rad s polaznicima");
            Console.WriteLine("1. Pregled postojecih polaznika");
            Console.WriteLine("2. Unos novog polaznika");
            Console.WriteLine("3. Promjena postojeceg polaznika");
            Console.WriteLine("4. Brisanje polaznika");
            Console.WriteLine("5. Povratak na glavni izbornik");

            switch (Pomocno.UcitajBrojRaspon("Odaberite stavku izbornika polaznik: ",
                "Odabir mora biti od 1 do 5", 1, 5))
            {
                case 1:
                    PregledPoalznika();
                    PrikaziIzbornik();
                    break;
                    case 2:
                    UcitajPolaznika();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.WriteLine("Gotov rad s polaznicima");
                    break;
            }
        }

        private void PregledPoalznika()
        {
            foreach(Polaznik polaznik in  Polaznici)
            {
                Console.WriteLine(polaznik);
            }
        }

        private void UcitajPolaznika()
        {
            var p = new Polaznik();
            p.Ime = Pomocno.UcitajString("Unesi ime polaznika", "Ime obavezno");
            p.Prezime = Pomocno.UcitajString("Unesi prezime poalznika", "prezime obavezno");
            Polaznici.Add(p);
        }
    }
    
}
