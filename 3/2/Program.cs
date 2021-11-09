using System;

namespace _2
{
    class Program
    {
        static decimal deposit, percent = 1.07m;
        static int month;
        static int i = 0;
        static void Main(string[] args)
        {
            Console.Write("Введите сумму вклада: ");
            deposit = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Введите кол-во месяцев: ");
            month = Convert.ToByte(Console.ReadLine());

            while (i < month)
            {
                deposit *= percent;
                i++;
            }

            Console.WriteLine("Сумма вклада: {0}", deposit);
        }
    }
}
