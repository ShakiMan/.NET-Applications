using System;
using System.Text;
using static System.Console;

//Ścigała Radosław, 246997

namespace Zad2
{
    public static class StringExtension
    {
        public static string Modify(this string str)
        {           
            string newString = "";
            for (int i = 0; i < str.Length; i++)
            {
                int position = i + 1;
                if (IsLetter(str[i]))
                {
                    if (position % 2 == 0)
                    {
                        newString += str[i].ToString().ToUpper();
                    }
                    else
                    {
                        newString += str[i].ToString().ToLower();
                    }
                }
                else
                {
                    newString += ".";
                    
                }
            }
            return newString;
        }

        private static bool IsLetter(char c)
        {
            return c.ToString().ToUpper() != c.ToString().ToLower();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PrintInfo();
            //string text = GetDataFromUser();
            string text = GetHardCodeData();
            WriteLine($"Ciąg przed przekształceniem: {text}");
            WriteLine($"Ciąg po przekształceniu: {text.Modify()}");

            WriteLine("ąćęłńóśźżĄĆĘŁŃÓŹŻ".Modify());
        }

        static string GetHardCodeData()
        {
            return "Ala ma 12 kotow. Jej koty lubią pić melko <3. [][]";
        }

        static string GetDataFromUser()
        {
            WriteLine("Wpisz ciąg znakow:\n");
            string text = ReadLine();
            return text;
        }

        static void PrintInfo()
        {
            WriteLine("Ścigała Radosław, 246997");
            WriteLine($"{Environment.MachineName}\n");
        }
    }
}
