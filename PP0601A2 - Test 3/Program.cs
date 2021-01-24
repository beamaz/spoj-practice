using System;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            var countOf42 = 0;
            var prev42 = false;
            var isFirst = true;

            while ((line = Console.ReadLine()) != null)
            {

                if (line != "42")
                {
                    Console.WriteLine(line);
                    prev42 = false;
                }
                else
                {
                    if (prev42 == false && isFirst == false) 
                    {
                            countOf42++;
                    }
                    prev42 = true;
                    Console.WriteLine(line);

                }
                if (countOf42 == 3)
                {
                    break;
                }
                isFirst = false;
            }
        }
    }
}
