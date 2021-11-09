using System;

namespace _4
{
    class Program
    {
        static double _1, _2, mult;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа от 0 до 10");

            while (true)
            {
                Console.Write("1-е число = ");
                _1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("2-е число = ");
                _2 = Convert.ToDouble(Console.ReadLine());

                if (_1 > 0 && _1 <= 10 && _2 > 0 && _2 <= 10)
                {
                    break;
                } else
                {
                    Console.WriteLine("Введенные числа не допустимы");
                }
            }
            mult = _1 * _2;
            Console.WriteLine("Результат умножения: {0}", mult);
        }
    }
}
