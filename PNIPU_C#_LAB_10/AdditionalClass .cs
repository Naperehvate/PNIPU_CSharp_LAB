using ClassLibrary;

namespace PNIPU_C__LAB_10
{
    internal class AdditionalClass : IInit
    {
        public string Description { get; set; }

        public void Init()
        {
            Console.Write("Введите описание: ");
            Description = Console.ReadLine();
        }

        public void RandomInit()
        {
            Description = "Дополнительный объект с описанием_" + new Random().Next(1, 100);
        }

        public override string ToString()
        {
            return $"Описание: {Description}";
        }
    }
}