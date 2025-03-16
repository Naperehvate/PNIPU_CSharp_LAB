using ClassLibrary;
using System.Collections;

namespace PNIPU_C__LAB_11
{
    internal class StackManager
    {
        private Stack _stack = new Stack();

        public void AddObject(IInit obj)
        {
            obj.RandomInit();
            _stack.Push(obj);
            Console.WriteLine("Объект добавлен.");
        }

        public void RemoveObject()
        {
            if (_stack.Count > 0)
            {
                var removedObj = _stack.Pop();
                Console.WriteLine($"Удален объект: {removedObj}");
            }
            else
            {
                Console.WriteLine("Коллекция пуста.");
            }
        }

        public void PrintAll()
        {
            if (_stack.Count == 0)
            {
                Console.WriteLine("Коллекция пуста.");
                return;
            }

            foreach (var obj in _stack)
            {
                Console.WriteLine(obj);
            }
        }

        public void CountByType(string type)
        {
            int count = _stack.Cast<object>().Count(obj => obj.GetType().Name == type);
            Console.WriteLine($"Количество объектов типа {type}: {count}");
        }

        public void PrintByType(string type)
        {
            foreach (var obj in _stack)
            {
                if (obj.GetType().Name == type)
                {
                    Console.WriteLine(obj);
                }
            }
        }

        public void CloneCollection()
        {
            Stack clonedStack = new Stack(_stack.ToArray());
            Console.WriteLine("Коллекция клонирована. Вывод клонов:");
            foreach (var obj in clonedStack)
            {
                Console.WriteLine(obj);
            }
        }

        public void SortAndSearch(int ageToFind)
        {
            Person[] arr = _stack.OfType<Person>().ToArray();
            Array.Sort(arr);
            Console.WriteLine("Отсортированная коллекция:");
            foreach (var obj in arr)
            {
                Console.WriteLine(obj);
            }

            Person found = Array.Find(arr, p => p.Age == ageToFind);

            Console.WriteLine(found != null ? $"Найден объект: {found}" : "Объект с таким возрастом не найден.");
        }
    }
}
