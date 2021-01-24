using System;

namespace KabalistycznyZapisDaty
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var majorsLetters = word.ToUpper();

            var date = 0;
            foreach (var letterInWord in majorsLetters)
            {
                date += KabbalahConverter.ConvertCharToKabbalahNumber(letterInWord);
            }
            Console.WriteLine(date);
        }
    }
}
