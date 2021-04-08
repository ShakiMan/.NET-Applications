using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Zad1
{
    class SamochódOsobowy : Samochód
    {
        public string TypNadwozia { get; set; }
        public int IlośćMiejsc { get; set; }
        public bool BagażnikDachowy { get; set; }

        public SamochódOsobowy(string kolor, string marka, string rodzajPaliwa, int długość, string typNadwozia, int ilośćMiejsc)
            : base(kolor, marka, rodzajPaliwa, długość)
        {
            TypNadwozia = typNadwozia;
            IlośćMiejsc = ilośćMiejsc;
        }

        public void ZamontujBagażnikDachowy()
        {
            BagażnikDachowy = true;
        }

        public override string ToString()
        {
            return $"Samochód osobowy: kolor - {Kolor}, marka - {Marka}, rodzaj paliwa - {RodzajPaliwa}," +
                $" Długość - {Długość}, typ nadwozia - {TypNadwozia}, ilość miejsc - {IlośćMiejsc}, czy posiada bagażnik dachowy - {BagażnikDachowy}";
        }
    }
}
