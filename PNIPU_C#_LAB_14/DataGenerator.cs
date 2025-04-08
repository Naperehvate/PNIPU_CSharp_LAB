using ClassLibrary;

namespace PNIPU_C__LAB_14
{
    public static class DataGenerator
    {
        public static Dictionary<string, Stack<Person>> GenerateEnterprise()
        {
            var enterprise = new Dictionary<string, Stack<Person>>();
            var departments = new[] { "IT", "HR", "Finance", "Engineering" };
            var rand = new Random();

            foreach (string dep in departments)
            {
                var stack = new Stack<Person>();
                for (int i = 0; i < 10; i++)
                {
                    Person p = rand.Next(3) switch
                    {
                        0 => new Worker(),
                        1 => new Engineer(),
                        _ => new Administration()
                    };
                    p.RandomInit();
                    stack.Push(p);
                }
                enterprise[dep] = stack;
            }

            return enterprise;
        }
    }
}
