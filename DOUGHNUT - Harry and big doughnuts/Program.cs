using System;

namespace DOUGHNUT___Harry_and_big_doughnuts
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCount = int.Parse(Console.ReadLine());
            for (int t=0; t < testCount; t++)
            {
                var funcionalNumbers = Console.ReadLine().Split(" ");
                int cats = int.Parse(funcionalNumbers[0]);
                int liftCapacity = int.Parse(funcionalNumbers[1]);
                int doughnutWeight = int.Parse(funcionalNumbers[2]);
                int totalWeight = cats * doughnutWeight;
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
