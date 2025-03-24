#define RUN_TUSK_4

using ClassLibrary;
using PNIPU_C__LAB_12;



#region Task1
#if RUN_TUSK_1

DoublyLinkedList list = new DoublyLinkedList();

list.Add(new Person("Иван", 30));
list.Add(new Worker("Петр", 25, "Инженер"));
list.Add(new Engineer("Сергей", 40, "Техник", "IT"));
list.Add(new Administration("Анна", 35, "HR"));

// Распечатываем список
Console.WriteLine("Список до добавления нового элемента:");
list.PrintList();

// Добавляем новый элемент после элемента с заданным именем
list.InsertAfter("Петр", new Worker("Мария", 28, "Менеджер"));

// Распечатываем список после добавления нового элемента
Console.WriteLine("\nСписок после добавления нового элемента:");
list.PrintList();

// Удаляем список из памяти
list.Clear();
Console.WriteLine("\nСписок удален из памяти.");

#endif
#endregion

#region Task2
#if RUN_TUSK_2

Person[] people = new Person[]
{
            new Person("Иван", 30),
            new Worker("Петр", 25, "Инженер"),
            new Engineer("Сергей", 40, "Техник", "IT"),
            new Administration("Анна", 35, "HR"),
            new Person("Мария", 28),
            new Worker("Алексей", 45, "Менеджер")
};

// сбалансированное дерево
BinaryTree tree = new BinaryTree();
TreeNode root = tree.CreateBalancedTree(people, 0, people.Length - 1);

Console.WriteLine("Идеально сбалансированное дерево:");
tree.PrintTree(root);

// количество листьев
int leafCount = tree.CountLeaves(root);
Console.WriteLine($"\nКоличество листьев в дереве: {leafCount}");

// преобразуем дерево в дерево поиска
tree.ConvertToSearchTree(ref root);
Console.WriteLine("\nДерево поиска:");
tree.PrintTree(root);

// Удаляем дерево из памяти
tree.ClearTree(ref root);
Console.WriteLine("\nДерево удалено из памяти.");

#endif
#endregion

#region Task3
#if RUN_TUSK_3

HashTable hashTable = new HashTable(10);

hashTable.Add("Иван", new Person("Иван", 30));
hashTable.Add("Петр", new Worker("Петр", 25, "Инженер"));
hashTable.Add("Сергей", new Engineer("Сергей", 40, "Техник", "IT"));
hashTable.Add("Анна", new Administration("Анна", 35, "HR"));

hashTable.PrintTable();

// Поиск элемента
Console.WriteLine("\nПоиск элемента 'Сергей':");
var found = hashTable.Find("Сергей");
Console.WriteLine(found != null ? $"Найден: {found}" : "Элемент не найден");

// Удаление элемента
Console.WriteLine("\nУдаление 'Сергей':");
if (hashTable.Remove("Сергей"))
    Console.WriteLine("Элемент удален.");
else
    Console.WriteLine("Не удалось удалить элемент.");

hashTable.PrintTable();

// Повторный поиск
Console.WriteLine("\nПовторный поиск элемента 'Сергей':");
found = hashTable.Find("Сергей");
Console.WriteLine(found != null ? $"Найден: {found}" : "Элемент не найден");

// Попытка переполнения
Console.WriteLine("\nПопытка заполнить хеш-таблицу:");
for (int i = 0; i < 10; i++)
    hashTable.Add($"Person_{i}", new Person($"Person_{i}", 20 + i));

hashTable.PrintTable();


#endif
#endregion

#region Task4
#if RUN_TUSK_4

MyCollection<Person> people = new MyCollection<Person>
{
    new Person("Иван", 30),
    new Worker("Петр", 25, "Инженер"),
    new Engineer("Сергей", 40, "Техник", "IT"),
    new Administration("Анна", 35, "HR")
};

Console.WriteLine("Содержимое коллекции:");
foreach (var person in people)
{
    person.Show();
}

Console.WriteLine("\nПоиск элемента (Иван, 30):");
Person search = new Person("Иван", 30);
Console.WriteLine(people.Contains(search) ? "Элемент найден" : "Элемент не найден");

Console.WriteLine("\nУдаление элемента (Иван, 30):");
people.Remove(search);

Console.WriteLine("Коллекция после удаления:");
foreach (var person in people)
{
    person.Show();
}

Console.WriteLine("\nГлубокое копирование:");
MyCollection<Person> deepCopy = people.DeepClone();
foreach (var person in deepCopy)
{
    person.Show();
}

Console.WriteLine("\nПеребор через foreach:");
foreach (var person in people)
{
    Console.WriteLine(person);
}

#endif
#endregion