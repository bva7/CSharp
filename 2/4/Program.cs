using System;

namespace _4
{
    class Program
    {
        static int operation, _1, _2, result;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
            operation = Convert.ToInt32(Console.ReadLine());

            Console.Write("1-е число: ");
            _1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2-е число: ");
            _2 = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    result = _1 + _2;
                    break;
                case 2:
                    result = _1 - _2;
                    break;
                case 3:
                    result = _1 * _2;
                    break;
                default:
                    Console.WriteLine("Не определено");
                    break;
            }
            Console.WriteLine("Результат {0}", result);
        }
    }
}
