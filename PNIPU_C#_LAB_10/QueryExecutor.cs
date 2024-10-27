using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNIPU_C__LAB_10
{
    internal class QueryExecutor
    {
        public static void ExecuteQueries(Person[] employees)
        {
            // Подсчитать количество объектов Worker
            int countWorkers = 0;
            foreach (var employee in employees)
            {
                if (employee is Worker) countWorkers++;
            }
            Console.WriteLine($"Количество работников: {countWorkers}");

            // Показать информацию об объектах Administration
            Console.WriteLine("\nСотрудники отдела Администрации:");
            foreach (var employee in employees)
            {
                if (employee is Administration admin)
                {
                    admin.Show();
                }
            }

            // Показать Инженеров по специальности
            Console.WriteLine("\nВведите специальность для поиска инженеров:");
            string specialty = Console.ReadLine();
            Console.WriteLine($"\nИнженеры со специальностью {specialty}:");
            foreach (var employee in employees)
            {
                if (employee is Engineer engineer && engineer.Specialty == specialty)
                {
                    engineer.Show();
                }
            }
        }
    }
}
