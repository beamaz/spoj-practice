using System;

namespace Imieniny
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());

            for (var i = 0; i < testCount; i++)
            {
                var funcionalNumbers = Console.ReadLine().Split(" ");
                var studentsCount = int.Parse(funcionalNumbers[0]) - 1;
                var candiesCount = int.Parse(funcionalNumbers[1]);

                if (studentsCount != 0)
                {
                    var candiesForJasio = candiesCount % studentsCount;
                    if (candiesForJasio == 0)
                    {
                        Console.WriteLine("NIE");
                    }
                    else
                    {
                        Console.WriteLine("TAK");
                    }
                }
                else
                {
                    Console.WriteLine("TAK");
                }
            }
        }
    }
}
