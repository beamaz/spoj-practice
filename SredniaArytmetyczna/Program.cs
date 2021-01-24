using System;

namespace SredniaArytmetyczna
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            for (var t = 0; t < testCount; t++)
            {
                var numbers = Console.ReadLine().Split(" ");
                double sum = 0;
                for (var i = 1; i < numbers.Length; i++)
                {
                    sum += int.Parse(numbers[i]);
                }
                var arithmeticAverage = sum / (numbers.Length - 1);

                double theSmallestDistance = 100;
                var place = 1;
                for (var i = 1; i < numbers.Length; i++)
                {
                    var distance = Math.Abs((int.Parse(numbers[i]) - arithmeticAverage));
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
