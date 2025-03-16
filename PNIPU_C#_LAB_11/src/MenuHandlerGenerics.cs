using ClassLibrary;

namespace PNIPU_C__LAB_11
{
    internal class MenuHandlerGenerics<T> where T : Person, IInit, new()
    {
        private static SortedDictionaryManager<T> _manager = new SortedDictionaryManager<T>();

        private bool _exit = false;

        public void ShowMenu()
        {
            while (!_exit)
            {
                Console.WriteLine($"\nМеню: \nУправление объектами  {typeof(T).Name}");
                Console.WriteLine("1. Добавить объект");
                Console.WriteLine("2. Удалить объект");
                Console.WriteLine("3. Показать все элементы");
                Console.WriteLine("4. Количество объектов определенного типа");
                Console.WriteLine("5. Печать объектов определенного типа");
                Console.WriteLine("6. Клонировать коллекцию");
                Console.WriteLine("7. Сортировать и выполнить поиск");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите действие: ");

                HandleChoice(Console.ReadLine());
            }
        }

        private void HandleChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    _manager.AddObject();
                    break;
                case "2":
                    Console.Write("Введите ID для удаления: ");
                    if (int.TryParse(Console.ReadLine(), out int id))
                        _manager.RemoveObject(id);
                    else
                        Console.WriteLine("Ошибка ввода.");
                    break;
                case "3":
                    _manager.PrintAll();
                    break;
                case "4":
                    Console.Write("Введите тип объекта (Person, Worker, Engineer, Administration): ");
                    _manager.CountByType(Console.ReadLine());
                    break;
                case "5":
                    Console.Write("Введите тип объекта для вывода: ");
                    _manager.PrintByType(Console.ReadLine());
                    break;
                case "6":
                    _manager.CloneCollection();
                    break;
                case "7":
                    Console.Write("Введите возраст для поиска: ");
                    if (int.TryParse(Console.ReadLine(), out int age))
                        _manager.SortAndSearch(age);
                    else
                        Console.WriteLine("Ошибка ввода.");
                    break;
                case "0":
                    Console.WriteLine("Выход...");
                    _exit = true;
                    break;
                default:
                    Console.WriteLine("Некорректный ввод, попробуйте снова.");
                    break;
            }
        }
    }
}
