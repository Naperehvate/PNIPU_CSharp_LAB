using ClassLibrary;

namespace PNIPU_C__LAB_11
{
    internal class SortedDictionaryManager<T> where T : Person, IInit, new()
    {
        private SortedDictionary<int, T> _dictionary = new SortedDictionary<int, T>();
        private int _idCounter = 1;

        public void AddObject()
        {
            T obj = new T();
            obj.RandomInit();
            _dictionary.Add(_idCounter++, obj);
            Console.WriteLine("Объект добавлен.");
        }

        public void RemoveObject(int id)
        {
            if (_dictionary.Remove(id))
                Console.WriteLine($"Объект с ID {id} удален.");
            else
                Console.WriteLine("Объект с таким ID не найден.");
        }

        public void PrintAll()
        {
            if (_dictionary.Count == 0)
            {
                Console.WriteLine("Коллекция пуста.");
                return;
            }

            foreach (var pair in _dictionary)
            {
                Console.WriteLine($"ID: {pair.Key}, {pair.Value}");
            }
        }

        public void CountByType(string type)
        {
            int count = _dictionary.Values.Count(obj => obj.GetType().Name == type);
            Console.WriteLine($"Количество объектов типа {type}: {count}");
        }

        public void PrintByType(string type)
        {
            foreach (var obj in _dictionary.Values.Where(o => o.GetType().Name == type))
            {
                Console.WriteLine(obj);
            }
        }

        public void CloneCollection()
        {
            var clonedDictionary = new SortedDictionary<int, T>(_dictionary.ToDictionary(entry => entry.Key, entry => (T)entry.Value.Clone()));
            Console.WriteLine("Коллекция клонирована. Вывод клонов:");
            foreach (var pair in clonedDictionary)
            {
                Console.WriteLine($"ID: {pair.Key}, {pair.Value}");
            }
        }

        public void SortAndSearch(int age)
        {
            var sortedList = _dictionary.Values.OrderBy(p => p.Age).ToList();
            Console.WriteLine("Отсортированная коллекция:");
            foreach (var obj in sortedList)
            {
                Console.WriteLine(obj);
            }

            var found = sortedList.FirstOrDefault(p => p.Age == age);
            Console.WriteLine(found != null ? $"Найден объект: {found}" : "Объект с таким возрастом не найден.");
        }
    }
}
