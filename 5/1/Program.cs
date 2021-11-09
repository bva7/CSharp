using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array("первый массив", 10);

            array.showArray();
            array.averageArithmetic();
            array.averageGeometric();
            array.scaleArray();
            array.showArray();

            Console.WriteLine($"Имя массива = {array.Name}");
        }
    }

    class Array
    {
        double[] dbArray;
        int size;

        const int scale = 5;

        Random random = new Random();

        public Array() { }

        public Array(string name, int size)
        {
            Name = name;
            Size = size;
            dbArray = new double[size];

            for (int i = 0; i < size; i++)
                dbArray[i] = random.Next(-50, 50);
        }

        public string Name
        {
            get;
        }

        public int Size {
            get
            {
                return size;
            }

            set
            {
                if (value > 0)
                {
                    size = value;
                }
            }
        }

        public void scaleArray()
        {
            for (int i = 0; i < dbArray.Length; i++)
            {
                dbArray[i] *= scale;
            }
        }

        public void showArray()
        {
            Console.Write("[ ");
            foreach (double n in dbArray)
            {
                Console.Write($"{n}, ");
            }
            Console.WriteLine("]\n");
        }

        public void averageArithmetic()
        {
            double averPlus = 0, averMinus = 0;
            int countPlus = 0, countMinus = 0;

            foreach (double n in dbArray)
            {
                if (n > 0)
                {
                    countPlus++;
                    averPlus += n;
                }
                else
                {
                    countMinus++;
                    averMinus += n;
                }
            }
            Console.WriteLine(
                $"Среднее арифметическое положительных: {averPlus / countPlus} \n" +
                $"Среднее арифметическое отрицательных: {averMinus / countMinus}\n"
            );
        }

        public void averageGeometric()
        {
            double z = 1;
            int count = 0;

            foreach (double n in dbArray)
            {
                if (n > 0)
                {
                    count++;
                    z *= n;
                }
            }

            z = Math.Pow(z, 1.0 / count);

            Console.WriteLine($"Среднее геометрическое: {z}\n");
        }
    }
}
