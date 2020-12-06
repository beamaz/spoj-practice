using System;
using System.Security.Cryptography.X509Certificates;

namespace Połowa
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCount; i++)
            {
                string array = Console.ReadLine();
                int halfArray = array.Length / 2;
                
                for (int x = 0; x < halfArray; x++)
                {
                    Console.Write(array[x]);
                }
                Console.WriteLine();
            }
        }
    }
}
