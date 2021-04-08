using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

//Ścigała Radosław, 246997

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInfo();

            string path;
            WriteLine("Enter the path to the text file:");
            path = ReadLine();

            Dictionary<string, int> wordsFrequency = GetWordsFrequency(path);

            PrintWords(wordsFrequency);
        }

        static Dictionary<string, int> GetWordsFrequency(string path)
        {
            FileManager fileManager = new FileManager(path);
            Dictionary<string, int> wordsFrequency = fileManager.GetWordsFrequency();
            return wordsFrequency;
        }

        static void PrintWords(Dictionary<string, int> wordsFrequency, int wordsToPrint = 10)
        {
            int printedWords = 0;
            foreach (KeyValuePair<string, int> word in wordsFrequency.OrderByDescending(key => key.Value))
            {
                Console.WriteLine(word.Key + " wystąpiło " + word.Value + " razy");
                if (++printedWords == wordsToPrint)
                {
                    break;
                }
            }
        }

        static void PrintInfo()
        {
            WriteLine("Ścigała Radosław, 246997");
            WriteLine($"{Environment.MachineName}\n");
        }
    }
}
