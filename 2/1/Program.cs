using System;

namespace _1
{
    class Program
    {
        static int _1, _2, _3;
        const int min = 2, max = 5;
        static void Main(string[] args)
        {
            Console.Write("1-е число: ");
            _1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2-е число: ");
            _2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("3-е число: ");
            _3 = Convert.ToInt32(Console.ReadLine());

            Range(_1, min, max);
            Range(_2, min, max);
            Range(_3, min, max);
        }

        static void Range(int num, int min, int max)
        {
            if (num >= min && num <= max)
            {
                if (num == min || num == max)
                {
                    Console.Write("\"{0}\" ", num);
                } else
                {
                    Console.Write("{0} ", num);
                }
            }
        }
    }
}
