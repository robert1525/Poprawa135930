using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    abstract class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected int podstawa;

        public virtual int ObliczPensje() 
        {
            return podstawa;
        }
        public Osoba(string imie, string nazwisko, int podstawa) 
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.podstawa = podstawa;
        }
        public int CompareTo(Osoba doPorownania) 
        {
            return string.Compare(nazwisko, doPorownania.nazwisko);
        }


    }
}
