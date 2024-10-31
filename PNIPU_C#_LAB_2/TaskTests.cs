namespace PNIPU_C__LAB_2
{
    internal class TaskTests
    {
        public static void RunTests()
        {
            TestSumEvenIndexElements();
            TestCountMultiplesOfFirstElement();
            TestCalculateAlternatingSum();
        }

        private static void TestSumEvenIndexElements()
        {
            Console.WriteLine("Testing SumEvenIndexElements:");

            int[][] testCases =
            {
                new int[] {1, 2, 3, 4, 5, 6}, 
                new int[] {10, 20, 30, 40},   
                new int[] {1, 2, 3, 4},       
                new int[] {5},                
                new int[] {7, 14, 21}         
            };

            int[] expectedResults = { 12, 60, 6, 0, 14 };

            for (int i = 0; i < testCases.Length; i++)
            {
                int result = CalculateSumEvenIndexElements(testCases[i]);
                Console.WriteLine($"Test {i + 1}: Expected {expectedResults[i]}, Got {result}");
            }
        }

        private static int CalculateSumEvenIndexElements(int[] numbers)
        {
            int sum = 0;
            for (int i = 1; i <= numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += numbers[i - 1];
                }
            }
            return sum;
        }

        private static void TestCountMultiplesOfFirstElement()
        {
            Console.WriteLine("\nTesting CountMultiplesOfFirstElement:");

            int[][] testCases =
            {
                new int[] {3, 6, 9, 12, 0},   
                new int[] {5, 10, 15, 3, 0},  
                new int[] {4, 8, 12, 16, 0},  
                new int[] {7, 14, 21, 0},     
                new int[] {2, 3, 5, 7, 0}     
            };

            int[] expectedResults = { 3, 2, 3, 2, 0 };

            for (int i = 0; i < testCases.Length; i++)
            {
                int result = CalculateCountMultiplesOfFirstElement(testCases[i]);
                Console.WriteLine($"Test {i + 1}: Expected {expectedResults[i]}, Got {result}");
            }
        }

        private static int CalculateCountMultiplesOfFirstElement(int[] numbers)
        {
            int firstElement = numbers[0];
            int count = 0;

            for (int i = 1; i < numbers.Length && numbers[i] != 0; i++)
            {
                if (numbers[i] % firstElement == 0)
                {
                    count++;
                }
            }

            return count;
        }

        private static void TestCalculateAlternatingSum()
        {
            Console.WriteLine("\nTesting CalculateAlternatingSum:");

            int[] testCases = { 5, 6, 3, 1, 10 }; 
            int[] expectedResults = { 9, 3, 0, 1, 16 }; 

            for (int i = 0; i < testCases.Length; i++)
            {
                int result = CalculateAlternatingSum(testCases[i]);
                Console.WriteLine($"Test {i + 1}: Expected {expectedResults[i]}, Got {result}");
            }
        }

        private static int CalculateAlternatingSum(int n)
        {
            int sum = 0;
            int i = 1;

            while (i <= n)
            {
                if (i % 3 == 0)
                {
                    sum -= i;
                }
                else
                {
                    sum += i;
                }
                i++;
            }

            return sum;
        }
    }
}
