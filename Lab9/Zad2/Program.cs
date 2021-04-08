using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

//Radosław Ścigała, 246997

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInfo();

            List<Student> students = Generator.GenerateStudentsEasy();

            DivideStudentsIntoGroups(students, 3);
        }

        static void DivideStudentsIntoGroups(List<Student> students, int groupSize)
        {
            var sortedStudents = students.
                OrderBy(s => s.Name).ThenBy(s => s.Index);

            var dividedStudents = sortedStudents
                .Select((s, i) => new { Index = i, Stud = s })
                .GroupBy(s => s.Index / groupSize)
                .Select(s => s.Select(v => v.Stud).ToList())
                .ToList();

            int groupNumber = 1;
            foreach (List<Student> group in dividedStudents)
            {
                WriteLine($"Group {groupNumber++}:");
                foreach (Student student in group)
                {
                    WriteLine(student);
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
