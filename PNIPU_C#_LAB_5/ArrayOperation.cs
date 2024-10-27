using System;
using System.Reflection;
using static System.Console;

namespace PNIPU_C__LAB_5
{
    internal class ArrayOperation
    {
        public int[] OneDimentionalArray { get; set; }
        public int[,] TwoDimentionalArray { get; set; }
        public List<int[]> ToothedArray { get; set; }

        public int[] CreateOneDimentionalArray()
        {
            Write("Введите длину массива: ");
            int length = int.Parse(ReadLine());
            int[] array = new int[length];
            Random rand = new Random();

            for (int i = 0; i < length; i++)
            {
                Write("Введите элемент массива или нажмите Enter для случайного значения: ");
                string input = ReadLine();
                array[i] = string.IsNullOrEmpty(input) ? rand.Next(1, 100) : int.Parse(input);
            }

            return array;
        }

        public int[] DeleteFromOneDimentionalArray(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                WriteLine("Массив пуст.");
                return array;
            }

            Write("Введите значение для удаления: ");
            int value = int.Parse(ReadLine());
            List<int> result = new List<int>();

            foreach (int item in array)
                if (item != value)
                    result.Add(item);

            return result.ToArray();
        }


        public int[,] CreateTwoDimentionalArray()
        {
            Write("Введите количество строк: ");
            int rows = int.Parse(ReadLine());
            Write("Введите количество столбцов: ");
            int cols = int.Parse(ReadLine());
            int[,] array = new int[rows, cols];
            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Write($"Введите элемент [{i},{j}] или нажмите Enter для случайного значения: ");
                    string input = ReadLine();
                    array[i, j] = string.IsNullOrEmpty(input) ? rand.Next(1, 100) : int.Parse(input);
                }
            }
                

            return array;
        }

        public int[,] AddRowTwoDimentionalArray(int[,] array)
        {
            if (array == null)
            {
                WriteLine("Массив не существует.");
                return array;
            }

            int cols = array.GetLength(1);
            int[,] newArray = new int[array.GetLength(0) + 1, cols];
            Array.Copy(array, newArray, array.Length);

            WriteLine("Добавьте новую строку:");

            for (int j = 0; j < cols; j++)
            {
                Write($"Введите элемент [{newArray.GetLength(0) - 1},{j}]: ");
                newArray[newArray.GetLength(0) - 1, j] = int.Parse(ReadLine());
            }

            return newArray;
        }

        public List<int[]> CreateToothedArray()
        {
            Write("Введите количество строк: ");
            int rows = int.Parse(ReadLine());
            List<int[]> jaggedArray = new List<int[]>();
            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                Write($"Введите длину строки {i} или нажмите Enter для случайного значения: ");
                string input = ReadLine();
                int length = string.IsNullOrEmpty(input) ? rand.Next(2, 5) : int.Parse(input);
                int[] row = new int[length];

                for (int j = 0; j < length; j++)
                {
                    Write($"Введите элемент [{i},{j}] или нажмите Enter для случайного значения: ");
                    string elementInput = ReadLine();
                    row[j] = string.IsNullOrEmpty(elementInput) ? rand.Next(1, 100) : int.Parse(elementInput);
                }
                jaggedArray.Add(row);
            }

            return jaggedArray;
        }

        public List<int[]> RemoveRowsWithZero(List<int[]> jaggedArray)
        {
            if (jaggedArray == null || jaggedArray.Count == 0)
            {
                WriteLine("Массив пуст.");
                return jaggedArray;
            }

            List<int[]> result = new List<int[]>();
            foreach (var row in jaggedArray)
            {
                if (Array.IndexOf(row, 0) == -1)
                    result.Add(row);
            }

            return result;
        }

    }
}