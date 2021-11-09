using System;

namespace _5
{
    class Program
    {
        static int a, b, x, y;
        static void Main(string[] args)
        {
            Console.Write("x = ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());

            if (x == 0)
            {
                y = Math.Max(a, b);
            } else if (x == 1)
            {
                y = Math.Min(a, b);
            } else
            {
                y = Math.Abs(a + b);
            }

            Console.WriteLine(y);
        }
    }
}
