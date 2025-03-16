using ClassLibrary;
using PNIPU_C__LAB_11;



#region Task1
//Console.WriteLine("Task1");
//MenuHandler menuHandler = new MenuHandler();
//menuHandler.ShowMenu();
//Console.Clear();
#endregion


#region Task2
//Console.WriteLine("Task2\n\n");
//MenuHandlerObjGenerics menuHandlerGenerics = new MenuHandlerObjGenerics();
//menuHandlerGenerics.ShowMenu();
#endregion


#region Task3
Console.WriteLine("Тестирование TestCollections\n");

TestCollections<Person, Worker> testCollections = new TestCollections<Person, Worker>(99999);

Console.WriteLine("Коллекции успешно созданы и заполнены.");

Console.WriteLine("Добавление нового элемента в коллекции...");
Worker newWorker = new Worker();
newWorker.RandomInit();
testCollections.AddElement(newWorker);
Console.WriteLine("Элемент добавлен.\n");

Console.WriteLine("Удаление первого элемента из коллекций...");
testCollections.RemoveElement(testCollections.ListT[0]);
Console.WriteLine("Элемент удален.\n");

testCollections.MeasureSearchTime();

Console.WriteLine("Тестирование завершено.");
#endregion