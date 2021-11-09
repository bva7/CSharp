using System;

namespace _15._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введиде цифру от 1 до 4: ");
            int mastNumber = int.Parse(Console.ReadLine());

            Console.Write("Введиде цифру от 6 до 14: ");
            int cartNumber = int.Parse(Console.ReadLine());

            string mastCart;

            switch (mastNumber)
            {
                case 1:
                    mastCart = "Пики";
                    break;
                case 2:
                    mastCart = "Трефы";
                    break;
                case 3:
                    mastCart = "Бубны";
                    break;
                default:
                    mastCart = "Червы";
                    break;
            }

            mastCart += " ";

            switch (cartNumber)
            {
                case 6:
                    mastCart += "шестерка";
                    break;
                case 7:
                    mastCart += "семерка";
                    break;
                case 8:
                    mastCart += "восмерка";
                    break;
                case 9:
                    mastCart += "девятка";
                    break;
                case 10:
                    mastCart += "десятка";
                    break;
                case 11:
                    mastCart += "валет";
                    break;
                case 12:
                    mastCart += "дама";
                    break;
                case 13:
                    mastCart += "король";
                    break;
                case 14:
                    mastCart += "туз";
                    break;
            }

            Console.WriteLine($"{mastCart}");
        }
    }
}
