using System;

namespace TagiHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            do
            {
                var result = "";
                var isTag = false;
                text = Console.ReadLine();
                if (text == null)
                    break;

                for (var i = 0; i < text.Length; i++)
                {
                    if (text[i] == '<')
                    {
                        isTag = true;
                    }
                    if (text[i] == '>')
                    {
                        isTag = false;
                    }
                    if (isTag == true)
                    {
                        result += char.ToUpper(text[i]);
                    }
                    else
                    {
                        result += text[i];
                    }
                }
                Console.WriteLine(result);
            } while (text != null);
        }
    }
}
