using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LJetniRad
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
            Console.WriteLine("izbornik za rad s polaznika");
            Console.WriteLine("1. pregled postojecih polaznika");
            Console.WriteLine("2. Unos novog polaznika");
            Console.WriteLine("3. Promjena postojeceg polaznika");
            Console.WriteLine("4. Brisanje polaznika");
            Console.WriteLine("5. Povratak na glavni izbornik");
            switch (Pomocno.UcitajBrojRaspon("odaberite stavku izbornika polaznika", "Odabir mora biti 1-5", 1, 5))
            {
                case 1:
                    PregledPolaznika();
                    PrikaziIzbornik();
                    break;
                    case 2:
                    UcitajPolaznika();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.WriteLine("gotov rad s polaznicima");
                    break;
            }
        }

        private void PregledPolaznika()
        {
            foreach (Polaznik polaznik in Polaznici)
            {
                Console.WriteLine(polaznik);
            }
        }

        private void UcitajPolaznika()
        {
            var p= new Polaznik();
            p.Ime = Pomocno.UcitajString("unesi ime polaznika", "ime obavezno");
            p.Prezime = Pomocno.UcitajString("unesi prezime polznika","prezime obavezbo");
            Polaznici.Add(p); 
        }
    }
}
