using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaOfACircle = GeometryCalculator.CalculateCircleArea(6);
            Console.WriteLine(areaOfACircle);

            double perimeter = GeometryCalculator.CalculateRectanglePerimeter(5, 10);
            Console.WriteLine(perimeter);

            double areaOfATriangle = GeometryCalculator.CalculateTriangleArea(3, 4);
            Console.WriteLine(areaOfATriangle);


            Console.ReadLine(); 
        }
    }
}
