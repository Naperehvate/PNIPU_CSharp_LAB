namespace PNIPU_C__LAB_1
{
    internal class Task_2
    {
        public static void Example1()
        {
            TestPoint(0, 0);
            TestPoint(1, 1);
            TestPoint(2, 0);
            TestPoint(3, 0);
            TestPoint(-1, 2);
        }

        public static void TestPoint(double x1, double y1)
        {
            bool result = IsPointInsideDiamond(x1, y1);
            Console.WriteLine($"Point ({x1}, {y1}) is inside diamond: {result}");
        }

        public static bool IsPointInsideDiamond(double x1, double y1)
        {
            return Math.Abs(x1) + Math.Abs(y1) <= 2;
        }
    }
}