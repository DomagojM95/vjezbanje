using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LjetniRad
{
    internal class ObradaGrupa
    { 
        private List<Grupa> Grupe;
        private Izbornik Izbornik;
    
        public ObradaGrupa()
        {
            Grupe=new List<Grupa>();
        }

        public ObradaGrupa(Izbornik izbornik):this() 
        {
            this.Izbornik=izbornik;
        }
        public void PrikaziIzbornik()
        {
            Console.WriteLine("izbornik za rad s grupama");
            Console.WriteLine("1. Pregled postojecih grupa");
            Console.WriteLine("2. Unos nove grupe");
            Console.WriteLine("3. Promjena postojece grupe");
            Console.WriteLine("4. Brisanje grupe");
            Console.WriteLine("5. Povratak na glavni izbornik");
            switch (Pomocno.UcitajBrojRaspon("Odaberite stavku izbornika smjera: ",
                "Odabir mora biti od 1 do 5", 1, 5))
            {
                case 1:
                    PrikaziGrupe();
                    PrikaziIzbornik();
                    break;
                    
                case 2:
                    UnosNoveGrupe();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.WriteLine("Gorov rad s grupama");
                    break;
            }

        }

        private void PrikaziGrupe()
        {
            foreach(Grupa grupa in Grupe)
            {
                Console.WriteLine("\t{0} ({1})",grupa.Smjer.Naziv);
                foreach(Polaznik polaznik in grupa.Poalznici)
                {
                    Console.WriteLine("\t\t{0}",polaznik);
                }
            }
        }

        private void UnosNoveGrupe()
        {
            var g=new Grupa();
            g.Sifra = Pomocno.UcitajCijeliBroj("Unesite šifru grupe(" + g.Sifra + "):",
                "Unos mora biti pozitivni cijeli  broj");
            g.Naziv = Pomocno.UcitajString("Unesite naziv grupe(" + g.Naziv + "): ", "Unos obavezan");
            g.Smjer = UcitajSmjer();
            g.Poalznici = UctiajPolaznike();

            Grupe.Add(g);
        }

        private List<Polaznik> UctiajPolaznike()
        {
            List<Polaznik> polaznici = new List<Polaznik>();

            while(Pomocno.UcitajCijeliBroj("1 za dodavanje poalznika", "Greška") == 1)
            {
                polaznici.Add(UcitajPoalznika());
            }

            return polaznici;
        }

        private Polaznik UcitajPoalznika()
        {
            Izbornik.ObradaPolaznik.PregledPoalznika();
            int broj = Pomocno.UcitajBrojRaspon("Odaberi redni broj polaznika za postavljanje na grupu: "
                , "nije dobro", 1, Izbornik.ObradaPolaznik.Polaznici.Count());
            return Izbornik.ObradaPolaznik.Polaznici[broj - 1];
        }

        private Smjer UcitajSmjer()
        {
            Izbornik.ObradaSmjer.PrikaziSmjerove();
            int broj = Pomocno.UcitajBrojRaspon("Odaberi redni broj smjera za postavljanje na grupu: "
                , "nije dobro", 1, Izbornik.ObradaSmjer.Smjerovi.Count());
            return Izbornik.ObradaSmjer.Smjerovi[broj-1];

        }
    }
}
