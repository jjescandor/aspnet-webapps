using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            double totalArea = FindTriArea(500, 750) +
            FindRectArea(2500, 1500) + FindCircArea(375) / 2;
            double materialCost = totalArea * 180;
            Console.WriteLine($"The total cost for for the flooring of Teotihuacan which has a total area of {totalArea} sqm is {Math.Round(materialCost, 2)} pesos");

        }
        static double FindRectArea(double length, double width)
        {
            return length * width;
        }
        static double FindCircArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        static double FindTriArea(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }
    }
}
