using System;

namespace VsrPredkoscSrednia
{
    class Program
    {
        static void Main(string[] args)
        {
            var velocityCount = int.Parse(Console.ReadLine());
            for (var x = 0; x < velocityCount; x++)
            {
                var velocities = Console.ReadLine().Split(' ');

                var velocity1 = int.Parse(velocities[0]);
                var velocity2 = int.Parse(velocities[1]);
                var averageVelocity = (2 * velocity1 * velocity2) / (velocity1 + velocity2);
                Console.WriteLine(averageVelocity);
            }
        }
    }
}
