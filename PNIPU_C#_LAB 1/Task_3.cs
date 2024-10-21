namespace PNIPU_C__LAB_1
{
    internal class Task_3
    {
        private readonly float a_f = 1000f;
        private readonly float b_f = 0.0001f;
        private readonly double a_d = 1000.0;
        private readonly double b_d = 0.0001;
        private readonly decimal a_d_m = 1000m;
        private readonly decimal b_d_m = 0.0001m;

        public void Example1()
        {
            float result_float = CalculateExpression(a_f, b_f);
            Console.WriteLine($"Result (float): {result_float}");

            double result_double = CalculateExpression(a_d, b_d);
            Console.WriteLine($"Result (double): {result_double}");

            decimal result_decimal = CalculateExpression(a_d_m, b_d_m);
            Console.WriteLine($"Result (decimal): {result_decimal}");
        }

        private static float CalculateExpression(float a, float b)
        {
            return ((float)Math.Pow(a + b, 3) - (float)(Math.Pow(a, 3) + 3 * Math.Pow(a, 2) * b)) / (3 * a * (float)Math.Pow(b, 2) + (float)Math.Pow(b, 2));
        }

        private static double CalculateExpression(double a, double b)
        {
            return (Math.Pow(a + b, 3) - (Math.Pow(a, 3) + 3 * Math.Pow(a, 2) * b)) / (3 * a * Math.Pow(b, 2) + Math.Pow(b, 2));
        }

        private static decimal CalculateExpression(decimal a, decimal b)
        {
            return (Pow(a + b, 3) - (Pow(a, 3) + 3 * Pow(a, 2) * b)) / (3 * a * Pow(b, 2) + Pow(b, 2));
        }

        private static decimal Pow(decimal baseValue, int exponent)
        {
            decimal result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseValue;
            }
            return result;
        }
    }
}