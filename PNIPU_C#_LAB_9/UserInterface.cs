using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PNIPU_C__LAB_9
{
    internal class UserInterface
    {
        public static Point GetPointFromUser()
        {
            Write("Введите координату X: ");
            double x = Convert.ToDouble(ReadLine());

            Write("Введите координату Y: ");
            double y = Convert.ToDouble(ReadLine());

            return new Point(x, y);
        }

        public static PointArray CreateArrayWithRandomValues(int size)
        {
            Random rand = new Random();
            return new PointArray(size, rand);
        }

        public static PointArray CreateArrayWithUserInput(int size)
        {
            return new PointArray(size);
        }

        public static void DisplayPoint(Point point)
        {
            WriteLine($"Самая удаленная точка: (X: {point.X:F2}, Y: {point.Y:F2}), Номер точки: {point.PointNumber}");
        }

        public static void DisplayPointInfo(Point point)
        {
            WriteLine($"Точка: {point.PointNumber} (X: {point.X:F2}, Y: {point.Y:F2})");
        }

        public static void DisplayDistance(double distance)
        {
            WriteLine($"Расстояние: {distance}");
        }
    }
}
