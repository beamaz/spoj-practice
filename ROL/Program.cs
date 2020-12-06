using System;

namespace ROL
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCount; i++)
            {
                var numbers = Console.ReadLine().Split(' ');
                int test = int.Parse(numbers[0]);

                for (int x = 2; x <= test; x++)
                {
                    Console.Write(numbers[x] + " ");
                }
                Console.WriteLine(numbers[1]);
            }
        }
    }
}
