using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

//Radosław Ścigała, 246997

namespace Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInfo();

            List<Student> students = Generator.GenerateStudentsEasy(); 
            WriteLine("\nBefore:");
            foreach (Student student in students)
            {
                WriteLine(student);
            }

            List<StudentWithTopics> studentsWithTopics = TransformStudents(students);
            WriteLine("\nAfter:");
            foreach (StudentWithTopics student in studentsWithTopics)
            {
                WriteLine(student);
            }
        }

        static List<StudentWithTopics> TransformStudents(List<Student> students)
        {
            var studentsWithTopics = (from student in students
                                      select new StudentWithTopics(student.Id, student.Index, student.Name,
                                      student.Gender, student.Active, student.DepartmentId, TransformTopics(student.Topics)))
                                      .ToList();
            return studentsWithTopics;
        }

        static List<Topic> TransformTopics(List<string> topicsTitles)
        {
            return (from topic in topicsTitles
                    select Topic.GetTopicByTitle(topic)).ToList();
        }

        static void PrintInfo()
        {
            WriteLine("Ścigała Radosław, 246997");
            WriteLine($"{Environment.MachineName}\n");
        }
    }
}
