using System;

namespace HarryAndBigDoughnuts
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            for (var t = 0; t < testCount; t++)
            {
                var funcionalNumbers = Console.ReadLine().Split(" ");
                var cats = int.Parse(funcionalNumbers[0]);
                var liftCapacity = int.Parse(funcionalNumbers[1]);
                var doughnutWeight = int.Parse(funcionalNumbers[2]);
                var totalWeight = cats * doughnutWeight;
                if (totalWeight > liftCapacity)
                {
                    Console.WriteLine("no");
                }
                else
                {
                    Console.WriteLine("yes");
                }
            }
        }
    }
}
