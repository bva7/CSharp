using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            var pentagon = new Pentagon();
            CreateShape(pentagon);

            var ellipse = new Ellipse();
            CreateShape(ellipse);

            var triangle = new Triangle();
            CreateShape(triangle);
        }

        static void CreateShape(Shape value)
        {
            Guid id = Guid.NewGuid();

            Console.WriteLine($"<{value.GetType().Name}>");
            value.Name = $"{value.GetType().Name} {id}";
            value.Value1 = 11;
            value.Value2 = 5;
            Console.WriteLine(
                $"\tМеня зовут \"{value.Name}\"\n" +
                $"\tЗначение = [{value.Value1}, {value.Value2}]\n" +
                $"\tЭто моя площадь: {String.Format("{0:.##}", value.S())}\n" +
                $"\tА это периметр: {String.Format("{0:.##}", value.P())}\n" +
                $"\tУ меня {value.Top} вершин"
                );
            value.Draw();
            Console.WriteLine($"</{value.GetType().Name}>\n");
        }
    }

    abstract class Shape
    {
        public abstract double Value1 { get; set; }
        public abstract double Value2 { get; set; }

        public abstract int Top { get; }

        public abstract string Name { get; set; }

        public abstract double S();

        public abstract double P();

        public abstract void Draw();
    }

    class Pentagon : Shape
    {
        public override double Value1 { get; set; }
        public override double Value2 { get; set; }

        public override int Top
        {
            get
            {
                return 5;
            }
        }

        public override string Name { get; set; }

        public override double S()
        {
            return Math.Pow(Value1, 2) / 4 * Math.Sqrt(25 + 10 * Math.Sqrt(Value2));
        }

        public override double P()
        {
            return Value1 * Value2;
        }

        public override void Draw()
        {
            Console.WriteLine("\tРисование фигуры:");
            Console.WriteLine(
                "\t      $$$$      \n" +
                "\t$$$$$$$$$$$$$$$$\n" +
                "\t $$$$$$$$$$$$$\n" +
                "\t  $$$$$$$$$$$\n" +
                "\t   $$$$$$$$$\n"
                );
        }
    }

    class Ellipse : Shape
    {
        public override double Value1 { get; set; }
        public override double Value2 { get; set; }

        public override int Top
        {
            get
            {
                return 0;
            }
        }

        public override string Name { get; set; }

        public override double S()
        {
            return Math.PI * Value1 * Value2;
        }

        public override double P()
        {
            return 2 * Math.PI * Math.Sqrt((Math.Pow(Value1, 2) + Math.Pow(Value2, 2)) / 2);
        }

        public override void Draw()
        {
            Console.WriteLine(
               "\tРисование фигуры:\n" +
               "\t     .....\n" +
               "\t .............\n" +
               "\t...............\n" +
               "\t .............\n" +
               "\t     ....."
                );
        }
    }

    class Triangle : Shape
    {
        public override double Value1 { get; set; }
        public override double Value2 { get; set; }

        public override int Top
        {
            get
            {
                return 3;
            }
        }

        public override string Name { get; set; }

        public override double S()
        {
            return Value1 * Value2 / 2;
        }

        public override double P()
        {
            return Math.Sqrt(Math.Pow(Value1, 2) + Math.Pow(Value2, 2)) + Value1 + Value2;
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
