using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoArray twoArray = new TwoArray("я матрица из 3 задания", 5, 5);

            twoArray.showArray();
            twoArray.findZeroInLine();
            twoArray.minAbs();

            // создаем новый массив
            twoArray.Size = new int[7, 11];
            twoArray.showArray();

            // колличество отрицательных элементов массива
            Console.WriteLine($"В матрице {twoArray.CountMinus} отрицательных элементов");

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

        public int CountMinus
        {
            get
            {
                int count = 0;

                foreach (int num in intArray)
                {
                    if (num < 0) count++;
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
                    intArray[i, j] = random.Next(-40, 41);
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

        public void findZeroInLine()
        {
            int count = 0;

            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    if (intArray[i, j] == 0)
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine($"Кол-во строк содержащих хотя бы один нулевой элемент {count}");
        }

        public void minAbs()
        {
            int min = Math.Abs(intArray[0, 0]);
            string index = "";

            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    if (Math.Abs(intArray[i, j]) < min)
                    {
                        min = intArray[i, j];
                        index = i + "," + j;
                    }
                }
            }

            Console.WriteLine($"Минимальный элемент в массиве по модулю: {min}, [{index}]");
        }
    }
}
