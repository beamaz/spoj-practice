using System;

namespace WiekSegmentolka
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            for (var t = 0; t < testCount; t++)
            {
                var functionNumbersToDivide = Console.ReadLine();
                var functionNumbers = functionNumbersToDivide.Split(" ");
                var segmentsCount = int.Parse(functionNumbers[0]);
                var sumOfLegs = 0;
                for (var i = 1; i < functionNumbers.Length; i++)
                {
                    var legsCount = int.Parse(functionNumbers[i]);
                    sumOfLegs += legsCount;
                }
                var ageOfCreature = (segmentsCount + sumOfLegs) - 1;
                Console.WriteLine(ageOfCreature);
            }
        }
    }
}
