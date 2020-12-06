using System;

namespace PTCLTZ___Problem_Collatza
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCount = int.Parse(Console.ReadLine());
            for (int t = 0; t < testCount; t++)
            {
                int s = int.Parse(Console.ReadLine());
                int numberN = 0;

                do
                {
                    if (s % 2 == 0)
                    {
                        int x = s / 2;
                        s = x;
                        numberN++;
                    }

                    else
                    {
                        int x = (3 * s) + 1;
                        s = x;
                        numberN++;
                    }
                } while (s != 1);

                Console.WriteLine(numberN);
            }
        }
    }
}
