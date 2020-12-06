using System;

namespace OdwracanieWyrazow
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            do
            {
                char[] letters = text.ToCharArray();

                for (int i = letters.Length - 1; i >= 0; i--)
                {
                    Console.Write(letters[i]);
                }
                Console.WriteLine();
                text = Console.ReadLine();
            } while (text != null);
        }
    }
}
