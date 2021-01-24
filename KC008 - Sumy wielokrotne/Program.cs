using System;

namespace SumyWielokrotne
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            string line = Console.ReadLine();
            while (line != null) 
            {
                long result = 0;
                var numbers = line.Split(" ");
                foreach (var t in numbers)
                {
                    result = Convert.ToInt64(t) + result;
                }
                Console.WriteLine(result);
                line = Console.ReadLine();
                sum += result;
            }
            Console.WriteLine(sum);
        }
    }
}
