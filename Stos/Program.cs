using System;

namespace Stos
{
    class Program
    {
        static void Main(string[] args)
        {
            const int stackLength = 10;
            const string success = ":)";
            const string fail = ":(";
            var operationText = Console.ReadLine();
            var numbers = new int[stackLength];
            var currentPosition = 0;
            do
            {
                if (operationText == "+")
                {
                    if (currentPosition < stackLength)
                    {
                        numbers[currentPosition] = int.Parse(Console.ReadLine());
                        Console.WriteLine(success);
                        currentPosition++;
                    }
                    else
                    {
                        Console.ReadLine();
                        Console.WriteLine(fail);
                    }
                }

                if (operationText == "-")
                {
                    if (currentPosition == 0)
                    {
                        Console.WriteLine(fail);
                    }
                    else
                    {
                        Console.WriteLine(numbers[currentPosition - 1]);
                        currentPosition--;
                    }
                }
                operationText = Console.ReadLine();
            } while (operationText != null);
        }
    }
}
