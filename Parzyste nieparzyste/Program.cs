using System;

namespace ParzysteNieparzyste
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCount = int.Parse(Console.ReadLine());
            for (int t = 0; t < testCount; t++)
            {
                var numbers = Console.ReadLine().Split(" ");
                int n = int.Parse(numbers[0]);
               
                    for (int a = 2; a < numbers.Length; a+=2)
                    {
                        Console.Write(numbers[a] + " ");
                    }
                    for (int b = 1; b < numbers.Length; b+=2)
                    {
                        Console.Write(numbers[b] + " ");
                    }
               
                Console.WriteLine();
            }
        }
    }
}
