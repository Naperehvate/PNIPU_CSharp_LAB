
using static System.Console;

namespace PNIPU_C__LAB_5

{
    internal class ArrayPrint
    {
        public void Print(int[] array)
        {
            WriteLine();
            if (array == null || array.Length == 0)
            {
                WriteLine("Одномерный массив пуст.");
                return;
            }

            WriteLine("Одномерный массив:");
            foreach (var item in array)
                Write(item + " ");
            WriteLine();

        }

        public void Print(int[,] array)
        {
            WriteLine();
            if (array == null || array.Length == 0)
            {
                WriteLine("Двумерный массив пуст.");
                return;
            }

            WriteLine("Двумерный массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Write(array[i, j] + " ");
                WriteLine();
            }
        }

        public void Print(List<int[]> jaggedArray)
        {
            WriteLine();
            if (jaggedArray == null || jaggedArray.Count == 0)
            {
                WriteLine("Рваный массив пуст.");
                return;
            }

            WriteLine("Рваный массив:");
            for (int i = 0; i < jaggedArray.Count; i++)
            {
                foreach (var item in jaggedArray[i])
                    Write(item + " ");
                WriteLine();
            }
            
        }
    }
}
