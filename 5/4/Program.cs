using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array("Первый массив", 10);
            array.showArray();
            array.Size = 15;
            array.showArray();
            array.multiple5();
            array.sumAndMultiple();

            Console.WriteLine($"Размер массива: {array.Size}, кол-во ненулевых элементов: {array.NoZero}");
        }
    }

    class Array
    {
        int[] intArray;
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

                    intArray = new int[size];
                    for (int i = 0; i < size; i++)
                        intArray[i] = random.Next(-50, 51);
                }
            }
        }

        public int NoZero
        {
            get
            {
                int count = 0;

                foreach (int n in intArray)
                {
                    if (n != 0)
                        count++;
                }

                return count;
            }
        }

        public void showArray()
        {
            Console.Write("[ ");
            foreach (int n in intArray)
            {
                Console.Write($"{n}, ");
            }
            Console.WriteLine("]\n");
        }

        public void multiple5()
        {
            int count = 0;
            string num = "";

            foreach (int n in intArray)
            {
                if (n % 5 == 0)
                {
                    num += $"{n}, ";
                    count++;
                }
            }

            Console.WriteLine($"Числа кратные 5: [ {num} ], кол-во [ {count} ]\n");
        }

        public void sumAndMultiple()
        {
            int sum = 1, multiple = 1;

            foreach (int n in intArray)
            {
                if (n % 2 == 0)
                {
                    sum += n;
                    multiple *= n;
                }
            }

            Console.WriteLine($"Сумма четных элементов: {sum}, произведение четных элементов: {multiple}\n");
        }
    }
}
