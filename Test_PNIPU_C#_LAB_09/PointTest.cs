using NUnit.Framework;
using PNIPU_C__LAB_9;

namespace Test_PNIPU_C__LAB_09
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            while (Point.GetObjectCount() > 0) { new Point(0, 0); }
        }

        [Test]
        public void Constructor_ShouldInitializeCoordinates()
        {
            var point = new Point(3, 4);
            Assert.AreEqual(3, point.X);
            Assert.AreEqual(4, point.Y);
        }

        [Test]
        public void Constructor_ShouldIncrementPointNumberAndObjectCount()
        {
            var initialCount = Point.GetObjectCount();
            var point = new Point(1, 2);
            Assert.AreEqual(initialCount + 1, point.PointNumber);
            Assert.AreEqual(initialCount + 1, Point.GetObjectCount());
        }

        [Test]
        public void Dispose_ShouldDecrementObjectCount()
        {
            var initialCount = Point.GetObjectCount();
            var point = new Point(1, 2);
            Assert.AreEqual(initialCount + 1, Point.GetObjectCount());

            point.Dispose();
            Assert.AreEqual(initialCount, Point.GetObjectCount());
        }

        [Test]
        public void DistanceTo_ShouldCalculateCorrectDistance()
        {
            var point1 = new Point(0, 0);
            var point2 = new Point(3, 4);

            double distance = point1.DistanceTo(point2);
            Assert.AreEqual(5, distance);
        }

        [Test]
        public void IncrementOperator_ShouldIncreaseX()
        {
            var point = new Point(5, 0);
            point++;
            Assert.AreEqual(6, point.X);
        }

        [Test]
        public void DecrementOperator_ShouldDecreaseX()
        {
            var point = new Point(5, 0);
            point--;
            Assert.AreEqual(4, point.X);
        }

        [Test]
        public void ExplicitConversionToInt_ShouldReturnXAsInteger()
        {
            var point = new Point(5.9, 0);
            int xValue = (int)point;
            Assert.AreEqual(5, xValue);
        }

        [Test]
        public void ImplicitConversionToDouble_ShouldReturnY()
        {
            var point = new Point(0, 7.8);
            double yValue = point;
            Assert.AreEqual(7.8, yValue);
        }

        [Test]
        public void AdditionOperator_ShouldCalculateDistanceBetweenPoints()
        {
            var point1 = new Point(0, 0);
            var point2 = new Point(3, 4);

            double distance = point1 + point2;
            Assert.AreEqual(5, distance);
        }

        [Test]
        public void AdditionOperator_WithInt_ShouldIncreaseX()
        {
            var point = new Point(3, 4);
            var newPoint = point + 2;
            Assert.AreEqual(5, newPoint.X);
            Assert.AreEqual(4, newPoint.Y);
        }

        [Test]
        public void GetObjectCount_ShouldReturnCorrectCount()
        {
            var initialCount = Point.GetObjectCount();
            var point1 = new Point(1, 1);
            var point2 = new Point(2, 2);

            Assert.AreEqual(initialCount + 2, Point.GetObjectCount());
        }
    }
}
