using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Pesel
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCount = int.Parse(Console.ReadLine());
            for (int t = 0; t < testCount; t++)
            {
                string pesel = Console.ReadLine();
                int[] numbers = new int[11];
                for (int x = 0; x < numbers.Length; x++)
                {
                    int asciiValue = 48;
                    numbers[x] = Convert.ToInt32(pesel[x]) - asciiValue;
                }

                int newNumber = 0;
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i == 0 || i == 4 || i == 8 || i == 10)
                    {
                        newNumber = numbers[i] * 1;
                    }
                    else if (i == 1 || i == 5 || i == 9)
                    {
                        newNumber = numbers[i] * 3;
                    }
                    else if (i == 2 || i == 6)
                    {
                        newNumber = numbers[i] * 7;
                    }
                    else if (i == 3 || i == 7)
                    {
                        newNumber = numbers[i] * 9;
                    }
                    sum += newNumber;
                }
                if (sum > 0)
                {
                    if ( sum % 10 == 0)
                    {
                        Console.WriteLine("D");
                    }
                    else
                    {
                        Console.WriteLine("N");
                    }
                }
                else
                {
                    Console.WriteLine("N");
                }
            }
        }
    }
}
