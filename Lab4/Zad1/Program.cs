using System;
using static System.Console;

//Radosław Ścigała, 246997

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            (int first, int second) = GetFromConsoleXY("Enter the first number:", "Enter the second number:");
            WriteLine($"\nNumbers from method: {first}, {second}\n\n");
            GetFromConsoleXY2("Enter the first number:", "Enter the second number:", out int first2, out int second2);
            WriteLine($"\nNumbers from void method: {first2}, {second2}");
        }

        static (int, int) GetFromConsoleXY(string line1, string line2)
        {
#if (DEBUG)
            WriteLine("Using method returning tuple.");
#endif
            WriteLine(line1);
            int firstNumber = int.Parse(ReadLine());
            WriteLine(line2);
            int secondNumber = int.Parse(ReadLine());
            return (firstNumber, secondNumber);
        }

        static void GetFromConsoleXY2(string line1, string line2, out int first, out int second)
        {
#if (DEBUG)
            WriteLine("Using void method.");
#endif
            WriteLine(line1);
            first = int.Parse(ReadLine());
            WriteLine(line2);
            second = int.Parse(ReadLine());
        }
    }
}
