using System;
using System.Collections.Generic;
using System.Reflection;
using Zad5.vehicles;
using static System.Console;

//Radosław Ścigała, 246997

namespace Zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInfo();

            CarHandler carHandler = new CarHandler();
            carHandler.Vehicles.AddRange(GetVehiclesList());
            double result = GetCarHandlerVehiclesCapacity(carHandler);
            WriteLine($"Total load capacity: {result}");
        }

        static List<Vehicle> GetVehiclesList()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            //ostatni argument w Truck() to nośność
            vehicles.Add(new Truck("Blue", "Man", "Diesel", 6, 5000, 7000)); 
            vehicles.Add(new Truck("Black", "Mercedes", "Diesel", 7, 4500, 6500));
            vehicles.Add(new Truck("White", "Man", "Diesel", 8, 7000, 7500));
            vehicles.Add(new Bike("Red", "Romet", "City bike", true));
            vehicles.Add(new PassengerCar("Green", "Skoda", "Petrol", 4, "Sedan", 5));
            return vehicles;
        }

        static double GetCarHandlerVehiclesCapacity(CarHandler carHandler)
        {
            MethodInfo methodInfo = carHandler.GetType().GetMethod("CountTotalVehiclesLoadCapacity",
                new Type[] { typeof(List<Vehicle>) });
            double sumOfcapacity = (double)methodInfo.Invoke(carHandler,
                new object[] { carHandler.Vehicles });

            return sumOfcapacity;
        }

        static void PrintInfo()
        {
            WriteLine("Ścigała Radosław, 246997");
            WriteLine($"{Environment.MachineName}\n");
        }
    }
}
