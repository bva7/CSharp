using System;

namespace _15._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введиде цифру от 1 до 12: ");
            int mounthNumber = int.Parse(Console.ReadLine());

            string mounthName;

            switch (mounthNumber)
            {
                case 1:
                    mounthName = "Январь";
                    break;
                case 2:
                    mounthName = "Февраль";
                    break;
                case 3:
                    mounthName = "Март";
                    break;
                case 4:
                    mounthName = "Апрель";
                    break;
                case 5:
                    mounthName = "Май";
                    break;
                case 6:
                    mounthName = "Июнь";
                    break;
                case 7:
                    mounthName = "Июль";
                    break;
                case 8:
                    mounthName = "Август";
                    break;
                case 9:
                    mounthName = "Сентябрь";
                    break;
                case 10:
                    mounthName = "Октябрь";
                    break;
                case 11:
                    mounthName = "Ноябрь";
                    break;
                default:
                    mounthName = "Декабрь";
                    break;
            }

            Console.WriteLine($"Месяц: {mounthName}");
        }
    }
}
