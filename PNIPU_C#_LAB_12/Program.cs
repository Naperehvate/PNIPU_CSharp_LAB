#define RUN_TUSK_2

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



#endif
#endregion