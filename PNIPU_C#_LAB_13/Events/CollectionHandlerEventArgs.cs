

namespace PNIPU_C__LAB_13
{
    public class CollectionHandlerEventArgs : EventArgs
    {
        public string CollectionName { get; set; }
        public string ChangeType { get; set; }
        public object ChangedObject { get; set; }

        public CollectionHandlerEventArgs() { }

        public CollectionHandlerEventArgs(string name, string type, object obj)
        {
            CollectionName = name;
            ChangeType = type;
            ChangedObject = obj;
        }

        public override string ToString()
        {
            return $"Коллекция: {CollectionName}, Изменение: {ChangeType}, Объект: {ChangedObject}";
        }
    }

}