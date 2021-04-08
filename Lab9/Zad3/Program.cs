using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInfo();

            List<Student> students = Generator.GenerateStudentsEasy();

            WriteLine("\nFamele and Male:");
            GetSortedTopics(students);
            WriteLine("\n\nFamele: ");
            GetSortedTopicsByGender(students, Gender.Female);
            WriteLine("\nMale: ");
            GetSortedTopicsByGender(students, Gender.Male);
        }

        static void GetSortedTopics(List<Student> students)
        {
            var topics = (from student in students
                          from topic in student.Topics
                          group topic by topic into tGr
                          orderby tGr.Count() descending
                          select new { tGr.Key, V = tGr.Count() })
                          .ToList();

            PrintTopicsAmount(topics);
        }

        static void GetSortedTopicsByGender(List<Student> students, Gender gender)
        {
            var topics = (from student in students
                          where student.Gender == gender
                          from topic in student.Topics
                          group topic by topic into tGr
                          orderby tGr.Count() descending
                          select new { tGr.Key, V = tGr.Count() }).ToList();

            PrintTopicsAmount(topics);
        }

        static void PrintTopicsAmount(dynamic topicsAppearanceAmount)
        {
            foreach (var topic in topicsAppearanceAmount)
            {
                WriteLine($"\tTopic {topic.Key} appeared {topic.V} times.");
            }
        }

        static void PrintInfo()
        {
            WriteLine("Ścigała Radosław, 246997");
            WriteLine($"{Environment.MachineName}\n");
        }
    }
}
