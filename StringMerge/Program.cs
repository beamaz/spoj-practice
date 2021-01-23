using System;

namespace StringMerge
{
    class Program
    {
        public static string StringMerge(string firstWord, string secondWord)
        {
            string finalWord = "";
            var limit = Math.Min(firstWord.Length, secondWord.Length);
            for (int x = 0; x < limit; x++)
            {
                string newWord = firstWord[x] + "" + secondWord[x];
                finalWord += "" + newWord;
            }
            return finalWord;
        }

        static void Main(string[] args)
        {
            int testNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < testNumber; i++)
            {
                string text = Console.ReadLine();
                var words = text.Split(" ");
                var firstWord = words[0];
                var secondWord = words[1];

                string myResult = StringMerge(firstWord, secondWord);
                Console.WriteLine(myResult);
            }
        }
    }
}

