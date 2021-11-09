using System;
using System.Globalization;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);

            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);

            double F = 8.36 * Math.Pow(10, 3.5) + Math.Pow(Math.Sin(2), 2) * (Math.Pow(Math.PI + a, -3)) + Math.Sqrt(Math.Abs(x)) - Math.Pow(Math.Sin(x), 2) / (x + Math.Pow(Math.E, x)) - (1 / Math.Tan(Math.Abs(x / a)));

            Console.WriteLine("F = " + F);
        }
    }
}
