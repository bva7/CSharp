using System;
using System.Globalization;

namespace _16
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

            double F = 1.736 * Math.Abs(Math.Log(Math.Tan(x / 2))) - Math.Sqrt(Math.Atan((Math.Pow(Math.E, x) - Math.Pow(Math.E, -x)) / 2));

            Console.WriteLine("F = " + F);
        }
    }
}
