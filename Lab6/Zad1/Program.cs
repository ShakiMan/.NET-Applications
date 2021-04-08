using System;
using static System.Console;

//Ścigała Radosław, 246997

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInfo();

            Pojazd[] arr =
            {
                new Rower("Czarny", "Romet", "Górski", false),
                new SamochódOsobowy("Czerwony", "Skoda", "Diesel", 2400, "Combi", 5),
                new SamochódOsobowy("Czarny", "Audi", "Benzyna", 3000, "Sedan", 5),
                new SamochódCiężarowy("Biały", "Mercedes", "Diesel", 5000, 3000, "Chłodnia", 6500),
                new Rower("Żółty", "Trek", "Miejski", true),
                new SamochódCiężarowy("Czarny", "MAN", "Diesel", 6500, 5000, "Cysterna", 4000),
                new Rower("Niebieski", "Romet", "Szosowy", false),
                new SamochódOsobowy("Zielony", "BMW", "Benzyna", 1150, "Coupe", 5)
            };
            int nośność = 0;
            nośność = PoliczNośność(arr);
            WriteLine($"\nNośność dla wszystkich pojazdów wynosi: {nośność}");
        }

        public static int PoliczNośność(Pojazd[] arr)
        {
            int nośność = 0;
            foreach (Pojazd pojazd in arr)
            {
                WriteLine(pojazd);
                SamochódCiężarowy auto = pojazd as SamochódCiężarowy;
                if (auto is SamochódCiężarowy)
                {
                    nośność += auto.Nośność;                    
                }
            }
            return nośność;
        }

        static void PrintInfo()
        {
            WriteLine("Ścigała Radosław, 246997");
            WriteLine($"{Environment.MachineName}\n");
        }
    }
}
