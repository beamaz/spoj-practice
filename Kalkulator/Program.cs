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
                string mathematicalOperator = numbers[0];
                int firstNumber = int.Parse(numbers[1]);
                int secondNumber = int.Parse(numbers[2]);

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
