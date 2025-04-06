using ClassLibrary;
using PNIPU_C__LAB_13;

MyNewCollection<Engineer> collection1 = new("Коллекция 1");
MyNewCollection<Engineer> collection2 = new("Коллекция 2");

Journal journal1 = new();
Journal journal2 = new();

collection1.CollectionCountChanged += journal1.CollectionEventHandler;
collection1.CollectionReferenceChanged += journal1.CollectionEventHandler;

collection1.CollectionReferenceChanged += journal2.CollectionEventHandler;
collection2.CollectionReferenceChanged += journal2.CollectionEventHandler;

collection1.AddDefaults(2);
collection2.AddDefaults(3);

collection1.Remove(0);
collection2.Remove(1);

collection1[0] = new Engineer("Иван", 35, "Инженер", "IT");
collection2[1] = new Engineer("Мария", 28, "Менеджер", "Электрик");

Console.WriteLine("Журнал 1:");
Console.WriteLine(journal1);
Console.WriteLine("\nЖурнал 2:");
Console.WriteLine(journal2);