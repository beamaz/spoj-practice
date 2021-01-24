using System;

namespace DodawanieLiczbCalkowitych
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var number3 = int.Parse(Console.ReadLine());

            var sum = number1 + number2 + number3;
            Console.WriteLine(sum);
        }
    }
}
 