using ClassLibrary;

Person[] employees = new Person[4];

// Заполняем массив сотрудниками различных типов
employees[0] = new Person();
employees[0].RandomInit();

employees[1] = new Worker();
employees[1].RandomInit();

employees[2] = new Engineer();
employees[2].RandomInit();

employees[3] = new Administration();
employees[3].RandomInit();

// Отображаем информацию о сотрудниках
Console.WriteLine("=== Набор сотрудников ===");
foreach (var employee in employees)
{
    Console.WriteLine(new string('-', 30)); // Разделитель
    employee.Show();
}
Console.WriteLine(new string('-', 30) + "\n");

// Демонстрация полиморфизма
Console.WriteLine("=== Демонстрация полиморфизма ===");
foreach (var employee in employees)
{
    Console.WriteLine(new string('=', 30));
    if (employee is Worker worker)
    {
        Console.WriteLine(">> Поведение, характерное для работника:");
        worker.Show();
    }
    else
    {
        Console.WriteLine(">> Поведение, характерное для человека:");
        employee.Show();
    }
    System.Threading.Thread.Sleep(500); // Задержка для эффекта
}
Console.WriteLine(new string('=', 30));

// Завершение программы
Console.WriteLine("\nНажмите любую клавишу для выхода...");
Console.ReadKey();