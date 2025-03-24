using System.Collections;

namespace PNIPU_C__LAB_12
{
    internal class MyCollection<T> : IEnumerable<T>, ICollection<T> where T : ICloneable
    {
        private List<T> _items;

        // Конструкторы
        public MyCollection()
        {
            _items = new List<T>();
        }

        public MyCollection(int capacity)
        {
            _items = new List<T>(capacity);
        }

        public MyCollection(MyCollection<T> collection)
        {
            _items = new List<T>(collection._items);
        }

        // Добавление элементов
        public void Add(T item)
        {
            _items.Add(item);
        }

        public void AddRange(IEnumerable<T> items)
        {
            _items.AddRange(items);
        }

        // Удаление элементов
        public bool Remove(T item)
        {
            return _items.Remove(item);
        }

        public void Clear()
        {
            _items.Clear();
        }

        // Поиск элемента
        public bool Contains(T item)
        {
            return _items.Contains(item);
        }

        // Глубокое копирование
        public MyCollection<T> DeepClone()
        {
            MyCollection<T> clone = new MyCollection<T>();
            foreach (T item in _items)
            {
                clone.Add((T)item.Clone());
            }
            return clone;
        }

        // Поверхностное копирование
        public MyCollection<T> ShallowCopy()
        {
            MyCollection<T> copy = new MyCollection<T>();
            copy._items = new List<T>(_items); // Копируем ссылки
            return copy;
        }

        // Реализация IEnumerable<T>
        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Реализация ICollection<T>
        public int Count => _items.Count;
        public bool IsReadOnly => false;

        public void CopyTo(T[] array, int arrayIndex)
        {
            _items.CopyTo(array, arrayIndex);
        }
    }
}
