using System;

namespace ZabawneDodawaniePiotrusia
{
    class Program
    {
        public static int ReverseStringAndConvertToInt(string number)
        {
            char[] charArray = number.ToCharArray();
            Array.Reverse(charArray);
            string reverseString = new string(charArray);
            return int.Parse(reverseString);
        }
        public static bool IsPalindromic(string number)
        {
            for (int y = 0; y < number.Length / 2; y++)
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
            int testCount = int.Parse(Console.ReadLine());
            for (int t = 0; t < testCount; t++)
            {
                int counter = 0;
                string num = Console.ReadLine();

                while (!IsPalindromic(num))
                {
                    int numInt = int.Parse(num);
                    int reverseNum = ReverseStringAndConvertToInt(num);
                    int sum = numInt + reverseNum;
                    num = sum.ToString();
                    counter++;
                }
                Console.WriteLine(num + " " + counter);
            }
        }
    }
}
