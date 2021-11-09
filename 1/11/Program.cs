using System;
using System.Globalization;

namespace _11
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

            double F = Math.Pow(Math.Pow(Math.E, x), a) + 2.73 * (Math.Pow(a, 3) * Math.Pow(x, 1.0/3) + 1.78 * Math.Pow(Math.Abs(x), 1.4)) / (Math.Abs(x + a) + Math.Tan((Math.PI / 2) * a));

            Console.WriteLine("F = " + F);
        }
    }
}
