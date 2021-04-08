using System;
using System.Collections.Generic;
using System.Text;
using Zad5.vehicles;

//Radosław Ścigała, 246997

namespace Zad5
{
    class CarHandler
    {
        public List<Vehicle> Vehicles { get; }

        public CarHandler()
        {
            Vehicles = new List<Vehicle>();
        }

        public static double CountTotalVehiclesLoadCapacity(List<Vehicle> vehicles)
        {
            double sumOfCapacity = 0;
            foreach (Vehicle vehicle in vehicles)
            {
                sumOfCapacity += (vehicle as Truck)?.LoadCapacity ?? 0;
            }
            return sumOfCapacity;
        }
    }
}
