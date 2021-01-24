using System;

namespace ZabawneDodawaniePiotrusia
{
    class Program
    {
        public static int ReverseStringAndConvertToInt(string number)
        {
            var charArray = number.ToCharArray();
            Array.Reverse(charArray);
            var reverseString = new string(charArray);
            return int.Parse(reverseString);
        }
        public static bool IsPalindromic(string number)
        {
            for (var y = 0; y < number.Length / 2; y++)
            {
                if (number[y] != number[number.Length - y - 1])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            for (var t = 0; t < testCount; t++)
            {
                var counter = 0;
                var num = Console.ReadLine();

                while (!IsPalindromic(num))
                {
                    var numInt = int.Parse(num);
                    var reverseNum = ReverseStringAndConvertToInt(num);
                    var sum = numInt + reverseNum;
                    num = sum.ToString();
                    counter++;
                }
                Console.WriteLine(num + " " + counter);
            }
        }
    }
}
