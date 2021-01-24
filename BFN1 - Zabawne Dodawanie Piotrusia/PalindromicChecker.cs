namespace ZabawneDodawaniePiotrusia
{
    public static class PalindromicChecker
    {
        public static bool Check(string number)
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
    }
}