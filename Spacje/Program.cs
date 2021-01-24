using System;

namespace Spacje
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            do
            {
                if (text != "")
                {
                    var words = text.Split(" ");
                    var allTextInOne = "";

                    for (var i = 0; i < words.Length; i++)
                    {
                        var word = words[i];

                        if (word != "")
                        {
                            string newWord;
                            if (i != 0)
                            {
                                var firstLetter = word[0];
                                newWord = char.ToUpper(firstLetter).ToString() + word.Substring(1, word.Length - 1);
                            }
                            else
                            {
                                newWord = word;
                            }
                            allTextInOne += newWord;
                        }
                    }
                    Console.WriteLine(allTextInOne);
                }
                else
                {
                    Console.WriteLine();
                }
                text = Console.ReadLine();
            } while (text != null);
        }
    }
}
