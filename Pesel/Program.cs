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
            var testCount = int.Parse(Console.ReadLine());
            for (var t = 0; t < testCount; t++)
            {
                var pesel = Console.ReadLine();
                var numbers = new int[11];
                for (var x = 0; x < numbers.Length; x++)
                {
                    var asciiValue = 48;
                    numbers[x] = Convert.ToInt32(pesel[x]) - asciiValue;
                }

                var newNumber = 0;
                var sum = 0;
                for (var i = 0; i < numbers.Length; i++)
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
                    if (sum % 10 == 0)
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
