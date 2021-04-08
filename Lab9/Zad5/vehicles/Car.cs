using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Zad5.vehicles
{
    abstract class Car : Vehicle
    {
        public string FuelType { get; set; }
        public int Length { get; set; }


        public Car(string color, string brand, string fuelType, int length) : base(color, brand)
        {
            FuelType = fuelType;
            Length = length;
        }

        public void AddGas()
        {
            if (FuelType == "Petrol")
                FuelType += "+Gas";
            else
                WriteLine("There is no posibillity to add gas");
        }

        public override string ToString()
        {
            return $"Car: kolor - {Color}, brand - {Brand}, fuel type - {FuelType}, length - {Length}";
        }
    }
}
