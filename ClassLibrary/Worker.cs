namespace ClassLibrary
{
    public class Worker : Person
    {
        public string Position { get; set; }

        public Worker()
        { }

        public Worker(string name, int age, string position) : base(name, age)
        {
            Position = position;
        }

        public Worker(Worker other) : base(other)
        {
            Position = other.Position;
        }

        public override void Show()
        {
            Console.WriteLine($"Worker: Имя = {Name}, Возраст = {Age}, Должность = {Position}");
        }

        public override void Init()
        {
            base.Init();
            Console.Write("Введите должность: ");
            Position = Console.ReadLine();
        }

        public override void RandomInit()
        {
            base.RandomInit();
            string[] positions = { "Инженер", "Менеджер", "Техник" };
            Position = positions[new Random().Next(positions.Length)];
        }

        public override string ToString()
        {
            return $"Worker: Name = {Name}, Age = {Age}, Position = {Position}";
        }
    }
}