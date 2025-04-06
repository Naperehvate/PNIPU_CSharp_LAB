using ClassLibrary;
using System.Collections;

namespace PNIPU_C__LAB_13
{
    public class Collection<T> : IEnumerable<T> where T : ICloneable, IInit
    {
        protected List<T> items = new();

        public int Length => items.Count;

        public virtual void Add(T item) => items.Add(item);

        public virtual void AddDefaults(int count)
        {
            for (int i = 0; i < count; i++)
            {
                T obj = (T)Activator.CreateInstance(typeof(T));
                obj.RandomInit();
                Add(obj);
            }
        }

        public virtual bool Remove(T item) => items.Remove(item);

        public virtual void Clear() => items.Clear();

        public virtual void SortBy<K>(Func<T, K> keySelector) where K : IComparable<K>
        {
            items.Sort((x, y) => keySelector(x).CompareTo(keySelector(y)));
        }

        public IEnumerator<T> GetEnumerator() => items.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
