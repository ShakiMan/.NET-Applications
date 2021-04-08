using System;
using System.Globalization;
using static System.Console;

namespace LaboratoriaNr3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int arg1;
            double arg2;
            bool arg3;
            DateTime date1;
            DateTime date2;

            Write("Radosław Ścigała, 246997");

            do
            {
                Write("\nPodaj arg1(int): ");
                str = ReadLine();
            } while (!int.TryParse(str, out arg1));
            WriteLine($"arg1: {arg1}\n");

            do
            {
                Write("\nPodaj arg2(double): ");
                str = ReadLine();
            } while (!double.TryParse(str, out arg2));
            WriteLine($"arg2: {arg2}\n");

            do
            {
                Write("\nPodaj arg3(bool): ");
                str = ReadLine();
            } while (!bool.TryParse(str, out arg3));
            WriteLine($"arg3: {arg3}\n");

            do
            {
                Write("\nPodaj date1(DateTime): ");
                str = ReadLine();
            } while (!DateTime.TryParse(str, out date1));
            WriteLine($"date1: {date1}\n");

            CultureInfo plPL = new CultureInfo("pl-PL");
            do
            {
                Write("\nPodaj date2(DateTime), format [dd.MM.yyyy]: ");
                str = ReadLine();
            } while (!DateTime.TryParseExact(str, "dd.MM.yyyy", plPL, DateTimeStyles.AllowLeadingWhite, out date2));
            WriteLine($"date2: {date2}\n");

            
        }
    }
}
