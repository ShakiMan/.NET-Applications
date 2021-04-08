using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lab2
{
    class Zadanie3
    {
        private int n, input;
        private int najwieksza = - int.MaxValue;
        private int prawieNajwieksza = -int.MaxValue;
        private bool brakRozwiazania = true;

        public void SzukajPrawieNajwiekszej()
        {
            Console.WriteLine("Podaj liczbę 'n'.");
            try
            {
                n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Podaj {n} liczb i wcisnij Enter:");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            for (int i=0; i<n; i++)
            {
                char znak;
                string liczby = "";

                do
                {
                    znak = Convert.ToChar(Console.Read());
                    if (!Char.IsWhiteSpace(znak))
                    {
                        liczby += znak;
                    }
                } 
                while (!Char.IsWhiteSpace(znak));
                input = int.Parse(liczby);
                if (i != 0 && brakRozwiazania)
                {
                    brakRozwiazania = najwieksza == prawieNajwieksza;
                }
                if(input > najwieksza)
                {
                    prawieNajwieksza = najwieksza;
                    najwieksza = input;
                }
                else if (input > prawieNajwieksza && input != najwieksza)
                {
                    prawieNajwieksza = input;
                }
            }
            if(prawieNajwieksza == -int.MaxValue)
            {
                Console.WriteLine("Brak rozwiazania.");
            }
            else if (brakRozwiazania)
            {
                Console.WriteLine("Brak rozwiazania.");
            }
            else
            {
                Console.WriteLine($"Szukana liczba to {prawieNajwieksza}");
            }
        }
    }
}
