using System;

namespace OdwracanieWyrazow
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            do
            {
                var letters = text.ToCharArray();

                for (var i = letters.Length - 1; i >= 0; i--)
                {
                    Console.Write(letters[i]);
                }
                Console.WriteLine();
                text = Console.ReadLine();
            } while (text != null);
        }
    }
}
