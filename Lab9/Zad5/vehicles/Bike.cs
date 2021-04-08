using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Zad5.vehicles
{
    class Bike : Vehicle
    {
        public string BikeType { get; set; }
        public bool ContainsBasket { get; set; }

        public Bike(string color, string brand, string bikeType, bool containsBasket) : base(color, brand)
        {
            BikeType = bikeType;
            ContainsBasket = containsBasket;
        }

        public void LoseChain()
        {
            WriteLine("Something bad happend");
        }

        public override string ToString()
        {
            return $"Bike: colour - {Color}, brand - {Brand}, bike type - {BikeType}, contains basket - {ContainsBasket}";
        }
    }
}
