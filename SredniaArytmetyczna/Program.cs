using System;

namespace SredniaArytmetyczna
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCount = int.Parse(Console.ReadLine());
            for (int t = 0; t < testCount; t++)
            {
                var numbers = Console.ReadLine().Split(" ");
                double sum = 0;
                for (int i = 1; i < numbers.Length; i++)
                {
                    sum += int.Parse(numbers[i]);
                }
                double arithmeticAverage = sum / (numbers.Length - 1);

                double theSmallestDistance = 100;
                int place = 1;
                for (int i = 1; i < numbers.Length; i++)
                {
                    double distance = Math.Abs((int.Parse(numbers[i]) - arithmeticAverage));
                    if (distance < theSmallestDistance)
                    {
                        theSmallestDistance = distance;
                        place = i;
                    }
                }
                Console.WriteLine(numbers[place]);
            }
        }
    }
}
