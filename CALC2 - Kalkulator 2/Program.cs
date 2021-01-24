using System;

namespace Kalkulator2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] calculator = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            string line;
            while ((line = Console.ReadLine()) != null)
            {
                var data = line.Split(" ");
                string equationOperator = data[0];
                int firstNumber = int.Parse(data[1]);
                int secondNumber = int.Parse(data[2]);

                if (equationOperator == "z")
                {
                    calculator[firstNumber] = secondNumber;
                }
                else if (equationOperator == "+")
                {
                    Console.WriteLine(calculator[firstNumber] + calculator[secondNumber]);
                }
                else if (equationOperator == "-")
                {
                    Console.WriteLine(calculator[firstNumber] - calculator[secondNumber]);
                }
                else if (equationOperator == "*")
                {
                    Console.WriteLine(calculator[firstNumber] * calculator[secondNumber]);
                }
                else if (equationOperator == "/")
                {
                    Console.WriteLine(calculator[firstNumber] / calculator[secondNumber]);
                }
                else
                {
                    Console.WriteLine(calculator[firstNumber] % calculator[secondNumber]);
                }
            }
        }
    }
}
