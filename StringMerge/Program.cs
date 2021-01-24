using System;

namespace StringMerge
{
    class Program
    {
        public static string StringMerge(string firstWord, string secondWord)
        {
            var finalWord = "";
            var limit = Math.Min(firstWord.Length, secondWord.Length);
            for (var x = 0; x < limit; x++)
            {
                var newWord = firstWord[x] + "" + secondWord[x];
                finalWord += "" + newWord;
            }
            return finalWord;
        }
        static void Main(string[] args)
        {
            var testNumber = int.Parse(Console.ReadLine());
            for (var i = 0; i < testNumber; i++)
            {
                var text = Console.ReadLine();
                var words = text.Split(" ");
                var firstWord = words[0];
                var secondWord = words[1];

                var myResult = StringMerge(firstWord, secondWord);
                Console.WriteLine(myResult);
            }
        }
    }
}

