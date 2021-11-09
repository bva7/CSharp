using System;

namespace _6
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
            array.fuckIntex();
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
                        intArray[i] = random.Next(-80, 81);
                }
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

        public void fuckIntex()
        {
            int max = intArray[0];

            for (int i = 1; i < intArray.Length; i++)
                if (max < intArray[i])
                    max = intArray[i];

            for (int i = 0; i < intArray.Length; i += 2)
                intArray[i] -= max;

            Console.Write($"Максимальный элемент: {max}, новый массив: ");
            showArray();
        }
    }
}
