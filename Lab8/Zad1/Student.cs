using System;
using System.Collections.Generic;
using System.Text;

//Radosław Ścigała, 246997

namespace Zad1
{
    class Student
    {
        public string Name { get; }
        public string Surname { get; }
        public int Index { get; }
        public string Email { get; }

        public Student(string name, string surname, int index, string email)
        {
            Name = name;
            Surname = surname;
            Index = index;
            Email = email;
        }

        public override string ToString()
        {
            return $"Student: {Name}, {Surname}, {Index}, {Email}";
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                Name == student.Name &&
                Surname == student.Surname &&
                Index == student.Index &&
                Email == student.Email;
        }

    }
}
