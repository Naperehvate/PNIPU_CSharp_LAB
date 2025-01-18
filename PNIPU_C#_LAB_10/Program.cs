using ClassLibrary;
using PNIPU_C__LAB_10;

Console.BufferHeight = 5000;
#region Примеры полиморфизма

Person[] employees = new Person[4];

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
    Console.WriteLine(new string('-', 30));
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
}
Console.WriteLine(new string('\n', 2));
Console.WriteLine(new string('=', 100));

Console.WriteLine("\nЗадание 1 завершено...");
Console.ReadKey();
Console.WriteLine(new string('\n', 2));
#endregion

#region Выполнение запросов

Console.WriteLine("=== Выполнение запросов ===");
QueryExecutor.ExecuteQueries(employees);

Console.WriteLine(new string('\n', 2));
Console.WriteLine(new string('=', 100));

Console.WriteLine("\nЗадание 2 завершено...");
Console.ReadKey();
Console.WriteLine(new string('\n', 2));
#endregion

#region Примеры интерфейсов

AdditionalClass additionalClass = new();
additionalClass.RandomInit();
Console.WriteLine($"{additionalClass}\n");

Person[] personObjects = new Person[]
{
    new Person { Name = "Alex", Age = 35 },
    new Worker { Name = "Bob", Age = 30, Position = "Manager" },
    new Engineer { Name = "Eugene", Age = 28, Specialty = "IT" },
    new Administration { Name = "Diana", Age = 25, Department = "HR" }
};

// Инициализация объектов
//foreach (var obj in personObjects)
//{
//    obj.RandomInit();
//}

// Вывод информации о всех объектах
Console.WriteLine("=== Все объекты ===");
foreach (var obj in personObjects)
{
    Console.WriteLine(obj.ToString());
    
}

// Сортировка объектов по возрасту
Array.Sort(personObjects);

Console.WriteLine("\n=== Объекты после сортировки по возрасту ===");
foreach (var obj in personObjects)
{
    Console.WriteLine(obj.ToString());
}

// Сортировка объектов по возрасту через IComparer
Array.Sort(personObjects, new AgeComparer());

Console.WriteLine("\n=== Объекты после сортировки по возрасту (через IComparer) ===");
foreach (var obj in personObjects)
{
    Console.WriteLine(obj.ToString());
}


// Бинарный поиск объекта по возрасту
int index = Array.BinarySearch(personObjects, new Person { Age = 30 }, new AgeComparer());
Console.WriteLine(index >= 0
    ? $"\nОбъект с возрастом 30 найден на индексе: {index}"
    : "\nОбъект с возрастом 30 не найден.");


// Создание оригинального объекта
Person originalPerson = new Person("John", 30);
Console.WriteLine("Оригинальный объект:");
originalPerson.Show();

// Создание поверхностной копии
Person shallowCopy = originalPerson.ShallowCopy();
Console.WriteLine("\nПоверхностная копия:");
shallowCopy.Show();

// Создание глубокой копии
Person deepCopy = (Person)originalPerson.Clone();
Console.WriteLine("\nГлубокая копия:");
deepCopy.Show();

// Изменение данных в оригинальном объекте
originalPerson.Name = "Alice";
originalPerson.Age = 40;

// Показ изменений в оригинале и копиях
Console.WriteLine("\nПосле изменения оригинального объекта:");
Console.WriteLine("Оригинальный объект:");
originalPerson.Show();

Console.WriteLine("\nПоверхностная копия:");
shallowCopy.Show();

Console.WriteLine("\nГлубокая копия:");
deepCopy.Show();

Console.WriteLine(new string('\n', 2));
Console.WriteLine(new string('=', 100));

Console.WriteLine("\nЗадание 3 завершено...");
Console.ReadKey();
Console.WriteLine(new string('\n', 2));



IInit[] objects = new IInit[5];
objects[0] = new Person();
objects[1] = new Worker();
objects[2] = new Engineer();
objects[3] = new Administration();
objects[4] = new AdditionalClass();

// Инициализация объектов
foreach (var obj in objects)
{
    obj.RandomInit();
    Console.WriteLine(obj.ToString());
}

// Сортировка объектов по возрасту через IComparer
Array.Sort(objects, new AgeComparer());

Console.WriteLine("\n=== Объекты после сортировки по возрасту (через IComparer) ===");
foreach (var obj in objects)
{
    Console.WriteLine(obj.ToString());
}


Console.WriteLine('\n');
Console.ReadKey();

#endregion