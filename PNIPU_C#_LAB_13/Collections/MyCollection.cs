using ClassLibrary;

namespace PNIPU_C__LAB_13
{
    public class MyCollection<T> : Collection<T> where T : ICloneable, IInit
    {
        public string Name { get; set; }

        public MyCollection(string name)
        {
            Name = name;
        }

        public virtual T this[int index]
        {
            get => items[index];
            set => items[index] = value;
        }

        public bool Remove(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                items.RemoveAt(index);
                return true;
            }
            return false;
        }
    }

}
