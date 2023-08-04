using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LjetniRad
{
    internal class ObradaSmjer
    {

        public List<Smjer> Smjerovi { get; }




        public ObradaSmjer() 
        {
            Smjerovi = new List<Smjer>();
            TestniPodaci();
            
            
        } 
        public void PrikaziIzbornik()
        {
            Console.WriteLine("izbornik za rad s smjerovima");
            Console.WriteLine("1. Pregled postojecih smjerova");
            Console.WriteLine("2. Unos novog smjera");
            Console.WriteLine("3. Promjena postojeceg smjera");
            Console.WriteLine("4. Brisanje smjera");
            Console.WriteLine("5. Povratak na glavni izbornik");

            switch(Pomocno.UcitajBrojRaspon("Odaberite stavku izbornika smjera: ",
                "Odabir mora biti od 1 do 5", 1, 5))
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
            s.Sifra = Pomocno.UcitajCijeliBroj("Unesite šifru smijera",
                "Unos mora biti pozitivni cijeli  broj");
            s.Naziv = Pomocno.UcitajString("Unesite naziv smjera", "Unos obavezan");
            s.Trajanje = Pomocno.UcitajCijeliBroj("Unesi trajanje smjera u satima: ",
                "Unos mora biti cijeli pozitivni broj");
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
            Smjerovi.Add(new Smjer() { Naziv="web programiranje" });
        }
    }
}
