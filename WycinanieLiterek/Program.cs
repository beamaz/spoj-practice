using System;

namespace WycinanieLiterek
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            do
            {
                var textSplit = text.Split(" ");
                char funcionalLetter = Convert.ToChar(textSplit[0]);
                char [] letters = textSplit[1].ToCharArray();

                foreach (char letter in letters)
                {
                    if (letter != funcionalLetter)
                    {
                        Console.Write(letter);
                    }
                }
                Console.WriteLine();
                text = Console.ReadLine();
            } while (text != null);
        }
    }
}
