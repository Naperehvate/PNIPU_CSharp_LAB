

namespace PNIPU_C__LAB_13
{
    public class Journal
    {
        private List<JournalEntry> entries = new();

        public void CollectionEventHandler(object source, CollectionHandlerEventArgs args)
        {
            entries.Add(new JournalEntry(args.CollectionName, args.ChangeType, args.ChangedObject.ToString()));
        }

        public override string ToString()
        {
            return string.Join("\n", entries);
        }
    }


}
