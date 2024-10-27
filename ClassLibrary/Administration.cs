namespace ClassLibrary
{
    public class Administration : Person
    {
        public string Department { get; set; }

        public Administration()
        { }

        public Administration(string name, int age, string department) : base(name, age)
        {
            Department = department;
        }

        public override void Show()
        {
            Console.WriteLine($"Administration: Имя = {Name}, Возраст = {Age}, Отдел = {Department}");
        }

        public override void Init()
        {
            base.Init();
            Console.Write("Введите отдел: ");
            Department = Console.ReadLine();
        }

        public override void RandomInit()
        {
            base.RandomInit();
            string[] departments = { "HR", "Финансы", "Администрация" };
            Department = departments[new Random().Next(departments.Length)];
        }
    }
}