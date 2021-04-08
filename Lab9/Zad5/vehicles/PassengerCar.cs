using System;
using System.Collections.Generic;
using System.Text;

namespace Zad5.vehicles
{
    class PassengerCar : Car
    {
        public string BodyType { get; set; }
        public int SeatsNumber { get; set; }
        public bool RoofRack { get; set; }

        public PassengerCar(string color, string brand, string fuelType, int length, string bodyType, int seatsNumber)
            : base(color, brand, fuelType, length)
        {
            BodyType = bodyType;
            SeatsNumber = seatsNumber;
        }

        public void ZamontujBagażnikDachowy()
        {
            RoofRack = true;
        }

        public override string ToString()
        {
            return $"Passenger Car: color - {Color}, brand - {Brand}, fuel type - {FuelType}," +
                $" length - {Length}, body type - {BodyType}, number of seats - {SeatsNumber}, does have roof rack - {RoofRack}";
        }
    }
}
