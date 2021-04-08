using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Zadanie2
    {
        public Zadanie2()
        {

        }

        public void ReprezentacjaLiczb()
        {
            Console.WriteLine("Podaj wartosc a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartosc b");
            int b = int.Parse(Console.ReadLine());

            string aBin = Convert.ToString(a, 2);
            string bBin = Convert.ToString(b, 2);
            string aHexNegacja = Convert.ToString(~a, 16);
            string bHexNegacja = Convert.ToString(~b, 16);
            string abHexKoniunkcja = Convert.ToString(a & b, 16);
            string abHexAlternatywa = Convert.ToString(a | b, 16);

            Console.WriteLine($"Reprezentacja pierwszej liczy w systemie binarnym: {aBin}");
            Console.WriteLine($"Reprezentacja drugiej liczy w systemie binarnym: {bBin}");
            Console.WriteLine($"Negacja drugiej liczy w systemie heksadecymalnym: {aHexNegacja}");
            Console.WriteLine($"Negacja drugiej liczy w systemie heksadecymalnym: {bHexNegacja}");
            Console.WriteLine($"Koniunkcja liczb w systemie heksadecymalnym: {abHexKoniunkcja}");
            Console.WriteLine($"Alternatywa liczb w systemie heksadecymalnym: {abHexAlternatywa}");
        }
    }
}
