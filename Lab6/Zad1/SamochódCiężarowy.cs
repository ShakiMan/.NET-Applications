using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Zad1
{
    class SamochódCiężarowy : Samochód
    {
        public int Ładowność { get; set; }
        public string RodzajNaczepy { get; set; }
        public int MocSilnika { get; set; } = 100;
        public int Nośność { get; set; }

        public SamochódCiężarowy(string kolor, string marka, string rodzajPaliwa, int długość, int ładowność, string rodzajNaczepy, int nośnosć) 
            : base(kolor, marka, rodzajPaliwa, długość)
        {
            Ładowność = ładowność;
            RodzajNaczepy = rodzajNaczepy;
            Nośność = nośnosć;
        }

        public void UlepszSilnik(int konieMechaniczne)
        {
            MocSilnika += konieMechaniczne;
        }

        public override string ToString()
        {
            return $"Samochód ciężarowy: kolor - {Kolor}, marka - {Marka}, rodzaj paliwa - {RodzajPaliwa}, długość - {Długość}," +
                $" ładowność - {Ładowność}, rodzaj naczepy - {RodzajNaczepy}, moc silnika - {MocSilnika} KM, nośnosć - {Nośność}";
        }
    }
}
