using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    class Pracownik : Osoba, INadgodziny, ICloneable
    {
        private int starz;

        public override int ObliczPensje() 
        {
            return base.ObliczPensje() + starz * 100;
        }
        public Pracownik(string imie, string nazwisko, int podstawa, int starz)
            : base(imie, nazwisko, podstawa) 
        {
            this.starz = starz;
        }
        public override string ToString() 
        {
            return "Pracownik: " + imie + ' ' + nazwisko + ", podstawa: " + podstawa + ", starz: " + starz + '.';
        }
        public int DoliczNadgodziny(int nadgodziny) 
        {
            return ObliczPensje() + nadgodziny * 15;
        }
        public object Clone() 
        {
            return MemberwiseClone();
        }
               
    }
}
