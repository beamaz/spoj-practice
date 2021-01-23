using System;

namespace WiekSegmentolka
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCount = int.Parse(Console.ReadLine());
            for (int t = 0; t < testCount; t++)
            {
                string functionNumbersToDivide = Console.ReadLine();
                var functionNumbers = functionNumbersToDivide.Split(" ");
                int segmentsCount = int.Parse(functionNumbers[0]);
                int sumOfLegs = 0;
                for (int i = 1; i < functionNumbers.Length; i++)
                {
                    int legsCount = int.Parse(functionNumbers[i]);
                    sumOfLegs += legsCount;
                }
                int ageOfCreature = (segmentsCount + sumOfLegs) - 1;
                Console.WriteLine(ageOfCreature);
            }
        }
    }
}
