

namespace PNIPU_C__LAB_13
{
    public class JournalEntry
    {
        public string CollectionName { get; set; }
        public string ChangeType { get; set; }
        public string ObjectInfo { get; set; }

        public JournalEntry(string name, string change, string obj)
        {
            CollectionName = name;
            ChangeType = change;
            ObjectInfo = obj;
        }

        public override string ToString()
        {
            return $"Коллекция: {CollectionName}, Тип изменения: {ChangeType}, Объект: {ObjectInfo}";
        }
    }

}
