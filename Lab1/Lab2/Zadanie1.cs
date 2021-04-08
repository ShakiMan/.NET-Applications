using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Zadanie1
    {
        private int wspA, wspB, wspC, delta;

        public void FunckjaKwadratowa()
        {
            Console.WriteLine("Podaj wspolczynniki funkcji kwadratowej.\nPodaj wspolczynnik 'a'.");
            wspA = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolczynnik 'b'");
            wspB = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolczynnik 'c'");
            wspC = int.Parse(Console.ReadLine());
            if (wspA == 0 && wspB == 0 && wspC == 0)
            {
                Console.WriteLine("Rownanie tozsamosciowe");
            }
            else if (wspA == 0 && wspB == 0)
            {
                Console.WriteLine("Brak rozwiazan!");
            }
            else if (wspA == 0)
            {
                Console.WriteLine("To nie jest funkcja kwadratowa.");
            }
            else
            {
                LiczDelte();
            }

        }

        private void LiczDelte()
        {
            delta = wspB * wspB - 4 * wspA * wspC;
            if (delta < 0)
            {
                Console.WriteLine("Zero rozwiazan");
            }
            else if (delta == 0)
            {
                int solution = ((-1) * wspB) / (2 * wspA);
                Console.WriteLine("Wynik tego rownania to: {0:N5}", solution);
            }
            else
            {
                double fstSolution = ((-1 * wspB) - Math.Sqrt(delta)) / (2 * wspA);
                double scdSolution = ((-1 * wspB) + Math.Sqrt(delta)) / (2 * wspA);
                Console.WriteLine($"Wyniki tego rownania to: x1 = {fstSolution:N5} oraz x2 = {scdSolution:N5}");
            }
        }
    }
}
