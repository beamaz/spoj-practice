using System;

namespace WycinanieLiterek
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            do
            {
                var textSplit = text.Split(" ");
                var funcionalLetter = Convert.ToChar(textSplit[0]);
                var letters = textSplit[1].ToCharArray();

                foreach (var letter in letters)
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
