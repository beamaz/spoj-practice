using System;

namespace POTSAM___Samolot
{
    class Program
    {
        static int freeSeats(int n1, int k1, int n2, int k2)
        {
            int seats = n1 * k1 + n2 * k2;
            return seats;
        }
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ');
            int n1 = int.Parse(numbers[0]);
            int k1 = int.Parse(numbers[1]);
            int n2 = int.Parse(numbers[2]);
            int k2 = int.Parse(numbers[3]);
            int availableSeats = freeSeats(n1, k1, n2, k2);
            Console.WriteLine(availableSeats);
        }
    }
}
