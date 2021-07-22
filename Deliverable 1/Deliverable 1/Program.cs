using System;

namespace Deliverable_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int imperialInch = 1;
            int imperialFoot = 1;
            decimal milSpin = 3.5m;
            int milMeme = 5;
            string response = null;

            Console.WriteLine("Please enter a measurement type " +
                "\na). Inch   b). Fidget Spinners " +
                "\nc). Feet   d). Memes");
            var input = Console.ReadLine();

            do
            { switch (input)
                {
                    case "a":
                        Console.WriteLine("Please enter a number ");
                        string input1 = Console.ReadLine().ToLower();
                        int num1 = int.Parse(input1);
                        int num11 = imperialInch;
                        decimal num111 = milSpin;
                        Console.WriteLine((num1 * num11) * num111);
                        break;
                    case "b":
                        Console.WriteLine("Please enter a number ");
                        string input2 = Console.ReadLine().ToLower();
                        int num2 = int.Parse(input2);
                        decimal num22 = milSpin;
                        Console.WriteLine(num22 * num2);
                        break;
                    case "c":
                        Console.WriteLine("Please enter a number ");
                        string input3 = Console.ReadLine().ToLower();
                        int num3 = int.Parse(input3);
                        int num33 = imperialFoot;
                        int num333 = milMeme;
                        Console.WriteLine((num3 * num33) * num333);
                        break;
                    case "d":
                        Console.WriteLine("Please enter a number");
                        string input4 = Console.ReadLine().ToLower();
                        int num4 = int.Parse(input4);
                        int num44 = milMeme;
                        Console.WriteLine(num44 * num4);
                        break;
                }
                Console.WriteLine("Would you like to enter another # y/n ?");
                response = Console.ReadLine().ToLower();
            } while (response == "y");
        }
    }
}
