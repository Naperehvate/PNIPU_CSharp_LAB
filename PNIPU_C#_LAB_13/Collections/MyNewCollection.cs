using ClassLibrary;

namespace PNIPU_C__LAB_13
{
    public class MyNewCollection<T> : MyCollection<T> where T : class, ICloneable, IInit
    {
        public event CollectionHandler CollectionCountChanged;
        public event CollectionHandler CollectionReferenceChanged;

        public MyNewCollection(string name) : base(name) { }

        public override void Add(T item)
        {
            base.Add(item);
            CollectionCountChanged?.Invoke(this, new(Name, "Добавление", item));
        }

        public override void AddDefaults(int count)
        {
            for (int i = 0; i < count; i++)
            {
                T obj = (T)Activator.CreateInstance(typeof(T));
                obj.RandomInit();
                base.Add(obj);
                CollectionCountChanged?.Invoke(this, new(Name, "Добавление по умолчанию", obj));
            }
        }

        public new bool Remove(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                var removed = items[index];
                items.RemoveAt(index);
                CollectionCountChanged?.Invoke(this, new(Name, "Удаление", removed));
                return true;
            }
            return false;
        }

        public override T this[int index]
        {
            get => base[index];
            set
            {
                base[index] = value;
                CollectionReferenceChanged?.Invoke(this, new(Name, "Замена элемента", value));
            }
        }
    }

}
