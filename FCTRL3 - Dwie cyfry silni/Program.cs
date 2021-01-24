using System;

namespace DwieCyfrySilni
{
    class Program
    {
        static int ComputeFactorial(int factorial)
        {
            int resultFactorial = 1;
            for (int i = 1; i <= factorial; i++)
            {
                resultFactorial = resultFactorial * i;
            }
            return resultFactorial;
        }


        static void Main(string[] args)
        {
            int testCount = int.Parse(Console.ReadLine());
          
            for (int k = 0; k < testCount; k++)
            {
                int factorial = int.Parse(Console.ReadLine());

                if (factorial <= 9)
                {
                    int resultFactorial = ComputeFactorial(factorial);

                    string resultFactorialText = resultFactorial.ToString();
                    int y = resultFactorialText.Length - 1;
                    if (factorial > 3)
                    {
                        int x = resultFactorialText.Length - 2;
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
