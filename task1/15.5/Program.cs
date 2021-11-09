using System;

namespace _15._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введиде цифру от 1 до 4: ");
            int n = int.Parse(Console.ReadLine());

            string str;

            switch (n)
            {
                case 1:
                    str = "Пики";
                    break;
                case 2:
                    str = "Трефы";
                    break;
                case 3:
                    str = "Бубны";
                    break;
                default:
                    str = "Червы";
                    break;
            }

            Console.WriteLine($"Масть: {str}");
        }
    }
}
