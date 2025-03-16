using ClassLibrary;

namespace PNIPU_C__LAB_11
{
    internal class MenuHandler
    {
        private StackManager _stackManager = new StackManager();
        bool exit = false;

        public void ShowMenu()
        {
            while (!exit)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Добавить объект");
                Console.WriteLine("2. Удалить объект");
                Console.WriteLine("3. Показать все элементы");
                Console.WriteLine("4. Количество объектов определенного типа");
                Console.WriteLine("5. Печать объектов определенного типа");
                Console.WriteLine("6. Клонировать коллекцию");
                Console.WriteLine("7. Сортировать и выполнить поиск");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите действие: ");

                string choice = Console.ReadLine();
                HandleChoice(choice);
            }
        }

        private void HandleChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    AddObject();
                    break;
                case "2":
                    _stackManager.RemoveObject();
                    break;
                case "3":
                    _stackManager.PrintAll();
                    break;
                case "4":
                    Console.Write("Введите тип объекта (Person, Worker, Engineer, Administration): ");
                    _stackManager.CountByType(Console.ReadLine());
                    break;
                case "5":
                    Console.Write("Введите тип объекта для вывода: ");
                    _stackManager.PrintByType(Console.ReadLine());
                    break;
                case "6":
                    _stackManager.CloneCollection();
                    break;
                case "7":
                    Console.Write("Введите возраст для поиска: ");
                    if (int.TryParse(Console.ReadLine(), out int age))
                        _stackManager.SortAndSearch(age);
                    else
                        Console.WriteLine("Ошибка ввода возраста.");
                    break;
                case "0":
                    Console.WriteLine("Выход..." + "\n\n\n");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Некорректный ввод, попробуйте снова.");
                    break;
            }
        }

        private void AddObject()
        {
            Console.WriteLine("Выберите тип объекта для добавления:");
            Console.WriteLine("1. Person");
            Console.WriteLine("2. Worker");
            Console.WriteLine("3. Engineer");
            Console.WriteLine("4. Administration");

            string choice = Console.ReadLine();
            IInit obj = choice switch
            {
                "1" => new Person(),
                "2" => new Worker(),
                "3" => new Engineer(),
                "4" => new Administration(),
                _ => null
            };

            if (obj != null)
                _stackManager.AddObject(obj);
            else
                Console.WriteLine("Некорректный выбор.");
        }
    }
}
