using System;

namespace CzyUmieszPotegowac
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            for (var i = 0; i < testCount; i++)
            {
                var numbers = Console.ReadLine().Split(' ');

                var userBaseOfPower = int.Parse(numbers[0]);
                var numberOfPower = int.Parse(numbers[1]);
                var baseOfPower = userBaseOfPower % 10;

                if (numberOfPower == 0)
                {
                    Console.WriteLine("1");
                }
                else if (numberOfPower == 1)
                {
                    string baseOfPowerText = baseOfPower.ToString();
                    int a = baseOfPowerText.Length - 1;
                    Console.WriteLine(baseOfPowerText[a]);
                }
                else
                {
                    switch (baseOfPower)
                    {
                        case 1:
                            Console.WriteLine("1");
                            break;
                        case 2:
                            {
                                int a = numberOfPower % 4;
                                int[] valuesForTwo = { 6, 2, 4, 8 };
                                Console.WriteLine(valuesForTwo[a]);
                                break;
                            }
                        case 3:
                            {
                                int a = numberOfPower % 4;
                                int[] valuesForThree = { 1, 3, 9, 7, };
                                Console.WriteLine(valuesForThree[a]);
                                break;
                            }
                        case 4:
                            {
                                int a = numberOfPower % 2;
                                int[] valuesForThree = { 6, 4 };
                                Console.WriteLine(valuesForThree[a]);
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("5");
                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine("6");
                                break;
                            }
                        case 7:
                            {
                                int a = numberOfPower % 4;
                                int[] valuesForThree = { 1, 7, 9, 3 };
                                Console.WriteLine(valuesForThree[a]);
                                break;
                            }
                        case 8:
                            {
                                int a = numberOfPower % 4;
                                int[] valuesForThree = { 6, 8, 4, 2 };
                                Console.WriteLine(valuesForThree[a]);
                                break;
                            }
                        case 9:
                            {
                                int a = numberOfPower % 2;
                                int[] valuesForThree = { 1, 9 };
                                Console.WriteLine(valuesForThree[a]);
                                break;
                            }
                        case 0:
                            {
                                Console.WriteLine("0");
                                break;
                            }
                    }
                }
            }
        }
    }
}
