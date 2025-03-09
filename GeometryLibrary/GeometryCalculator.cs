using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public static class GeometryCalculator
    {
        public static double CalculateCircleArea(double r)
        {
            double output = 0;
            output = (Math.PI) * (Math.Pow(r,2));
            output = Math.Round(output,2);
            return output;
        }

        public static double CalculateRectanglePerimeter(double l, double w)
        {
            double output = 0;
            output = 2 * (l + w);
            return output;
        }

        public static double CalculateTriangleArea(double b, double h)
        {
            double output = 0;
            output = 0.5 * (b * h);
            return output;
        }
    }
}
