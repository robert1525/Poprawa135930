using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    class Kierownik : Osoba, INadgodziny
    {
        private int iloscPodwladnych;

        public override int ObliczPensje() 
        {
            return base.ObliczPensje() + iloscPodwladnych;
        }
        public Kierownik(string imie, string nazwisko, int podstawa, int iloscPodwladnych)
            : base(imie, nazwisko, podstawa) 
        {
            this.iloscPodwladnych = iloscPodwladnych;
        }
        public override string ToString() 
        {
            return "Kierownik: " + imie + ' ' + nazwisko + ", podstawa: " + podstawa + ", ilość podwładnych: " + iloscPodwladnych + '.';
        }
        public int DoliczNadgodziny(int nadgodziny) 
        {
            return ObliczPensje() * nadgodziny * 25;
        }

    }

}
