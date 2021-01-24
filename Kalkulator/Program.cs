using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {

                var numbers = line.Split(' ');
                var mathematicalOperator = numbers[0];
                var firstNumber = int.Parse(numbers[1]);
                var secondNumber = int.Parse(numbers[2]);

                switch (mathematicalOperator)
                {
                    case "+":
                        Console.WriteLine(firstNumber + secondNumber);
                        break;
                    case "-":
                        Console.WriteLine(firstNumber - secondNumber);
                        break;
                    case "*":
                        Console.WriteLine(firstNumber * secondNumber);
                        break;
                    case "/":
                        Console.WriteLine(firstNumber / secondNumber);
                        break;
                    case "%":
                        Console.WriteLine(firstNumber % secondNumber);
                        break;
                }
            }
        }
    }
}
