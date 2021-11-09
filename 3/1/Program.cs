using System;

namespace _1
{
    class Program
    {
        static decimal deposit, percent = 1.07m;
        static int month;
        static void Main(string[] args)
        {
            Console.Write("Введите сумму вклада: ");
            deposit = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Введите кол-во месяцев: ");
            month = Convert.ToByte(Console.ReadLine());

            for (int i = 0; i < month; i++)
            {
                deposit *= percent;
            }

            Console.WriteLine("Сумма вклада: {0}", deposit);
        }
    }
}
