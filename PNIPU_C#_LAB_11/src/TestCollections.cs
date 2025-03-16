using ClassLibrary;
using System.Diagnostics;

namespace PNIPU_C__LAB_11
{
    internal class TestCollections<TBase, TDerived>

        where TBase : Person
        where TDerived : TBase, IInit, new()
    {
        private List<TDerived> listObjects = new List<TDerived>();
        private List<string> listStrings = new List<string>();
        private Dictionary<TBase, TDerived> dictObjects = new Dictionary<TBase, TDerived>();
        private Dictionary<string, TDerived> dictStrings = new Dictionary<string, TDerived>();

        public TestCollections(int count)
        {
            for (int i = 0; i < count; i++)
            {
                TDerived obj = new TDerived();
                obj.RandomInit();
                listObjects.Add(obj); 
                string key = obj.ToString();
                if (dictStrings.ContainsKey(key))
                {
                   
                    key = $"{key}_{Guid.NewGuid()}";
                }
                dictStrings.Add(key, obj);
                listStrings.Add(key);
                if (!dictObjects.ContainsKey((TBase)obj))
                {
                    dictObjects.Add((TBase)obj, obj);
                }
            }
        }

        public void AddElement(TDerived obj)
        {
            listObjects.Add(obj);
            string key = obj.ToString();

            // Проверка на дубликат
            if (dictStrings.ContainsKey(key))
            {
                key = $"{key}_{Guid.NewGuid()}";
            }

            listStrings.Add(key);
            dictObjects.Add((TBase)obj, obj);
            dictStrings.Add(key, obj);
        }

        public void RemoveElement(TDerived obj)
        { 
            listObjects.Remove(obj);
            listStrings.Remove(obj.ToString());
            if (dictObjects.ContainsKey((TBase)obj))
            {
                dictObjects.Remove((TBase)obj);
            }
            if (dictStrings.ContainsKey(obj.ToString()))
            {
                dictStrings.Remove(obj.ToString());
            }
        }

        public void MeasureSearchTime()
        {
            if (listObjects.Count == 0) return;

            TDerived first = listObjects[0];
            TDerived middle = listObjects[listObjects.Count / 2];
            TDerived last = listObjects[listObjects.Count - 1];
            TDerived notExists = new TDerived();
            notExists.RandomInit();

            MeasureTime(() => listObjects.Contains(first), "List<T> (первый)");
            MeasureTime(() => listObjects.Contains(middle), "List<T> (средний)");
            MeasureTime(() => listObjects.Contains(last), "List<T> (последний)");
            MeasureTime(() => listObjects.Contains(notExists), "List<T> (отсутствует)");

            MeasureTime(() => listStrings.Contains(first.ToString()), "List<string> (первый)");
            MeasureTime(() => listStrings.Contains(middle.ToString()), "List<string> (средний)");
            MeasureTime(() => listStrings.Contains(last.ToString()), "List<string> (последний)");
            MeasureTime(() => listStrings.Contains(notExists.ToString()), "List<string> (отсутствует)");

            MeasureTime(() => dictObjects.ContainsKey(first), "Dictionary<TBase,TDerived> (первый)");
            MeasureTime(() => dictObjects.ContainsKey(middle), "Dictionary<TBase,TDerived> (средний)");
            MeasureTime(() => dictObjects.ContainsKey(last), "Dictionary<TBase,TDerived> (последний)");
            MeasureTime(() => dictObjects.ContainsKey(notExists), "Dictionary<TBase,TDerived> (отсутствует)");


            MeasureTime(() => dictStrings.ContainsKey(first.ToString()), "Dictionary<string,TDerived> (первый)");
            MeasureTime(() => dictStrings.ContainsKey(middle.ToString()), "Dictionary<string,TDerived> (средний)");
            MeasureTime(() => dictStrings.ContainsKey(last.ToString()), "Dictionary<string,TDerived> (последний)");
            MeasureTime(() => dictStrings.ContainsKey(notExists.ToString()), "Dictionary<string,TDerived> (отсутствует)");
        }

        private void MeasureTime(Func<bool> searchMethod, string description)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            bool result = searchMethod();
            stopwatch.Stop();
            Console.WriteLine($"{description}: найден = {result}, время = {stopwatch.ElapsedTicks} тиков");
        }

        public List<TDerived> ListT => listObjects;
    }
}
