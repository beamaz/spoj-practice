using System;

namespace ParzysteNieparzyste
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            for (var t = 0; t < testCount; t++)
            {
                var numbers = Console.ReadLine().Split(" ");
                var n = int.Parse(numbers[0]);

                for (var a = 2; a < numbers.Length; a += 2)
                {
                    Console.Write(numbers[a] + " ");
                }
                for (var b = 1; b < numbers.Length; b += 2)
                {
                    Console.Write(numbers[b] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
