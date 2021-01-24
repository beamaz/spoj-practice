using System;

namespace Samolot
{
    class Program
    {
        static int freeSeats(int n1, int k1, int n2, int k2)
        {
            var seats = n1 * k1 + n2 * k2;
            return seats;
        }
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ');
            var n1 = int.Parse(numbers[0]);
            var k1 = int.Parse(numbers[1]);
            var n2 = int.Parse(numbers[2]);
            var k2 = int.Parse(numbers[3]);
            var availableSeats = freeSeats(n1, k1, n2, k2);
            Console.WriteLine(availableSeats);
        }
    }
}
