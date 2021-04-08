using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

//Radosław Ścigała

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInfo();

            string path = null;
            WriteLine("Enter the path to the text file:");
            try
            {
                path = ReadLine();
            }
            catch (OutOfMemoryException e)
            {
                WriteLine("Not enough memory to allocate a buffer for the return string.");
                WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                WriteLine("The number of characters in the next line of characters is greater than MaxValue.");
                WriteLine(e.Message);
            }

            Dictionary<string, int> wordsFrequency = GetWordsFrequency(path);

            PrintWords(wordsFrequency);
        }

        static Dictionary<string, int> GetWordsFrequency(string path)
        {
            FileManager fileManager = new FileManager(path);
            Dictionary<string, int> wordsFrequency = fileManager.GetWordsFrequency();
            return wordsFrequency;
        }

        static void PrintWords(Dictionary<string, int> wordsFrequency)
        {
            var words = (from word in wordsFrequency
                        orderby word.Value descending
                        select word)
                        .Take(10).ToList();
            words.ForEach(s => WriteLine(s));
        }

        static void PrintInfo()
        {
            WriteLine("Ścigała Radosław, 246997");
            WriteLine($"{Environment.MachineName}\n");
        }
    }
}
