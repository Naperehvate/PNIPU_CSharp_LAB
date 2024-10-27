using PNIPU_C__LAB_9;
using static System.Console;

WriteLine("Создание первой точки:");
Point point1 = UserInterface.GetPointFromUser();
UserInterface.DisplayPointInfo(point1);

WriteLine("Создание второй точки:");
Point point2 = UserInterface.GetPointFromUser();
UserInterface.DisplayPointInfo(point2);

// Вычисление расстояния
double distance = point1 + point2;
UserInterface.DisplayDistance(distance);

//Работа унарных операций
WriteLine("Увеличение X первой точки на 1:");
point1++;
UserInterface.DisplayPointInfo(point1);

WriteLine("Уменьшение X первой точки на 1:");
point1--;
UserInterface.DisplayPointInfo(point1);

// Преобразование типов
int intX = (int)point1; // Явное преобразование
double doubleY = point1; // Неявное преобразование
WriteLine($"Целая часть X первой точки: {intX}");
WriteLine($"Координата Y первой точки: {doubleY}");

// Увеличение X на целое число
point1 = point1 + 5;
WriteLine("Увеличение X первой точки на 5:");
UserInterface.DisplayPointInfo(point1);

WriteLine($"Количество созданных объектов Point: {Point.GetObjectCount()}");

WriteLine("Выберите метод создания массива точек:");
WriteLine("1 - Случайные значения");
WriteLine("2 - Ввод значений с клавиатуры");
int choice = Convert.ToInt32(ReadLine());

PointArray points;
if (choice == 1)
{
    Write("Введите размер массива: ");
    int size = Convert.ToInt32(ReadLine());
    points = UserInterface.CreateArrayWithRandomValues(size);
}
else
{
    Write("Введите размер массива: ");
    int size = Convert.ToInt32(ReadLine());
    points = UserInterface.CreateArrayWithUserInput(size);
}

WriteLine("\nЭлементы массива:");
points.DisplayArray();

// Поиск самой удаленной точки
Point mostDistantPoint = points.FindMostDistantPoint();
UserInterface.DisplayPoint(mostDistantPoint);

WriteLine($"\nКоличество созданных объектов Point: {Point.GetObjectCount()}");