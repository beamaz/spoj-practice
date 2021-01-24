using System;

namespace ProsteDodawanie
{
    class Program
    {
        static void Main(string[] args)
        {
            var testNumber = int.Parse(Console.ReadLine());
            for (var i = 0; i < testNumber; i++)
            {
                var numberCount = int.Parse(Console.ReadLine());
                var sum = 0;
                var numbers = Console.ReadLine().Split(' ');
                for (var y = 0; y < numbers.Length; y++)
                {
                    var number = int.Parse(numbers[y]);
                    sum += number;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
