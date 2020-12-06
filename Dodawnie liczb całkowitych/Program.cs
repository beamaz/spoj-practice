using System;

namespace Dodawnie_liczb_całkowitych
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int sum = number1 + number2 + number3;
            Console.WriteLine(sum);
        }
    }
}
 