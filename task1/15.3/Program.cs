using System;

namespace _15._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введиде цифру от 1 до 12: ");
            int mounthNumber = int.Parse(Console.ReadLine());

            string mounthName;

            if (mounthNumber == 12 || mounthNumber >= 1 && mounthNumber <= 2)
                mounthName = "Зима";
            else if (mounthNumber >= 3 && mounthNumber <= 5)
                mounthName = "Весна";
            else if (mounthNumber >= 6 && mounthNumber <= 8)
                mounthName = "Лето";
            else
                mounthName = "Осень";

            Console.WriteLine($"Время года: {mounthName}");
        }
    }
}
