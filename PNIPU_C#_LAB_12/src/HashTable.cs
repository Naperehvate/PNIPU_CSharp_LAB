using ClassLibrary;

namespace PNIPU_C__LAB_12
{
    internal class HashTable
    {
        private class HashNode
        {
            public string Key { get; }
            public Person Value { get; }
            public bool IsDeleted { get; set; }

            public HashNode(string key, Person value)
            {
                Key = key;
                Value = value;
                IsDeleted = false;
            }
        }

        private HashNode[] table;
        private int capacity;
        private int size;
        private const double LoadFactor = 0.75;

        public HashTable(int capacity)
        {
            this.capacity = capacity;
            table = new HashNode[capacity];
            size = 0;
        }

        private int Hash(string key, int attempt)
        {
            int hash1 = Math.Abs(key.GetHashCode()) % capacity;
            int hash2 = 1 + (Math.Abs(key.GetHashCode()) % (capacity - 1));
            return (hash1 + attempt * hash2) % capacity;
        }

        public void Add(string key, Person value)
        {
            if (size >= capacity * LoadFactor)
            {
                Console.WriteLine("Хеш-таблица переполнена! Невозможно добавить элемент.");
                return;
            }

            int attempt = 0;
            int index;
            do
            {
                index = Hash(key, attempt);
                if (table[index] == null || table[index].IsDeleted)
                {
                    table[index] = new HashNode(key, value);
                    size++;
                    return;
                }
                attempt++;
            } while (attempt < capacity);

            Console.WriteLine("Не удалось вставить элемент.");
        }

        public Person Find(string key)
        {
            int attempt = 0;
            int index;
            do
            {
                index = Hash(key, attempt);
                if (table[index] == null)
                    return null;
                if (table[index].Key == key && !table[index].IsDeleted)
                    return table[index].Value;
                attempt++;
            } while (attempt < capacity);
            return null;
        }

        public bool Remove(string key)
        {
            int attempt = 0;
            int index;
            do
            {
                index = Hash(key, attempt);
                if (table[index] == null)
                    return false;
                if (table[index].Key == key && !table[index].IsDeleted)
                {
                    table[index].IsDeleted = true;
                    size--;
                    return true;
                }
                attempt++;
            } while (attempt < capacity);
            return false;
        }

        public void PrintTable()
        {
            Console.WriteLine("Хеш-таблица:");
            for (int i = 0; i < capacity; i++)
            {
                if (table[i] != null && !table[i].IsDeleted)
                    Console.WriteLine($"[{i}]: {table[i].Key} -> {table[i].Value}");
                else
                    Console.WriteLine($"[{i}]: пусто");
            }
        }
    }
}
