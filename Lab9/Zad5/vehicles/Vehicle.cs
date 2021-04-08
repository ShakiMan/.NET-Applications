using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

//Radosław Ścigała, 246997

namespace Zad5.vehicles
{
    abstract class Vehicle
    {
        public string Color { get; set; }
        public string Brand { get; set; }

        public Vehicle(string color, string brand)
        {
            Color = color;
            Brand = brand;
        }

        virtual public void Move(int x)
        {
            for (int i = 0; i < x; i++)
                WriteLine(". . . . . .");
        }

        public override string ToString()
        {
            return $"Vehicle: color - {Color}, brand - {Brand}";
        }
    }
}
