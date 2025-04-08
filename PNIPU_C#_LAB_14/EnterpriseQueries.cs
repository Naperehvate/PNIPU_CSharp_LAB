using ClassLibrary;

namespace PNIPU_C__LAB_14
{
    public static class EnterpriseQueries
    {
        public static void SelectionQuery(Dictionary<string, Stack<Person>> enterprise)
        {
            var resultLinq = (from d in enterprise.Values
                              from p in d
                              where p.Age > 40
                              select p).ToList();

            Console.WriteLine("LINQ:");
            resultLinq.ForEach(Console.WriteLine);

            var resultExt = enterprise.Values.SelectMany(s => s).Where(p => p.Age > 40).ToList();

            Console.WriteLine("Методы расширения:");
            resultExt.ForEach(Console.WriteLine);
        }

        public static void CountEngineers(Dictionary<string, Stack<Person>> enterprise)
        {
            var countLinq = (from d in enterprise.Values
                             from p in d
                             where p is Engineer
                             select p).Count();

            Console.WriteLine($"LINQ: Инженеров = {countLinq}");

            var countExt = enterprise.Values.SelectMany(s => s).Count(p => p is Engineer);
            Console.WriteLine($"Методы расширения: Инженеров = {countExt}");
        }

        public static void IntersectDepartments(Dictionary<string, Stack<Person>> enterprise, string dep1, string dep2)
        {
            if (!enterprise.ContainsKey(dep1) || !enterprise.ContainsKey(dep2))
            {
                Console.WriteLine("Указанных отделов не существует.");
                return;
            }

            var stack1 = enterprise[dep1];
            var stack2 = enterprise[dep2];

            var intersectLinq = (from p in stack1
                                 where stack2.Contains(p)
                                 select p).ToList();

            Console.WriteLine("LINQ:");
            intersectLinq.ForEach(Console.WriteLine);

            var intersectExt = stack1.Intersect(stack2).ToList();
            Console.WriteLine("Методы расширения:");
            intersectExt.ForEach(Console.WriteLine);
        }

        public static void MaxAgeQuery(Dictionary<string, Stack<Person>> enterprise)
        {
            var maxLinq = (from p in enterprise.Values.SelectMany(s => s)
                           select p.Age).Max();

            Console.WriteLine($"LINQ: Макс возраст = {maxLinq}");

            var maxExt = enterprise.Values.SelectMany(s => s).Max(p => p.Age);
            Console.WriteLine($"Методы расширения: Макс возраст = {maxExt}");
        }

        public static void GroupByType(Dictionary<string, Stack<Person>> enterprise)
        {
            var groupLinq = from p in enterprise.Values.SelectMany(s => s)
                            group p by p.GetType().Name into g
                            select g;

            Console.WriteLine("LINQ:");
            foreach (var group in groupLinq)
            {
                Console.WriteLine($"Тип: {group.Key}, Кол-во: {group.Count()}");
                foreach (var p in group)
                    Console.WriteLine("  " + p);
            }

            var groupExt = enterprise.Values.SelectMany(s => s).GroupBy(p => p.GetType().Name);
            Console.WriteLine("Методы расширения:");
            foreach (var group in groupExt)
            {
                Console.WriteLine($"Тип: {group.Key}, Кол-во: {group.Count()}");
                foreach (var p in group)
                    Console.WriteLine("  " + p);
            }
        }
    }
}
