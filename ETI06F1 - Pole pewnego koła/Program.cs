using System;

namespace PolePewnegoKola
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = Console.ReadLine().Split(' ');
            var radius = float.Parse(values[0]);
            var distance = float.Parse(values[1]);

            var newRadius = Math.Sqrt(Math.Pow(radius, 2) - (0.25 * Math.Pow(distance, 2)));

            var circularField = Math.PI * Math.Pow(newRadius, 2);
            Console.WriteLine(circularField);
        }
    }
}
