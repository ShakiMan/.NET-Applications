using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Zad1
{
    abstract class Pojazd
    {
        public string Kolor { get; set; }
        public string Marka { get; set; }

        public Pojazd(string kolor, string marka)
        {
            Kolor = kolor;
            Marka = marka;
        }

        virtual public void PoruszajSie(int x)
        {
            for (int i = 0; i < x; i++) 
                WriteLine(". . . . . .");
        }

        public override string ToString()
        {
            return $"Pojazd: kolor - {Kolor}, marka - {Marka}";
        }
    }
}
