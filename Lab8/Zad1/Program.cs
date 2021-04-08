using System;
using System.Collections.Generic;
using static System.Console;

//Radosław Ścigała, 246997

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInfo();

            PresetnStudentsList();
            WriteLine("\n");
            PresntMixedNumbersList();
        }

        static void PresetnStudentsList()
        {
            ListOfArrayList<Student> students = new ListOfArrayList<Student>(3);

            students.Add(new Student("Kamil", "Nowak", 243422, "kamil.nowak@mail.com"));
            students.Add(new Student("Jan", "Kowalski", 592912, "jan.kowalski@mail.com"));
            students.Add(new Student("Paweł", "Nowak", 129394, "pawel.nowak@mail.com"));
            students.Add(new Student("Andrzej", "Wiśniewski", 491921, "andrzej.wisniewski@mail.com"));

            WriteLine(students);

            WriteLine("\nContains (Kamil, Nowak, 243422, kamil.nowak@mail.com)");
            WriteLine(students.Contains(new Student("Kamil", "Nowak", 243422, "kamil.nowak@mail.com")));

            WriteLine("\nIndexOf (Paweł, Nowak, 129394, pawel.nowak@mail.com)");
            WriteLine(students.IndexOf(new Student("Paweł", "Nowak", 129394, "pawel.nowak@mail.com")));

            WriteLine("\nRemove (Jan, Kowalski, 592912, jan.kowalski@mail.com)");
            students.Remove(new Student("Jan", "Kowalski", 592912, "jan.kowalski@mail.com"));
            WriteLine(students);

            WriteLine("\nRemoveAt(2)");
            students.RemoveAt(2);
            WriteLine(students);

            WriteLine("\nTrim");
            students.Trim();
            WriteLine(students);

            WriteLine("\noperator+");
            List<Student> antoherStudents = new List<Student> { new Student("Jan", "Kowalski", 246879, "jan.kowalski@mial.com") };
            students = students + antoherStudents;
            WriteLine(students);
        }

        static void PresntMixedNumbersList()
        {
            ListOfArrayList<MixedNumber> mixedNumbers = new ListOfArrayList<MixedNumber>(3);

            mixedNumbers.Add(new MixedNumber(2, 3, 4));
            mixedNumbers.Add(new MixedNumber(1, 4, 3));
            mixedNumbers.Add(new MixedNumber(3, 1, 5));
            mixedNumbers.Add(new MixedNumber(2, 4, 7));
            mixedNumbers.Add(new MixedNumber(5, 2, 3));
            mixedNumbers.Add(new MixedNumber(1, 1, 3));
            mixedNumbers.Add(new MixedNumber(2, 5));

            WriteLine(mixedNumbers);

            WriteLine("\nContains MixedNumber(2, 3, 4)");
            WriteLine(mixedNumbers.Contains(new MixedNumber(2, 3, 4)));

            WriteLine("\nIndexOf MixedNumber(5, 2, 3)");
            WriteLine(mixedNumbers.IndexOf(new MixedNumber(5, 2, 3)));

            WriteLine("\nRemove MixedNumber(5, 2, 3)");
            mixedNumbers.Remove(new MixedNumber(5, 2, 3));
            WriteLine(mixedNumbers);

            WriteLine("\nRemoveAt(2)");
            mixedNumbers.RemoveAt(2);
            WriteLine(mixedNumbers);

            WriteLine("\nTrim");
            mixedNumbers.Trim();
            WriteLine(mixedNumbers);

            WriteLine("\noperator+");
            List<MixedNumber> antoherMixedNumbers = new List<MixedNumber> { new MixedNumber(1, 2, 3), new MixedNumber(3, 2, 5) };
            mixedNumbers = mixedNumbers + antoherMixedNumbers;
            WriteLine(mixedNumbers);
        }

        static void PrintInfo()
        {
            WriteLine("Ścigała Radosław, 246997");
            WriteLine($"{Environment.MachineName}\n");
        }
    }
}
