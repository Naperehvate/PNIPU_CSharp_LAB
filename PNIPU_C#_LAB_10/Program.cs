using ClassLibrary;
using PNIPU_C__LAB_10;

#region Примеры полиморфизма


//Person[] employees = new Person[4];

//employees[0] = new Person();
//employees[0].RandomInit();

//employees[1] = new Worker();
//employees[1].RandomInit();

//employees[2] = new Engineer();
//employees[2].RandomInit();

//employees[3] = new Administration();
//employees[3].RandomInit();

//// Отображаем информацию о сотрудниках
//Console.WriteLine("=== Набор сотрудников ===");
//foreach (var employee in employees)
//{
//    Console.WriteLine(new string('-', 30));
//    employee.Show();
//}
//Console.WriteLine(new string('-', 30) + "\n");

//// Демонстрация полиморфизма
//Console.WriteLine("=== Демонстрация полиморфизма ===");
//foreach (var employee in employees)
//{
//    Console.WriteLine(new string('=', 30));
//    if (employee is Worker worker)
//    {
//        Console.WriteLine(">> Поведение, характерное для работника:");
//        worker.Show();
//    }
//    else
//    {
//        Console.WriteLine(">> Поведение, характерное для человека:");
//        employee.Show();
//    }
//}
//Console.WriteLine(new string('=', 30));


#endregion

#region Выполнение запросов


//Console.WriteLine("=== Выполнение запросов ===");
//QueryExecutor.ExecuteQueries(employees);


#endregion

#region Примеры интерфейсов

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
}

// Вывод информации о всех объектах
Console.WriteLine("=== Все объекты ===");
foreach (var obj in objects)
{
    Console.WriteLine(obj.ToString());
}

// Сортировка объектов по возрасту
Array.Sort(objects, (x, y) => ((Person)x).Age.CompareTo(((Person)y).Age));

Console.WriteLine("\n=== Объекты после сортировки по возрасту ===");
foreach (var obj in objects)
{
    Console.WriteLine(obj.ToString());
}

// Бинарный поиск
int index = Array.BinarySearch(objects, new Person { Age = 30 }, new AgeComparer());
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


Console.WriteLine("\nНажмите любую клавишу для выхода...");
Console.ReadKey();

#endregion