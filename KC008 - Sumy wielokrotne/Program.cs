using System;

namespace KC008___Sumy_wielokrotne
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
                for ( int i = 0; i < numbers.Length; i++)
                {
                    result = Convert.ToInt64(numbers[i]) + result;
                }
                Console.WriteLine(result);
                line = Console.ReadLine();
                sum += result;
            }
            Console.WriteLine(sum);
        }
    }
}
