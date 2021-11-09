using System;

namespace _15._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите месяц: ");
            int numMonth = int.Parse(Console.ReadLine());

            string month;

            switch (numMonth)
            {
                case 1:
                    month = "Февраль";
                    break;
                case 2:
                    month = "Март";
                    break;
                case 3:
                    month = "Апрель";
                    break;
                case 4:
                    month = "Май";
                    break;
                case 5:
                    month = "Июнь";
                    break;
                case 6:
                    month = "Июль";
                    break;
                case 7:
                    month = "Август";
                    break;
                case 8:
                    month = "Сентябрь";
                    break;
                case 9:
                    month = "Октябрь";
                    break;
                case 10:
                    month = "Ноябрь";
                    break;
                case 11:
                    month = "Декабрь";
                    break;
                default:
                    month = "Январь";
                    break;
            }

            Console.WriteLine($"{month}");
        }
    }
}
