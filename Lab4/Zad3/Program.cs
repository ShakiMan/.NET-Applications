using System;
using static System.Console;

//Radosław Ścigała, 246997

namespace Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            (int evenIntegers, int positiveRealNumbers, int positiveRealNumbersFloat, int stringsLongerThan5Chars, int otherTypes) =
                CountMyTypes(5.5, 5.0, 3, 2.4f, -2, -4.4, 4, "Radosław", "Ścigała", true, false, ".NET", 17.7f);
            var tuple = (evenIntegers, positiveRealNumbers, positiveRealNumbersFloat, stringsLongerThan5Chars, otherTypes);
            PrintCountingTypesResult(tuple);
        }

        static void PrintCountingTypesResult((int evenIntegers, int positiveRealNumbers, int positiveRealNumbersFloat, int stringsLongerThan5Chars, int otherTypes) tuple)
        {
            WriteLine($"Even integers -  {tuple.evenIntegers}");
            WriteLine($"Positive real numbers -  {tuple.positiveRealNumbers}");
            WriteLine($"Positive real numbers (float) -  {tuple.positiveRealNumbersFloat}");
            WriteLine($"Strings longer than 5 chars -  {tuple.stringsLongerThan5Chars}");
            WriteLine($"Other types -  {tuple.otherTypes}");
        }

        static (int, int, int, int, int) CountMyTypes(params dynamic[] tab)
        {
            int evenIntegers = 0;
            int positiveRealNumbers = 0;
            int positiveRealNumbersFloat = 0;
            int stringsLongerThan5Chars = 0;
            int otherTypes = 0;

            foreach (dynamic obj in tab)
            {
                switch (obj)
                {
                    case int number when number % 2 == 0:
                        evenIntegers++;
                        break;
                    case double number when number > 0:
                        positiveRealNumbers++;
                        break;
                    case float number when number > 0:
                        positiveRealNumbersFloat++;
                        break;
                    case string @string when @string.Length >= 5:
                        stringsLongerThan5Chars++;
                        break;
                    default:
                        otherTypes++;
                        break;
                }
            }
            return (evenIntegers, positiveRealNumbers, positiveRealNumbersFloat, stringsLongerThan5Chars, otherTypes);
        }
    }
}
