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
            if (Pomocno.DEV)
            {
                TestniPodaci();
            }
          
            
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
                case 3:
                    PromjenaSmjera();
                    PrikaziIzbornik();
                    break;
                case 4:
                    if (Smjerovi.Count == 0)
                    {
                        Console.WriteLine("Nema smjerova za brisanje");
                    }
                    else
                    {
                        BrisanjeSmjera();
                    }
                   
                    PrikaziIzbornik();
                    break;

                case 5:
                    Console.WriteLine("Gotov rad s smjerovima");
                    break;
            }

        }

        private void BrisanjeSmjera()
        {
            PrikaziSmjerove();
            int broj = Pomocno.UcitajBrojRaspon("Odaberi redni broj smjera za brisanje: ", "nije dobro", 1, Smjerovi.Count());
            Smjerovi.RemoveAt(broj - 1);

        }

        private void PromjenaSmjera()
        {
            PrikaziSmjerove();
            int broj = Pomocno.UcitajBrojRaspon("Odaberi redni broj smjera za obradu: ", "nije dobro", 1, Smjerovi.Count());
            var s = Smjerovi[broj - 1];

            s.Sifra = Pomocno.UcitajCijeliBroj("Unesite šifru smijera("+s.Sifra+"):",
                "Unos mora biti pozitivni cijeli  broj");
            s.Naziv = Pomocno.UcitajString("Unesite naziv smjera(" + s.Naziv + "): ", "Unos obavezan");
            s.Trajanje = Pomocno.UcitajCijeliBroj("Unesi trajanje smjera u satima("+s.Trajanje+ "): ",
                "Unos mora biti cijeli pozitivni broj");
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

        public void PrikaziSmjerove()
        {
            Console.WriteLine();
            Console.WriteLine("------Dostupni smjerovi------");
            Console.WriteLine("-----------------------");
            int b = 1;
            foreach(Smjer smjer in Smjerovi)
            {
                Console.WriteLine("\t{0}. {1}",b++,smjer.Naziv);
            }
            Console.WriteLine("-----------------------");
        }
        private void TestniPodaci()
        {
            Smjerovi.Add(new Smjer() { Naziv="web programiranje" });
            Smjerovi.Add(new Smjer() { Naziv = "Java programiranje" });
            Smjerovi.Add(new Smjer() { Naziv = "web dizajn" });

        }
    }
}
