using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square();
            CreateShape(square);

            var circle = new Circle();
            CreateShape(circle);

            var triangle = new Triangle();
            CreateShape(triangle);

            Console.WriteLine("\nСоздаем обьект класса Picture \"new Picture(2)\"\n");

            var picture = new Picture(2);
            picture.Add(square, circle);
            picture.ShowName();

            Console.WriteLine("Меняем Size на 3\n");

            picture.Size = 3;
            picture.ShowName();

            Console.WriteLine("Довавляем объект\n");

            picture.Add(triangle);
            picture.ShowName();
            
        }

        static void CreateShape(Shape value)
        {
            Guid id = Guid.NewGuid();

            Console.WriteLine($"<{value.GetType().Name}>");
            value.Name = $"{value.GetType().Name} {id}";
            value.Value = 5;
            Console.WriteLine(
                $"\tМеня зовут \"{value.Name}\"\n" +
                $"\tЗначение = {value.Value}\n" +
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
        public abstract double Value { get; set; }

        public abstract int Top { get; }

        public abstract string Name { get; set; }

        public abstract double S();

        public abstract double P();

        public abstract void Draw();
    }

    class Square : Shape
    {
        public override double Value { get; set; }

        public override int Top
        {
            get
            {
                return 4;
            }
        }

        public override string Name { get; set; }

        public override double S()
        {
            return Math.Pow(Value, 2);
        }

        public override double P()
        {
            return Value * 4;
        }

        public override void Draw()
        {
            Console.WriteLine("\tРисование фигуры:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("\t");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
        }
    }

    class Circle : Shape
    {
        public override double Value { get; set; }

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
            return Math.PI * Math.Pow(Value, 2);
        }

        public override double P()
        {
            return 2 * Math.PI * Value;
        }

        public override void Draw()
        {
            Console.WriteLine(
               "\tРисование фигуры:\n" +
               "\t  .....  \n" +
               "\t.........\n" +
               "\t.........\n" +
               "\t.........\n" +
               "\t  .....  "
                );
        }
    }

    class Triangle : Shape
    {
        public override double Value { get; set; }

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
            return Math.Pow(Value, 2) * Math.Sqrt(3.0) / 4;
        }

        public override double P()
        {
            return Value * 3;
        }

        public override void Draw()
        {
            Console.WriteLine(
                "\tРисование фигуры:\n" +
                "\t    *    \n" +
                "\t   ***   \n" +
                "\t  *****  \n" +
                "\t ******* \n" +
                "\t*********"
                );
        }
    }

    class Picture
    {
        private Shape[] shpArray;
        private int size;

        public Picture(int size)
        {
            Size = size;

            shpArray = new Shape[size];
        }

        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                if (value > 0)
                {
                    Shape[] newShpArray = new Shape[value];

                    if (value > size)
                    {
                        for (int i = 0; i < size; i++)
                        {
                            newShpArray[i] = shpArray[i];
                        }
                    }
                    else
                    {
                        for (int i = 0; i < value; i++)
                        {
                            newShpArray[i] = shpArray[i];
                        }
                    }

                    shpArray = newShpArray;

                    size = value;
                }
            }
        }

        public void Add(params object[] value)
        {
            int j = 0;
            for (int i = 0; i < shpArray.Length; i++)
            {
                if (!(shpArray[i] is Shape))
                {
                    shpArray[i] = (Shape) value[j++];
                }
            }
        }

        public void ShowName()
        {
            string result;
            Console.Write("Имена объектов: \n");
            for (int i = 0; i < shpArray.Length; i++)
            {
                result = shpArray[i] == null ? "NullReferenceException" : shpArray[i].Name;
                Console.Write($"\t{i + 1}. {result}\n");
            }
            Console.WriteLine();
        }

    }
}
