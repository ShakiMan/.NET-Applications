using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Zad1
{
    abstract class Samochód : Pojazd
    {
        public string RodzajPaliwa { get; set; }
        public int Długość { get; set; }


        public Samochód(string kolor, string marka, string rodzajPaliwa, int nośność) : base(kolor, marka)
        {
            RodzajPaliwa = rodzajPaliwa;
            Długość = nośność;
        }

        public void ZamontujLPG()
        {
            if (RodzajPaliwa == "Benzyna")
                RodzajPaliwa += "+LPG";
            else
                WriteLine("Nie można zamontować LPG");
        }

        public override void PoruszajSie(int x)
        {
            for (int i = 0; i < x; i++)
            {
                WriteLine(". . . . . .");
                WriteLine("Brum brum...");
                WriteLine(". . . . . .");
            }
        }

        public override string ToString()
        {
            return $"Samochód: kolor - {Kolor}, marka - {Marka}, rodzaj paliwa - {RodzajPaliwa}, długość - {Długość}";
        }
    }
}
