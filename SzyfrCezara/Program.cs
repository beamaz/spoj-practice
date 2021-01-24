using System;

namespace SzyfrCezara
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            do
            {
                var words = text.Split(" ");
                foreach (var word in words)
                {
                    var letters = word.ToCharArray(0, word.Length);

                    for (var i = 0; i < letters.Length; i++)
                    {
                        if (letters[i] >= 'A' && letters[i] <= 'W')
                        {
                            var newLetter = letters[i] + 3;
                            var letterInCode = Convert.ToChar(newLetter);
                            Console.Write(letterInCode);
                        }
                        if (letters[i] > 'W' && letters[i] <= 'Z')
                        {
                            switch (letters[i])
                            {
                                case 'X':
                                    Console.Write("A");
                                    break;
                                case 'Y':
                                    Console.Write("B");
                                    break;
                                default:
                                    Console.Write("C");
                                    break;
                            }
                        }
                    }
                    Console.Write(" ");
                }
                text = Console.ReadLine();
            } while (text != null);
        }
    }
}
