using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoArray twoArray = new TwoArray("я матрица из 5 задания", 5, 5);

            twoArray.showArray();
            twoArray.sumMinElemColumn();
            twoArray.sumMinColumnNum();

            // создаем новый массив
            twoArray.Size = new int[7, 11];
            twoArray.showArray();

            // колличество отрицательных элементов массива
            Console.WriteLine($"Кол-во элементов которые меньше 10 по модулю {twoArray.GetCountMore10}");

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

        public int GetCountMore10
        {
            get
            {
                int count = 0;

                foreach (int num in intArray)
                {
                    if (Math.Abs(num) < 10)
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
                    intArray[i, j] = random.Next(-50, 51);
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

        public void sumMinElemColumn()
        {
            int minI = 0, minJ = 0, sum = 0;

            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    if (intArray[i, j] < intArray[minI, minJ])
                    {
                        minI = i;
                        minJ = j;
                    }
                }
            }

            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                sum += Math.Abs(intArray[i, minJ]);
            }

            Console.WriteLine(
                $"Минимальный элемент матрицы: {intArray[minI, minJ]}, [{minI}, {minJ}]\n" +
                $"Сумма элементов столбца: {sum}\n"
                );
        }

        public void sumMinColumnNum()
        {
            int sum = 0, min;

            for (int j = 0; j < intArray.GetLength(0); j++)
            {
                min = intArray[0, j];

                for (int i = 0; i < intArray.GetLength(1); i++)
                {
                    if (intArray[i, j] < min)
                    {
                        min = intArray[i, j];
                    }
                }

                sum += Math.Abs(min);
            }

            Console.WriteLine($"Сумма наименьших значений столбцов: {sum}\n");
        }

    }
}
