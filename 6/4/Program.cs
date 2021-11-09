using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoArray twoArray = new TwoArray("я матрица из 4 задания", 5, 5);

            twoArray.showArray();
            twoArray.maxLine();
            twoArray.sumNumLine();

            // создаем новый массив
            twoArray.Size = new int[7, 11];
            twoArray.showArray();

            // колличество отрицательных элементов массива
            Console.WriteLine($"Кол-во не нулевых элементов {twoArray.NoZero}");

            // название матрицы
            Console.WriteLine($"Название матрицы: {twoArray.Name}");
        }
    }

    class TwoArray
    {
        private int[,] intArray;

        Random random = new Random();

        public TwoArray() { }

        public TwoArray(string name, int m, int n)
        {
            Name = name;

            intArray = new int[m, n];

            madeArray(m, n);
        }

        public string Name { get; }

        public int[,] Size
        {
            get
            {
                return intArray;
            }

            set
            {
                if (value.Length > 0)
                {
                    intArray = new int[value.GetLength(0), value.GetLength(1)];

                    madeArray(value.GetLength(0), value.GetLength(1));
                }
            }
        }

        public int NoZero
        {
            get
            {
                int count = 0;

                foreach (int num in intArray)
                {
                    if (num != 0)
                    {
                        count++;
                    }
                }

                return count;
            }
        }

        public void madeArray(int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    intArray[i, j] = random.Next(-60, 61);
                }
            }
        }

        public void showArray()
        {
            Console.WriteLine(
                $"[ // размерность массива intArray" +
                $"[{intArray.GetLength(0)},{intArray.GetLength(1)}]"
                );
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                Console.Write("\t");
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    Console.Write($"{intArray[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("]\n");
        }

        public void maxLine()
        {
            int maxLine = 0, array, max = 0;

            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                array = 0;

                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    array += Math.Abs(intArray[i, j]);
                }

                if (max < array)
                {
                    max = array;
                    maxLine = i + 1;
                }
            }

            Console.WriteLine($"Номер строки с наибольшей суммой элементов: {maxLine}, [{max}]\n");
        }

        public void sumNumLine()
        {
            int result = 0, max;

            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                max = Math.Abs(intArray[i, 0]);

                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    if (max < Math.Abs(intArray[i, j]))
                    {
                        max = Math.Abs(intArray[i, j]);
                    }
                }

                result += max;
            }

            Console.WriteLine($"Сумма наибольших значений элементов строк: {result}\n");
        }

    }
}
