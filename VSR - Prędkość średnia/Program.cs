using System;

namespace VSR___Prędkość_średnia
{
    class Program
    {
        static void Main(string[] args)
        {

            int velocityCount = int.Parse(Console.ReadLine());
            for (int x = 0; x < velocityCount; x++)
            {

                var velocities = Console.ReadLine().Split(' ');

                int velocity1 = int.Parse(velocities[0]);
                int velocity2 = int.Parse(velocities[1]);
                int averageVelocity = (2 * velocity1 * velocity2) / (velocity1 + velocity2);
                Console.WriteLine(averageVelocity);
            }

        }
    }
}
