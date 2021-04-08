using System;
using System.Collections.Generic;
using System.Text;

namespace Zad2
{
    class Pentagon : IFigure
    {
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }

        public Pentagon(double x, double y)
        {
            CoordinateX = x;
            CoordinateY = y;
        }

        public void moveTo(double x, double y)
        {
            CoordinateX = x;
            CoordinateY = y;
        }

        public override string ToString()
        {
            return $"{CoordinateX}; {CoordinateY}";
        }
    }
}
