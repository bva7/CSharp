using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаем треугольник
            Triangle triangle = new Triangle();
            triangle.name = "треугольник 1";
            triangle.a = 1;
            triangle.b = 2;
            triangle.c = 3;

            triangle.GetName(); // получаем имя объекта
            triangle.GetSide(); // получаем стороны объекта

            Console.WriteLine($"P = {triangle.P()} \nS = {triangle.S()}\n\n");

            // создаем новый треугольник
            Triangle newTriangle = new Triangle("Новый треугольник", 11.11, 22.22, 33.33);
            newTriangle.GetName();
            newTriangle.GetSide();

            Console.WriteLine($"P = {newTriangle.P()} \nS = {newTriangle.S()}\n\n");

            // еще один треугольник
            Triangle TRIANGLE;
            TRIANGLE = new Triangle("ТРЕУГОЛЬНИК", 23, -2, 54); // недоступен для чтения и записи
            TRIANGLE.GetName(); // пытаемся получить имя

            // проверяем объекты на существование
            triangle.Exist(1, 2, 3);
            newTriangle.Exist(11, 22, 33);

        }
    }

    class Triangle
    {
        public double a, b, c;
        public string name;

        public Triangle() { }

        public Triangle(string name, double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                Name = name;

                A = a;
                B = b;
                C = c;
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

        public double C
        {
            get
            {
                return c;
            }

            set
            {
                c = value;
            }
        }

        public void Exist(double a, double b, double c)
        {
            if (a == A && b == B && c == C)
            {
                GetName();
            } else
            {
                Console.WriteLine("Объкт не существует");
            }
        }

        public void GetSide()
        {
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
        }

        public void GetName()
        {
            Console.WriteLine($"name = {name}");
        }

        public double P()
        {
            return a + b + c;
        }

        public double S()
        {
            return a * b * c;
        }
    }
}
