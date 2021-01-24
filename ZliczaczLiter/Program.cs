using System;
using System.Collections.Generic;

namespace ZliczaczLiter
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            var text = "";

            for (var i = 0; i < testCount; i++)
            {
                text += Console.ReadLine();
            }

            var allowedChars = new List<char>();
            for (var x = 'a'; x <= 'z'; x++)
            {
                allowedChars.Add(x);
            }
            for (var x = 'A'; x <= 'Z'; x++)
            {
                allowedChars.Add(x);
            }

            foreach (var element in allowedChars)
            {
                var counter = 0;
                for (var i = 0; i < text.Length; i++)
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
