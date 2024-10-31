namespace PNIPU_C__LAB_1
{
    internal class Task_1
    {
        // 1. m - --n
        public static void Example1()
        {
            int m = 5;
            int n = 3;
            int result = m - --n;
            Console.WriteLine($"1) m - --n: m = {m}, n = {n}, result = {result}");
        }

        // 2. m++ < n
        public static void Example2()
        {
            int m = 5;
            int n = 7;
            bool result = m++ < n;
            Console.WriteLine($"2) m++ < n: m = {m}, n = {n}, result = {result}");
        }

        // 3. n++ > m
        public static void Example3()
        {
            int m = 5;
            int n = 6;
            bool result = n++ > m;
            Console.WriteLine($"3) n++ > m: m = {m}, n = {n}, result = {result}");
        }

        // 4. x^4 - cos(arcsin(x))
        public static void Example4()
        {
            double x = 0.50;
            if (x < -1 || x > 1)
            {
                Console.WriteLine($"4) Error: arcsin(x) is undefined for x = {x}");
            }
            else
            {
                double result = Math.Pow(x, 4) - Math.Cos(Math.Asin(x));
                Console.WriteLine($"4) x^4 - cos(arcsin(x)): x = {x}, result = {result}");
            }
        }
    }
}