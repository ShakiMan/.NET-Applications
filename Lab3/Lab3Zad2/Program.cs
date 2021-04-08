using System;
using static System.Console;

namespace Lab3Zad2
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
            Write("Indeks: ");
            index = int.Parse(ReadLine());
            var tuple = (name, surname, age, index);
            PrintTupleInThreeWays(tuple);
        }

        private static void PrintTupleInThreeWays((string name, string surname, int age, int index) tuple)
        {
            (string name, string surname, int age, int index) = tuple;
            WriteLine($"{name} {surname} {age} indeks: {index}");
            WriteLine($"{tuple.Item1} {tuple.Item2} {tuple.Item3} indeks: {tuple.Item4}");
            WriteLine($"{tuple.name} {tuple.surname} {tuple.age} indeks: {tuple.index}");
        }
    }
}
