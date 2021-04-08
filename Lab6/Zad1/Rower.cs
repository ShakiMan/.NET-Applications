using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Zad1
{
    class Rower : Pojazd
    {
        public string TypRoweru { get; set; }
        public bool CzyKoszyk { get; set; }

        public Rower(string kolor, string marka, string typRoweru, bool czyKoszyk) : base(kolor, marka)
        {
            TypRoweru = typRoweru;
            CzyKoszyk = czyKoszyk;
        }

        public void ZrzućŁańuch()
        {
            WriteLine("*Trzask*... Łańcuch spadł...");
        }

        public override void PoruszajSie(int x)
        {
            for (int i = 0; i < x; i++)
            {
                WriteLine(". . . . . .");
                WriteLine("~Odgłosy pedałowania~");
                WriteLine(". . . . . .");
            }
        }

        public override string ToString()
        {
            return $"Rower: kolor - {Kolor}, marka - {Marka}, typ roweru - {TypRoweru}, czy posiada koszyk - {CzyKoszyk}";
        }
    }
}
