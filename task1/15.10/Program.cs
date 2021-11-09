using System;

namespace _15._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] month = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.Write("Введите номер месяца: ");
            int monthNumber = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Введите номер дня: ");
            int dayNumber = int.Parse(Console.ReadLine());

            int dayBefor = dayNumber, dayAfter = dayNumber, monthBefor = monthNumber, monthAfter = monthNumber;

            if (dayNumber == 1)
            {
                monthBefor--;
                dayBefor = month[monthBefor];
            }
            else
            {
                dayBefor--;
            }

           
            if (dayNumber == month[monthNumber])
            {
                monthAfter++;
                dayAfter = month[monthAfter];
            }
            else
            {
                dayAfter++;
            }

            Console.Write($"Предыдущий день: {dayBefor}, Завтрашний день: {dayAfter}");
        }
    }
}
