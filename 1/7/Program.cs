using System;
using System.Globalization;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);

            double F = 0.836 + (a / Math.Sqrt(Math.Pow(Math.Cos(a), 3)) - 1) * Math.Pow(Math.Atan(a), 4) + 3 * a - ((a / (a - 8)) + 2.306 * Math.Pow(a, 2));

            Console.WriteLine("F = " + F);
        }
    }
}
