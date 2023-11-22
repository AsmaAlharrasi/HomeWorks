namespace leet_code
{
    class Program
    {
        static void Main()
        {
            // Example Usage:
            int n = 16;
            bool result = IsPowerOfTwo(n);

            Console.WriteLine($"{n} is a power of two: {result}");
        }

        static bool IsPowerOfTwo(int n)
        {
            if (n <= 0)
            {
                return false;
            }

            // Check if only one bit is set in the binary representation
            return (n & (n - 1)) == 0;
        }
    }
}
