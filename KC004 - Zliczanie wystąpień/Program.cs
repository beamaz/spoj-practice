using System;

namespace ZliczanieWystąpien
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            while (line != null)
            {
                string[] tab = line.Split(" ");
                string expectedNumber = tab[0];
                int numberOfNumbers = int.Parse(tab[1]);
                int counter = 0;

                if (numberOfNumbers == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    for (int i = 2; i < tab.Length; i++)
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
