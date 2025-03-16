using ClassLibrary;

namespace PNIPU_C__LAB_11
{
    internal class MenuHandlerObjGenerics
    {
        bool exit = false;
        public void ShowMenu()
        {
            while (!exit)
            {
                Console.WriteLine("Выберите тип объектов:");
                Console.WriteLine("1. Person");
                Console.WriteLine("2. Worker");
                Console.WriteLine("3. Engineer");
                Console.WriteLine("4. Administration");
                Console.WriteLine("0. Выход");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RunMenu<Person>();
                        break;
                    case "2":
                        RunMenu<Worker>();
                        break;
                    case "3":
                        RunMenu<Engineer>();
                        break;
                    case "4":
                        RunMenu<Administration>();
                        break;
                    case "0":
                        exit = true;
                        return;
                    default:
                        Console.WriteLine("Некорректный выбор. Нажмите любую клавишу для повторного выбора.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void RunMenu<T>() where T : Person, IInit, new()
        {
            var menu = new MenuHandlerGenerics<T>();
            menu.ShowMenu();
        }
    }
}

