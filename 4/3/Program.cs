using System;

namespace _3
{
    class Program
    {
        static int first, second;
        static void Main(string[] args)
        {
            Console.Write("Номинал купюры: ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Кол-во купюр: ");
            second = int.Parse(Console.ReadLine());

            Console.Clear();

            Money myMoney = new Money(first, second);
            Console.WriteLine(
                $"Номинал купюры: {myMoney.First} \nКол-во купюр: {myMoney.Second} \n" +
                $"Смогу купить монитор (24999р.)? {myMoney.buyGoods(24999)} \n" +
                $"Сколько штук хлеба куплю (25р.)? {myMoney.howMuchBuy(25)} \n" +
                $"Сколько у меня денег? {myMoney.sumOfMoney()}"
            );
        }
    }

    class Money
    {
        int first, second;

        public Money(int first, int second)
        {
            if (first > 0 && second > 0)
            {
                First = first;
                Second = second;
            }
        }

        public int First
        {
            get
            {
                return first;
            }
            set
            {
                first = value;
            }
        }

        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                second = value;
            }
        }

        public bool buyGoods(int value)
        {
            return first * second > value;
        }

        public int howMuchBuy(int value)
        {
            return first * second / value;
        }

        public int sumOfMoney()
        {
            return first * second;
        }
    }
}
