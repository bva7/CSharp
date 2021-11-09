using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array("Первый массив", 10);
            array.showArray();
            array.Size = 15;
            array.showArray();
            array.fuckIndex();
            array.differenceMinMax();

            Console.WriteLine($"Размер массива: {array.Size}, модуль меньше 10: {array.module10}");
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
        }

        public string Name { get; }

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
                        dbArray[i] = random.Next(-100, 100);
                }
            }
        }

        public int module10
        {
            get
            {
                int count = 0;

                foreach (int n in dbArray)
                {
                    if (Math.Abs(n) < 10)
                        count++;
                }

                return count;
            }
        }

        public void showArray()
        {
            Console.Write("[ ");
            foreach (int n in dbArray)
            {
                Console.Write($"{n}, ");
            }
            Console.WriteLine("]\n");
        }

        public void fuckIndex()
        {
            double sum = 0, mult = 1;

            for (int i = 0; i < dbArray.Length; i++)
            {
                if (i % 2 == 0)
                    mult *= dbArray[i];
                else
                    sum += dbArray[i];
            }

            Console.WriteLine(
                $"Сумма элементов с нечетными индексами: {sum},\n" +
                $"Произведение элементов с четными индексами: {mult}\n"
            );
        }

        public void differenceMinMax()
        {
            double min = dbArray[0], max = dbArray[1], result;

            for (int i = 2; i < dbArray.Length; i++)
            {
                if (min > dbArray[i]) min = dbArray[i];

                if (max < dbArray[i]) max = dbArray[i];
            }

            result = max + min;

            Console.WriteLine($"Разность между максимальным и минимальным элементом: {result}, (max) {max} (min) {min}\n");
        }
    }
}
