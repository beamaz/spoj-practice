using System;

namespace MWPZ06D___Imieniny
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCount; i++)
            {
                var funcionalNumbers = Console.ReadLine().Split(" ");
                int studentsCount = int.Parse(funcionalNumbers[0]) - 1;
                int candiesCount = int.Parse(funcionalNumbers[1]);

                if (studentsCount != 0)
                {
                    int candiesForJasio = candiesCount % studentsCount;
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
