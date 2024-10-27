using static System.Console;

namespace PNIPU_C__LAB_5
{
    internal class Menu
    {
        private string select = "";

        ArrayOperation arrayOperation = new();
        ArrayPrint arrayPrint = new();

        public void ShowMenu()
        {
            while (true)
            {
                WriteLine(@"
            Меню
1. Создать одномерный массив
2. Удалить элемент по значению из одномерного массива
3. Создать двумерный массив
4. Добавить строку в конец двумерного массива
5. Создать рваный массив
6. Удалить строки с нулями из рваного массива
7. Вывести массив
8. Выход
Выберите действие: ");

                select = ReadLine();

                switch (select)
                {
                    case "1":
                        arrayOperation.OneDimentionalArray = arrayOperation.CreateOneDimentionalArray();
                        arrayPrint.Print(arrayOperation.OneDimentionalArray);

                        break;

                    case "2":
                        arrayOperation.OneDimentionalArray = arrayOperation.DeleteFromOneDimentionalArray(arrayOperation.OneDimentionalArray);
                        arrayPrint.Print(arrayOperation.OneDimentionalArray);

                        break;

                    case "3":
                        arrayOperation.TwoDimentionalArray = arrayOperation.CreateTwoDimentionalArray();
                        arrayPrint.Print(arrayOperation.TwoDimentionalArray);

                        break;

                    case "4":
                        arrayOperation.TwoDimentionalArray = arrayOperation.AddRowTwoDimentionalArray(arrayOperation.TwoDimentionalArray);
                        arrayPrint.Print(arrayOperation.TwoDimentionalArray);

                        break;

                    case "5":
                        arrayOperation.ToothedArray = arrayOperation.CreateToothedArray();
                        arrayPrint.Print(arrayOperation.ToothedArray);

                        break;

                    case "6":
                        arrayOperation.ToothedArray = arrayOperation.RemoveRowsWithZero(arrayOperation.ToothedArray);
                        arrayPrint.Print(arrayOperation.ToothedArray);

                        break;

                    case "7":
                        arrayPrint.Print(arrayOperation.OneDimentionalArray);
                        arrayPrint.Print(arrayOperation.TwoDimentionalArray);
                        arrayPrint.Print(arrayOperation.ToothedArray);

                        break;

                    case "8":
                        return;

                    default:
                        WriteLine("Неверный выбор.");
                        break;
                }
            }
        }
    }
}