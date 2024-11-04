namespace PNIPU_C__LAB_9
{
    public class Point : IDisposable
    {
        private static int _objectCount = 0;
        private int _pointNumber = 0;
        private double _x;
        private double _y;
        private bool _disposed = false;

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public int PointNumber
        {
            get { return _pointNumber; }
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
            _objectCount++;
            _pointNumber = _objectCount;
        }

        public double DistanceTo(Point other)
        {
            return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2));
        }

        public static Point operator ++(Point p)
        {
            p.X++;
            return p;
        }

        public static Point operator --(Point p)
        {
            p.X--;
            return p;
        }

        public static explicit operator int(Point p)
        {
            return (int)p.X;
        }

        public static implicit operator double(Point p)
        {
            return p.Y;
        }

        public static double operator +(Point p1, Point p2)
        {
            return p1.DistanceTo(p2);
        }

        public static Point operator +(Point p, int value)
        {
            return new Point(p.X + value, p.Y);
        }

        public static Point operator +(int value, Point p)
        {
            return new Point(p.X + value, p.Y);
        }

        public static int GetObjectCount()
        {
            return _objectCount;
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                _objectCount--;
                _disposed = true;
                GC.SuppressFinalize(this);
            }
        }

        ~Point()
        {
            Dispose();
        }
    }
}