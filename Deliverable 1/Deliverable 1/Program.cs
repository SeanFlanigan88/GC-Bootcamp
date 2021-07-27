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
                        Console.WriteLine("Please enter a number in Inches");
                        string input1 = Console.ReadLine().ToLower();
                        decimal num1 = decimal.Parse(input1);
                        int num11 = imperialInch;
                        decimal num111 = milSpin;
                        Console.WriteLine((num1 * num11) * num111 + " Fidget Spinners");
                        break;
                    case "b":
                        Console.WriteLine("Please enter a number in Fidget Spinners");
                        string input2 = Console.ReadLine().ToLower();
                        decimal num2 = decimal.Parse(input2);
                        decimal num22 = milSpin;
                        Console.WriteLine(num22 * num2 + " Inches");
                        break;
                    case "c":
                        Console.WriteLine("Please enter a number in Feet");
                        string input3 = Console.ReadLine().ToLower();
                        decimal num3 = decimal.Parse(input3);
                        int num33 = imperialFoot;
                        int num333 = milMeme;
                        Console.WriteLine((num3 * num33) * num333 + " Memes");
                        break;
                    case "d":
                        Console.WriteLine("Please enter a number in Memes");
                        string input4 = Console.ReadLine().ToLower();
                        decimal num4 = decimal.Parse(input4);
                        int num44 = milMeme;
                        Console.WriteLine(num44 * num4 + " Feet");
                        break;
                }
                Console.WriteLine("Would you like to enter another # y/n ?");
                response = Console.ReadLine().ToLower();
            } while (response == "y");
        }
    }
}
