using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array("второй массив", 10);

            array.showArray();
            array.maxProductNeighbors();
            array.centerArithmetic();

            Console.WriteLine("\nМеняем размер массива на 5 элементов\n\n");

            array.Size = 5;
            array.showArray();
            array.numberPlus();
            Console.WriteLine($"Имя массива = {array.Name}");
        }
    }

    class Array
    {
        double[] dbArray;
        int size;

        Random random = new Random();

        public Array() { }

        public Array(string name, int size)
        {
            Name = name;
            Size = size;
            dbArray = new double[size];

            for (int i = 0; i < size; i++)
                dbArray[i] = random.Next(-70, 70);
        }

        public string Name
        {
            get;
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
                    size = value;

                    dbArray = new double[size];

                    for (int i = 0; i < size; i++)
                        dbArray[i] = random.Next(-70, 70);
                }
            }
        }

        public void showArray()
        {
            Console.Write("массив = [ ");
            foreach (double n in dbArray)
            {
                Console.Write($"{n}, ");
            }
            Console.WriteLine("]\n");
        }

        public void maxProductNeighbors()
        {
            double result = dbArray[0] * dbArray[1];
            double n;
            int _1 = 0, _2 = 1;

            for (int i = 2; i < dbArray.Length - 1; i++)
            {
                n = dbArray[i - 1] * dbArray[i];
                if (n > result)
                {
                    result = n;
                    _1 = i - 1;
                    _2 = i;
                }
            }

            Console.WriteLine($"Макс. произведение двух соседних эл.: {result}, индекс [ {_1}, {_2} ]\n");
        }

        public void centerArithmetic()
        {
            double middle = 0, elem, diff, array;
            int _1 = 0;

            foreach (double n in dbArray)
            {
                middle += n;
            }

            middle /= dbArray.Length;

            diff = Math.Abs(middle - dbArray[0]);
            elem = dbArray[0];

            for (int i = 1; i < dbArray.Length; i++)
            {
                array = Math.Abs(middle - dbArray[i]);
                if (array < diff)
                {
                    diff = array;
                    elem = dbArray[i];

                    _1 = i;
                }
            }

            Console.WriteLine(
                $"Среднее арифмет.: {middle}, ближе всего цифра: {elem}, индекс: [ {_1} ]\n"
            );
        }

        public void numberPlus()
        {
            int count = 0;

            foreach (double n in dbArray)
            {
                if (n > 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Кол-во четных чисел: {count}\n");
        }
    }
}
