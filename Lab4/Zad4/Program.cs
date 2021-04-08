using System;
using static System.Console;

//Radosław Ścigała, 246997

namespace Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            (int evenIntegers, int positiveRealNumbers, int positiveRealNumbersFloat, int stringsLongerThan5Chars, int otherTypes) = CountMyTypes(5.5, 5.0, 3, -2, -4.4, 4, "Radosław", "Ścigała", true, false, ".NET");
            var tuple = (evenIntegers, positiveRealNumbers, positiveRealNumbersFloat, stringsLongerThan5Chars, otherTypes);
            WriteLine("\n\n");
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
#if (DEBUG)
                        WriteLine(Convert.ToString(obj) + " - Parameter qualified as even integer.");
#endif
                        evenIntegers++;
                        break;
                    case double number when number > 0:
#if (DEBUG)
                        WriteLine(Convert.ToString(obj) + " - Parameter qualified as positive real number.");
#endif
                        positiveRealNumbers++;
                        break;
                    case float number when number > 0:
#if (DEBUG)
                        WriteLine(Convert.ToString(obj) + " - Parameter qualified as positive real number (float).");
#endif
                        positiveRealNumbersFloat++;
                        break;
                    case string @string when @string.Length >= 5:
#if (DEBUG)
                        WriteLine(Convert.ToString(obj) + " - Parameter qualified as string longer than 5 chars.");
#endif
                        stringsLongerThan5Chars++;
                        break;
                    default:
#if (DEBUG)
                        WriteLine(Convert.ToString(obj) + " - Parameter qualified as other type.");
#endif
                        otherTypes++;
                        break;
                }
            }
            return (evenIntegers, positiveRealNumbers, positiveRealNumbersFloat, stringsLongerThan5Chars, otherTypes);
        }
    }
}
