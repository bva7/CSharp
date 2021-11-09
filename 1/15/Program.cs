using System;
using System.Globalization;

namespace _15
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

            double F = Math.Pow(Math.Sqrt((1 - a) / (1 + a)), 2.9 * a + 7) - (7.2 * Math.Pow(10, 1.3) * Math.Sqrt(a)) / (Math.Cos(Math.Pow(Math.E, Math.Sin(x)))) - Math.Tan(Math.PI / 30 - x);

            Console.WriteLine("F = " + F);
        }
    }
}
