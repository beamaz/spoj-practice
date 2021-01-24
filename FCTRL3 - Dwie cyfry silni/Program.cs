using System;

namespace DwieCyfrySilni
{
    class Program
    {
        static int ComputeFactorial(int factorial)
        {
            var resultFactorial = 1;
            for (var i = 1; i <= factorial; i++)
            {
                resultFactorial = resultFactorial * i;
            }
            return resultFactorial;
        }
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());

            for (var k = 0; k < testCount; k++)
            {
                var factorial = int.Parse(Console.ReadLine());

                if (factorial <= 9)
                {
                    var resultFactorial = ComputeFactorial(factorial);

                    var resultFactorialText = resultFactorial.ToString();
                    var y = resultFactorialText.Length - 1;
                    if (factorial > 3)
                    {
                        var x = resultFactorialText.Length - 2;
                        Console.WriteLine(resultFactorialText[x] + " " + resultFactorialText[y]);
                    }
                    else
                    {
                        Console.WriteLine("0 " + resultFactorialText[y]);
                    }
                }
                else
                {
                    Console.WriteLine("0 0");
                }
            }
        }
    }
}
