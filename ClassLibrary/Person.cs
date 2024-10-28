namespace ClassLibrary
{
    public class Person : IInit, IComparable<Person>, ICloneable
    {
        private string _name;
        private int _age;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Имя не может быть пустым");
                _name = value;
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value < 0 || value > 120)
                    throw new ArgumentOutOfRangeException("Возраст должен быть от 0 до 120 лет");
                _age = value;
            }
        }

        public Person()
        { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person(Person other)
        {
            Name = other.Name;
            Age = other.Age;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Person: Имя = {Name}, Возраст = {Age}");
        }

        public virtual void Init()
        {
            Console.Write("Введите Имя: ");
            Name = Console.ReadLine();
            Console.Write("Введите возра: ");
            Age = int.Parse(Console.ReadLine());
        }

        public virtual void RandomInit()
        {
            Random rand = new Random();
            Name = "Person_" + rand.Next(1000);
            Age = rand.Next(18, 70);
        }

        public override bool Equals(object obj)
        {
            if (obj is Person person)
            {
                return Name == person.Name && Age == person.Age;
            }
            return false;
        }

        public int CompareTo(Person? other)
        {
            return Age.CompareTo(other.Age);
        }

        // Реализация метода глубокого копирования
        public object Clone()
        {
            return new Person(this);
        }

        // Реализация метода поверхностного копирования
        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Person: Name = {Name}, Age = {Age}";
        }
    }
}