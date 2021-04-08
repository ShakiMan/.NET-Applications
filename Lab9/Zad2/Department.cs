using System;
using System.Collections.Generic;
using System.Text;

//Radosław Ścigała, 246997

namespace Zad2
{
    public class Department
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public Department(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return $"{Id,2}), {Name,11}";
        }

    }
}
