using static System.Console;

namespace PNIPU_C__LAB_2
{
    internal class Task_1
    {
        public static void SumEvenIndexElements()
        {
            Write("Введите количество элементов: ");
            int n = int.Parse(ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Write($"Введите элемент {i}: ");
                int num = int.Parse(ReadLine());

                if (i % 2 == 0)
                {
                    sum += num;
                }
            }

            WriteLine("Сумма элементов с четными номерами: " + sum);
        }

        public static void CountMultiplesOfFirstElement()
        {
            WriteLine("Введите последовательность чисел (закончить ввод числом 0):");

            int firstElement = int.Parse(ReadLine());
            int count = 0;

            int currentElement;
            while ((currentElement = int.Parse(ReadLine())) != 0)
            {
                if (currentElement % firstElement == 0)
                {
                    count++;
                }
            }

            WriteLine("Количество элементов, кратных первому: " + count);
        }

        public static void CalculateAlternatingSum()
        {
            Write("Введите количество слагаемых n: ");
            int n = int.Parse(ReadLine());

            int sum = 0;
            int i = 1;

            while (i <= n)
            {
                if (i % 3 == 0)
                {
                    sum -= i;
                }
                else
                {
                    sum += i;
                }
                i++;
            }

            WriteLine("Сумма S = " + sum);
        }
    }
}