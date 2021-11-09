using System;

namespace _3
{
    class Program
    {
        static string space;
        static int ver, hor;
        static void Main(string[] args)
        {
            Console.Write("ver = ");
            ver = Convert.ToInt32(Console.ReadLine());

            Console.Write("hor = ");
            hor = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= ver; i++)
            {
                Gaps(i, ver);
                Console.Write("{0}{1}", i, space);

                for (int j = 2; j <= hor; j++)
                {
                    Gaps(j * i, hor);
                    Console.Write("{0}{1}", j * i, space);
                }
                Console.WriteLine();
            }
        }
        static string Gaps(int i, int num)
        {
            space = "";
            for (int k = Convert.ToString(i).Length; k <= Convert.ToString(num * num).Length; k++)
            {
                space += " ";
            }
            return space;
        }
    }
}
