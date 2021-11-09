using System;

namespace _15._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день (1 <= k <= 365): ");
            int num = int.Parse(Console.ReadLine());

            string dayOfWeek;

            switch (num)
            {
                case 1:
                    dayOfWeek = "Понедельник";
                    break;
                case 2:
                    dayOfWeek = "Вторник";
                    break;
                case 3:
                    dayOfWeek = "Среда";
                    break;
                case 4:
                    dayOfWeek = "Четверг";
                    break;
                case 5:
                    dayOfWeek = "Пятница";
                    break;
                case 6:
                    dayOfWeek = "Суббота";
                    break;
                default:
                    dayOfWeek = "Воскресенье";
                    break;
            }

            Console.WriteLine($"{dayOfWeek}");
        }
    }
}
