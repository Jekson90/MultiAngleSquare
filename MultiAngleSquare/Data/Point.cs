using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiAngleSquare.Data
{
    class Point
    {
        public double X{ get; private set; }
        public double Y { get; private set; }

        private Point() { }
        public Point (double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
