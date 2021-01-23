using System;

namespace Obzarciuchy
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCount; i++)
            {
                var cookiesDay = Console.ReadLine().Split(' ');
                int personsNumber = int.Parse(cookiesDay[0]);
                int cookiesInBox = int.Parse(cookiesDay[1]);
                int cookiesAmount = 0;

                for (int x = 0; x < personsNumber; x++)
                {
                    int time = int.Parse(Console.ReadLine());
                    cookiesAmount = cookiesAmount + (86400 / time);

                }
                double cookiesBox = (double)cookiesAmount / cookiesInBox;
                Console.WriteLine(Math.Ceiling(cookiesBox));
            }
        }
    }
}
