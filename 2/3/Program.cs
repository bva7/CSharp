using System;

namespace _3
{
    class Program
    {
        static double x1, x2, d;
        static int a, b, c;
        static void Main(string[] args)
        {
            Task();
        }

        public static void Task()
        {
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("c = ");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a == b) && (b == c))
            {
                Console.WriteLine("Ответ: Корней бесчисленное множетсво (х - любое)");
            }
            else if ((a == b) && (b == 0) && (c != 0))
            {
                Console.WriteLine("Ответ: Нет корней");
            }
            else if ((a == 0) && (b != 0))
            {
                x1 = ((-1 * c) / b);
                Console.WriteLine("Ответ: {0}", x1);
            }
            else if (a != 0)
            {
                d = ((b * b) - (4 * a * c));
                if (d < 0)
                {
                    Console.WriteLine("Ответ: Нет корней тк дискриминант отрицательный");
                }
                else if (d == 0)
                {
                    x1 = ((-1 * b) / (2 * a));
                    Console.WriteLine("Ответ: {0}", x1);
                }
                else
                {
                    x1 = (((-1 * b) + Math.Sqrt(d)) / (2 * a));
                    x2 = (((-1 * b) - Math.Sqrt(d)) / (2 * a));
                    Console.WriteLine("Ответ: x1 = {0}, x2 = {1}", x1, x2);
                }
            }

        }
    }
}
