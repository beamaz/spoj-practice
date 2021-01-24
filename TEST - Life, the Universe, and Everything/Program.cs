using System;

namespace LifeTheUniverseAndEverything
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            do
            {
                string numberText = Console.ReadLine();
                number = int.Parse(numberText);

                if (number == 42)
                    break;
                Console.WriteLine(number);

            } while (number != 42);
        }
    }
}
