using System;

namespace ZabawneDodawaniePiotrusia
{
    public class Program
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            for (var t = 0; t < testCount; t++)
            {
                var counter = 0;
                var num = Console.ReadLine();

                while (!PalindromicChecker.Check(num))
                {
                    var numInt = int.Parse(num);
                    var reverseNum = StringHelper.ReverseStringAndConvertToInt(num);
                    var sum = numInt + reverseNum;
                    num = sum.ToString();
                    counter++;
                }
                Console.WriteLine(num + " " + counter);
            }
        }
    }
}
