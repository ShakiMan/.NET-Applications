using System;
using static System.Console;

namespace Lab3Zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, surname;
            int age, index;

            WriteLine("Podaj informacje o sobie.");
            Write("Imię: ");
            name = ReadLine();
            Write("Nazwisko: ");
            surname = ReadLine();
            Write("Wiek: ");
            age = int.Parse(ReadLine());
            Write("Płaca: ");
            index = int.Parse(ReadLine());

            var anonim = new { nameA = name, surnameA = surname, ageA = age, indexA = index };
            PrintAnoniumusType(anonim);
        }

        private static void PrintAnoniumusType(dynamic anonim)
        {
            WriteLine($"{anonim.nameA} {anonim.surnameA} {anonim.ageA} indeks: {anonim.indexA}");
        }
    }
}
