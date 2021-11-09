using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаем прямоугольник
            Rectangle triangle = new Rectangle();
            triangle.name = "прямоугольник 1";
            triangle.a = 3;
            triangle.b = 3;

            triangle.GetName(); // получаем имя объекта
            triangle.GetSide(); // получаем стороны объекта

            Console.WriteLine($"P = {triangle.P()} \nS = {triangle.S()}\n");

            // создаем новый прямоугольник
            Rectangle newTriangle = new Rectangle("Новый прямоугольник", 11.11, 22.22);
            newTriangle.GetName();
            newTriangle.GetSide();

            Console.WriteLine($"P = {newTriangle.P()} \nS = {newTriangle.S()}\n");

            // еще один прямоугольник
            Rectangle TRIANGLE;
            TRIANGLE = new Rectangle("ПРЯМОУГОЛЬНИК", 23, -2); // недоступен для чтения и записи
            TRIANGLE.GetName(); // пытаемся получить имя

            Console.WriteLine();

            // проверяем прямоугольник на квадрат
            triangle.Square();
            newTriangle.Square();
            newTriangle.Square();

        }
    }

    class Rectangle
    {
        public double a, b;
        public string name;

        public Rectangle() { }

        public Rectangle(string name, double a, double b)
        {
            if (a > 0 && b > 0)
            {
                Name = name;

                A = a;
                B = b;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double A
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }

        public double B
        {
            get
            {
                return b;
            }

            set
            {

                b = value;

            }
        }

        public void Square()
        {
            if (a == b)
                Console.WriteLine($"{name} - КВАДРАТ!!!");
            else
                Console.WriteLine($"{name} - НЕ квадрат");
        }

        public void GetSide()
        {
            Console.WriteLine($"a = {a}, b = {b}");
        }

        public void GetName()
        {
            if (name != null)
                Console.WriteLine($"name = {name}");
            else
                Console.WriteLine($"\"name\" не доступна");
        }

        public double P()
        {
            return a + b;
        }

        public double S()
        {
            return a * b;
        }
    }
}
