using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Console;

//Radosław Ścigała, 246997

namespace Zad1
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

            try
            {
                StreamReader reader = File.OpenText(Path);
                textFromFile = reader.ReadToEnd();
            }
            catch (OutOfMemoryException e)
            {
                WriteLine("The file is too large, there is not enough memory.");
                WriteLine(e.Message);
            }
            catch (FileNotFoundException e)
            {
                WriteLine("File not found.");
                WriteLine(e.Message);
            }
            catch (ArgumentNullException e)
            {
                WriteLine("The path is null");
                WriteLine(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                WriteLine("The caller does not have the required permissions.");
                WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                WriteLine("Path is a zero-length string, contains only white space, or contains" +
                    " one or more invalid characters defined by InvalidPathChars.");
                WriteLine(e.Message);
            }
            catch (PathTooLongException e)
            {
                WriteLine("The specified path, file name, or both exceed the system-defined maximum length.");
                WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                WriteLine("The specified path is invalid");
                WriteLine(e.Message);
            }
            catch
            {
                WriteLine("Unexpected exception.");
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
