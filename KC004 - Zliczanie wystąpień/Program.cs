using System;

namespace ZliczanieWystąpien
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            while (line != null)
            {
                var tab = line.Split(" ");
                var expectedNumber = tab[0];
                var numberOfNumbers = int.Parse(tab[1]);
                var counter = 0;

                if (numberOfNumbers == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    for (var i = 2; i < tab.Length; i++)
                    {
                        if (tab[i] == expectedNumber)
                        {
                            counter += 1;
                        }
                    }
                    Console.WriteLine(counter);
                }
                line = Console.ReadLine();
            }
        }
    }
}
