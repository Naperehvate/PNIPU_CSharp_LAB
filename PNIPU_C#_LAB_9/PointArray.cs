using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PNIPU_C__LAB_9
{
    internal class PointArray
    {
        private Point[] _arr;

        public PointArray()
        {
            _arr = new Point[10];
        }


        public PointArray(int size, Random rand)
        {
            _arr = new Point[size];
            for (int i = 0; i < size; i++)
            {
                _arr[i] = new Point(rand.NextDouble() * 100, rand.NextDouble() * 100);
            }
        }

       
        public PointArray(int size)
        {
            _arr = new Point[size];
            for (int i = 0; i < size; i++)
            {
                WriteLine($"Введите координаты для точки {i + 1}:");
                Write("X: ");
                double x = Convert.ToDouble(ReadLine());
                Write("Y: ");
                double y = Convert.ToDouble(ReadLine());
                _arr[i] = new Point(x, y);
            }
        }

        
        public void DisplayArray()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                WriteLine($"Точка {_arr[i].PointNumber}: (X: {_arr[i].X:F2}, Y: {_arr[i].Y:F2})");
            }
        }

     
        public Point this[int index]
        {
            get
            {
                if (index < 0 || index >= _arr.Length)
                    throw new ArgumentException("Индекс выходит за пределы массива.");
                return _arr[index];
            }
            set
            {
                if (index < 0 || index >= _arr.Length)
                    throw new ArgumentException("Индекс выходит за пределы массива.");
                _arr[index] = value;
            }
        }

        
        public Point FindMostDistantPoint()
        {
            if (_arr.Length == 0)
                throw new InvalidOperationException("Массив пуст.");

            double distance = 0;
            Point mostDistant = _arr[0];
            double maxDistance = mostDistant.DistanceTo(new Point(0, 0));

            for (int i = 1; i < _arr.Length; i++)
            {
                distance = _arr[i].DistanceTo(new Point(0, 0));
                if (distance > maxDistance)
                {
                    maxDistance = distance;
                    mostDistant = _arr[i];
                }
            }
            return mostDistant;
        }
    }
}

