using System;
using static System.Console;

//Ścigała Radosław, 2469997

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInfo();

            object[] arr =
            {
                new Square(4.5, 6.0),
                new Triangle(-21, 12),
                new Circle(8.76, 3.12),
                new Pentagon(17.0, 8)                
            };

            foreach (object obj in arr)
            {
                if (obj is IFigure)
                {
                    WriteLine($"Before: {obj}");
                    (obj as IFigure).moveTo(4, 5);
                    WriteLine($"After: {obj}");
                }
            }

            IHasInterior interior = (IHasInterior)arr[0];
            interior.InteriorColor = "White";
            interior = (IHasInterior)arr[1];
            interior.InteriorColor = "Black";

            PrintFigureColor(arr);
        }

        public static void PrintFigureColor(object[] arr)
        {
            foreach (object obj in arr)
            {
                IHasInterior interior = obj as IHasInterior;
                if (interior != null)
                    WriteLine($"{interior.InteriorColor}");
                else
                    WriteLine($"no color");
            }
        }

        static void PrintInfo()
        {
            WriteLine("Ścigała Radosław, 246997");
            WriteLine($"{Environment.MachineName}\n");
        }
    }
}
