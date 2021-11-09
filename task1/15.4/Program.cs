using System;

namespace _15._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Год високосный? (да/нет) ");
            string year = Console.ReadLine();

            Console.Write("Введиде цифру от 1 до 12: ");
            int mounthNumber = int.Parse(Console.ReadLine());

            int mounthName;

            switch (mounthNumber)
            {
                case 1:
                    mounthName = 31;
                    break;
                case 2:
                    if (year == "да")
                        mounthName = 29;
                    else
                        mounthName = 28;
                    break;
                case 3:
                    mounthName = 31;
                    break;
                case 4:
                    mounthName = 30;
                    break;
                case 5:
                    mounthName = 31;
                    break;
                case 6:
                    mounthName = 30;
                    break;
                case 7:
                    mounthName = 31;
                    break;
                case 8:
                    mounthName = 31;
                    break;
                case 9:
                    mounthName = 30;
                    break;
                case 10:
                    mounthName = 31;
                    break;
                case 11:
                    mounthName = 30;
                    break;
                default:
                    mounthName = 31;
                    break;
            }

            Console.WriteLine($"Дней: {mounthName}");
        }
    }
}
