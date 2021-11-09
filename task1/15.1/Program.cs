using System;

namespace _15._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введиде цифру от 1 до 7: ");
            int weekOfDayNumber = int.Parse(Console.ReadLine());

            string weakOfDayName;

            switch (weekOfDayNumber)
            {
                case 1:
                    weakOfDayName = "Понедельник";
                    break;
                case 2:
                    weakOfDayName = "Вторник";
                    break;
                case 3:
                    weakOfDayName = "Среда";
                    break;
                case 4:
                    weakOfDayName = "Четверг";
                    break;
                case 5:
                    weakOfDayName = "Пятница";
                    break;
                case 6:
                    weakOfDayName = "Суббота";
                    break;
                default:
                    weakOfDayName = "Воскресенье";
                    break;
            }

            Console.WriteLine($"День недели: {weakOfDayName}");
        }
    }
}
