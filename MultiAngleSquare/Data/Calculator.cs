using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiAngleSquare.Data
{
    class Calculator
    {
        public static double Calculate(List<Point> points)
        {
            if (points.Count < 3)
                return 0;

            double s = 0;
            for (int i = 0; i < points.Count; i++)
            {
                int j = (i != points.Count - 1) ? i + 1 : 0;
                s += points[i].X * points[j].Y - points[j].X * points[i].Y;
            }
            return (s >= 0) ? s / 2 : -s / 2;
        }
    }
}
