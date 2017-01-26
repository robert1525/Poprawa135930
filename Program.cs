using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<Osoba> pracownicy = new List<Osoba>();
            pracownicy.Add(new Pracownik("Jan", "Kowalski", 1200, 5));
            pracownicy.Add(new Pracownik("Stefan", "Iksiński", 1300, 6));
            pracownicy.Add(new Pracownik("Robert", "Gruda", 1100, 7));
            pracownicy.Add(new Pracownik("Jakub", "Pakusinski", 900, 2));
            pracownicy.Add(new Pracownik("Pawel", "Konofalski", 1000, 5));
            pracownicy.Add(new Kierownik("Jakub", "Ambroziak", 1100, 2));
            pracownicy.Add(new Kierownik("Mateusz", "Abramowicz", 1700, 8));
            pracownicy.Add(new Kierownik("Dawid", "Kaliszewski", 1300, 1));
            pracownicy.Add(new Kierownik("Sebastian", "Krajewski", 1700, 9));
            pracownicy.Add(new Kierownik("Paweł", "Kowalski", 1400, 8));

            for (int i = 0; i < pracownicy.Count; i++)
                Console.WriteLine("[{0}] Pensja: {1}", i, pracownicy[i].ObliczPensje());

            pracownicy.RemoveAt(6);
            pracownicy.RemoveAt(2);

            Console.WriteLine();
            foreach (var p in pracownicy)
                Console.WriteLine(p);

            Console.WriteLine();
            for (int i = 0; i < pracownicy.Count; i++)
                Console.WriteLine("[{0}] Pensja: {1}", i, ((INadgodziny)pracownicy[i]).DoliczNadgodziny(5));

            Console.WriteLine();
            pracownicy.Sort();
            foreach (var p in pracownicy)
                Console.WriteLine(p);

            Console.WriteLine();
            pracownicy.Add((Osoba)(((Pracownik)pracownicy[0]).Clone()));
            Console.WriteLine(pracownicy[0]);
            Console.WriteLine(pracownicy[pracownicy.Count - 1]);

            //Koniec
            Console.ReadKey();            
        }
    }
}
