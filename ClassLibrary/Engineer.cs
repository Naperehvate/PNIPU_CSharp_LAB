using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Engineer : Worker
    {
        public string Specialty { get; set; }

        public Engineer() { }

        public Engineer(string name, int age, string position, string specialty)
            : base(name, age, position)
        {
            Specialty = specialty;
        }

        public override void Show()
        {
            Console.WriteLine($"Engineer: Имя = {Name}, Возраст = {Age}, Должность = {Position}, Специальность = {Specialty}");
        }

        public override void Init()
        {
            base.Init();
            Console.Write("Введите специальность: ");
            Specialty = Console.ReadLine();
        }

        public override void RandomInit()
        {
            base.RandomInit();
            string[] specialties = { "IT", "Механик", "Электрик" };
            Specialty = specialties[new Random().Next(specialties.Length)];
        }
    }
}
