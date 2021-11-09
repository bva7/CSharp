using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoArray twoArray = new TwoArray("я матрица из 6 задания", 5, 5);

            twoArray.showArray();
            twoArray.fuckDiagonal();
            twoArray.minColumn();

            // создаем новый массив
            twoArray.Size = new int[7, 11];
            twoArray.Scale = 10;
            twoArray.showArray();

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

        public int Scale
        {
            set
            {
                for (int i = 0; i < intArray.GetLength(0); i++)
                {
                    for (int j = 0; j < intArray.GetLength(1); j++)
                    {
                        intArray[i, j] *= value;
                    }
                }
            }
        }

        public void madeArray(int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    intArray[i, j] = random.Next(-80, 81);
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

        public void fuckDiagonal()
        {
            int max, min, indexI = 0, indexJ = 0;

            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                max = intArray[i, 0];
                min = intArray[i, 0];

                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    if (intArray[i, j] > max)
                    {
                        max = intArray[i, j];
                        indexI = i;
                        indexJ = j;
                    }
                    min = intArray[i, j] < min ? intArray[i, j] : min;
                }

                intArray[i, i] = max;
                
                if (indexJ != i)
                {
                    intArray[indexI, indexJ] = min;
                }
            }

            showArray();
        }

        public void minColumn()
        {
            int result = 1, currentArray, minArray = 0;

            for (int i = 0; i < 1; i++)
                for (int j = 0; j < intArray.GetLength(1); j++)
                    minArray += Math.Abs(intArray[j, i]);

            for (int i = 1; i < intArray.GetLength(0); i++)
            {
                currentArray = 0;

                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    currentArray += Math.Abs(intArray[j, i]);
                }

                if (currentArray < minArray)
                {
                    minArray = currentArray;
                    result = i + 1;
                }
            }

            Console.WriteLine($"Номер столбца с наименьшей суммой элементов: {result}, [{minArray}]\n");
        }

    }
}
