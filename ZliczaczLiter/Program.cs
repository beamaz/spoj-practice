using System;
using System.Collections.Generic;

namespace ZliczaczLiter
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCount = int.Parse(Console.ReadLine());
            string text = "";

            for (int i = 0; i < testCount; i++)
            {
                text += Console.ReadLine();
            }

            var allowedChars = new List<char>();
            for (char x = 'a'; x <= 'z'; x++)
            {
                allowedChars.Add(x);
            }
            for (char x = 'A'; x <= 'Z'; x++)
            {
                allowedChars.Add(x);
            }

            foreach (var element in allowedChars)
            {
                int counter = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == element)
                    {
                        counter++;
                    }
                }

                if (counter != 0)
                {
                    Console.WriteLine(element + " " + counter);
                }
            }
        }
    }
}
