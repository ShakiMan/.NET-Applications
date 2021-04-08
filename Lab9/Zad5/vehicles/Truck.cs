using System;
using System.Collections.Generic;
using System.Text;

namespace Zad5.vehicles
{
    class Truck : Car
    {
        public int Capacity { get; set; }
        public int EnginePower { get; set; } = 100;
        public int LoadCapacity { get; set; }

        public Truck(string color, string brand, string fuleType, int length, int capacity, int loadCapacity)
            : base(color, brand, fuleType, length)
        {
            Capacity = capacity;
            LoadCapacity = loadCapacity;
        }

        public void UlepszSilnik(int horsepower)
        {
            EnginePower += horsepower;
        }

        public override string ToString()
        {
            return $"Truck: color - {Color}, brand - {Brand}, fuel type - {FuelType}, length - {Length}," +
                $" capacity - {Capacity}, engine power - {EnginePower} KM, load capacity - {LoadCapacity}";
        }
    }
}
