using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Console;

//Ścigała Radosław, 246997

namespace Zad3
{
    class FileManager
    {
        public string Path { get; set; }

        public FileManager(string path)
        {
            Path = path;
        }

        private string GetTextFromFile()
        {
            string textFromFile = null;

            if (Path != null)
            {
                if (File.Exists(Path))
                {
                    using (StreamReader reader = File.OpenText(Path))
                    {
                        textFromFile = reader.ReadToEnd();
                    }
                }
                else
                {
                    WriteLine("File does not exist.");
                }
            }
            else
            {
                WriteLine("An invalid path was specified.");
            }

            return textFromFile;
        }

        public Dictionary<string, int> GetWordsFrequency()
        {
            Dictionary<string, int> wordsFrequency = new Dictionary<string, int>();
            List<string> fileWords = GetWordsList();

            if (fileWords.Count > 0)
            {
                HashSet<string> wordsSet = new HashSet<string>(fileWords);
                foreach (string word in wordsSet)
                {
                    wordsFrequency.Add(word, 0);
                }

                foreach (string fileWord in fileWords)
                {
                    wordsFrequency[fileWord] += 1;
                }
            }

            return wordsFrequency;
        }

        public List<string> GetWordsList()
        {
            List<string> wordsList = new List<string>();
            string textFromFile = GetTextFromFile();

            if (textFromFile != null)
            {
                StringBuilder currentWord = new StringBuilder();

                for (int i = 0; i < textFromFile.Length; i++)
                {
                    if (textFromFile[i] >= 'a' && textFromFile[i] <= 'z' || textFromFile[i] >= 'A' && textFromFile[i] <= 'Z')
                    {
                        currentWord.Append(textFromFile[i]);
                        if (i == textFromFile.Length - 1)
                        {
                            wordsList.Add(currentWord.ToString().ToLower());
                        }
                    }
                    else
                    {
                        if (currentWord.Length > 0)
                        {
                            wordsList.Add(currentWord.ToString().ToLower());
                            currentWord.Clear();
                        }
                    }
                }
            }
            return wordsList;
        }
    }
}
