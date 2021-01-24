using System;

namespace ZabawneDodawaniePiotrusia
{
    public static class StringHelper
    {
        public static int ReverseStringAndConvertToInt(string number)
        {
            var charArray = number.ToCharArray();
            Array.Reverse(charArray);
            var reverseString = new string(charArray);
            return int.Parse(reverseString);
        }
    }
}