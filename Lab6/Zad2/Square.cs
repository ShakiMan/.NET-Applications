using System;
using System.Collections.Generic;
using System.Text;

namespace Zad2
{
    class Square : IFigure, IHasInterior
    {
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }

        string IHasInterior.InteriorColor { get; set; }

        public void moveTo(double x, double y)
        {
            CoordinateX = x;
            CoordinateY = y;
        }

        public Square(double x, double y)
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
