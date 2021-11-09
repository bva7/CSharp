using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            var eqTriangle = new EqTriangle();
            CreateShape(eqTriangle);

            var isTriangle = new IsTriangle();
            CreateShape(isTriangle);

            var rectTriangle = new RectTriangle();
            CreateShape(rectTriangle);
        }

        static void CreateShape(Triangle value)
        {
            Guid id = Guid.NewGuid();

            Console.WriteLine($"<{value.GetType().Name}>");
            value.Name = $"{value.GetType().Name} {id}";
            value.A = 11;
            value.B = 5;
            value.Angle = 68;
            Console.WriteLine(
                $"\tМеня зовут \"{value.Name}\"\n" +
                $"\tЗначения: [A = {value.A}, B = {value.B}, Угол = {value.Angle}]\n" +
                $"\tЭто моя площадь: {String.Format("{0:.##}", value.S())}\n" +
                $"\tА это периметр: {String.Format("{0:.##}", value.P())}\n"
                );
            value.Draw();
            Console.WriteLine($"</{value.GetType().Name}>\n");
        }
    }

    abstract class Triangle
    {
        public abstract double A { get; set; }
        public abstract double B { get; set; }
        public abstract double Angle { get; set; }

        public abstract string Name { get; set; }

        public abstract double S();

        public abstract double P();

        public abstract void Draw();
    }

    class EqTriangle : Triangle
    {
        public override double A { get; set; }
        public override double B { get; set; }
        public override double Angle { get; set; }

        public override string Name { get; set; }

        public override double S()
        {
            return 0.5 * A * B * Math.Sin(Angle);
        }

        public override double P()
        {
            return 3 * A;
        }

        public override void Draw()
        {
            Console.WriteLine("\tРисование фигуры:");
            Console.WriteLine(
                "\t    *    \n" +
                "\t   ****  \n" +
                "\t  ********\n" +
                "\t  ********** \n" +
                "\t *****\n" +
                "\t*"
                );
        }
    }

    class IsTriangle : Triangle
    {
        public override double A { get; set; }
        public override double B { get; set; }
        public override double Angle { get; set; }

        public override string Name { get; set; }

        public override double S()
        {
            return 0.5 * Math.Pow(A, 2) * Math.Sin(Angle);
        }

        public override double P()
        {
            return A * 2 + B;
        }

        public override void Draw()
        {
            Console.WriteLine(
               "\tРисование фигуры:\n" +
               "\t    *    \n" +
               "\t   ***   \n" +
               "\t  *****  \n" +
               "\t ******* \n" +
               "\t*********\n"
                );
        }
    }

    class RectTriangle : Triangle
    {
        public override double A { get; set; }
        public override double B { get; set; }
        public override double Angle { get; set; }

        public override string Name { get; set; }

        public override double S()
        {
            return 0.5 * A * B * Math.Sin(Angle);
        }

        public override double P()
        {
            return Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2)) + A + B;
        }

        public override void Draw()
        {
            Console.WriteLine(
                "\tРисование фигуры:\n" +
                "\t*\n" +
                "\t***\n" +
                "\t*****\n" +
                "\t*******\n" +
                "\t*********"
                );
        }
    }
}
