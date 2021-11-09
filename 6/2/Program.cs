using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoArray twoArray = new TwoArray("я матрица из 2 задания", 5, 5);

            twoArray.showArray();
            twoArray.mainMultDiagonal();
            twoArray.mainSumDiagonal();

            // создаем новый массив
            twoArray.Size = new int[7, 11];
            twoArray.showArray();

            // изменяем на скалярное значение
            twoArray.Scale = 5;
            twoArray.showArray();

            // колличество положительных элементов массива
            Console.WriteLine($"В матрице {twoArray.CountPlus} положительных элементов");

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

        public int CountPlus
        {
            get
            {
                int count = 0;
                
                foreach (int num in intArray)
                {
                    if (num > 0) count++;
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
                    intArray[i, j] = random.Next(-70, 71);
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

        public void mainMultDiagonal()
        {
            long mult = 1, count = 0;

            // находим что меньше длинна иди высода массива
            int size =
                intArray.GetLength(0) < intArray.GetLength(1)
                ? intArray.GetLength(0) : intArray.GetLength(1);

            string error = "";

            if (intArray.GetLength(0) != intArray.GetLength(1))
            {
                error = "Стороны матрицы не равны, расчет будет не верен\n";
            }

            // расчет произведения положительных чисел под главной диаголалью
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (intArray[i, j] > 0)
                    {
                        mult *= intArray[i, j];
                        count++;
                    }
                }
            }

            Console.WriteLine(
                $"{error}" +
                $"Произведение положительных элементов под главной диагонали: {mult},\n" +
                $"число элементов {count}\n"
            );
        }

        public void mainSumDiagonal()
        {
            long mult = 0, count = 0;

            // находим что меньше длинна иди высода массива
            int size =
                intArray.GetLength(0) < intArray.GetLength(1)
                ? intArray.GetLength(0) : intArray.GetLength(1);

            string error = "";

            if (intArray.GetLength(0) != intArray.GetLength(1))
            {
                error = "Стороны матрицы не равны, расчет будет не верен\n";
            }

            // расчет суммы отрицательных чисел над главной диаголалью
            for (int i = 0; i < size; i++)
            {
                for (int j = i; j < size; j++)
                {
                    if (intArray[i, j] < 0)
                    {
                        mult += intArray[i, j];
                        count++;
                    }
                }
            }

            Console.WriteLine(
                $"{error}" +
                $"Сумма отрицательных элементов над главной диагонали: {mult},\n" +
                $"число элементов {count}\n"
            );
        }
    }
}
