using System;

namespace _2
{
    class Program
    {
        static byte n;
        static void Main(string[] args)
        {
            Console.Write("Введите возраст человека до 100 лет ");
            n = Convert.ToByte(Console.ReadLine());

            if (n > 0 && n <= 100)
            {
                Console.WriteLine("{0} {1}", n, defineYear(n));
            }
        }
        static string defineYear(int n)
        {
            n %= 10;
            if (n == 1)
                return "год";
            else if (n != 0 && n < 5)
                return "года";
            else
                return "лет";
        }
    }
}
