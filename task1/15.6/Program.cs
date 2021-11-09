using System;

namespace _15._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введиде цифру от 6 до 14: ");
            int n = int.Parse(Console.ReadLine());

            string str;

            switch (n)
            {
                case 6:
                    str = "Шестерка";
                    break;
                case 7:
                    str = "Семерка";
                    break;
                case 8:
                    str = "Восьмерка";
                    break;
                case 9:
                    str = "Девятка";
                    break;
                case 10:
                    str = "Десятка";
                    break;
                case 11:
                    str = "Валет";
                    break;
                case 12:
                    str = "Дама";
                    break;
                case 13:
                    str = "Король";
                    break;
                default:
                    str = "Туз";
                    break;
            }

            Console.WriteLine($"Месяц: {str}");
        }
    }
}
