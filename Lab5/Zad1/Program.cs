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

            MixedNumber test0 = new MixedNumber();
            WriteLine(test0);

            MixedNumber test1 = new MixedNumber(2, -141, -10);
            WriteLine(test1);

            MixedNumber test3 = new MixedNumber(3.39);
            MixedNumber test4 = new MixedNumber(2, 12, 16);
            WriteLine($"Adding: {test3}  +  {test4} =  {test3 + test4}");

            MixedNumber test5 = new MixedNumber(3, 1, 2);
            MixedNumber test6 = new MixedNumber(-1, 2, 4);
            WriteLine($"Adding: {test5}  +  {test6} =  {test5 + test6}");

            MixedNumber test7 = new MixedNumber(-2, 3, 9);
            MixedNumber test8 = new MixedNumber(1, 6, 4);
            WriteLine($"Adding: {test7}  +  {test8} =  {test7 + test8}");

            MixedNumber test9 = new MixedNumber(-1, 1, 2);
            MixedNumber test10 = new MixedNumber(1, 1, 2);
            WriteLine($"Adding: {test9}  +  {test10} =  {test9 + test10}");

            WriteLine("Shift couneter: " + MixedNumber.ShiftCounter);
        }

        static void PrintInfo()
        {
            WriteLine("Ścigała Radosław, 246997");
            WriteLine($"{Environment.MachineName}\n");
        }
    }
}
