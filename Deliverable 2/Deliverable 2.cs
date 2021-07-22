using System;

namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to say to the Chat Bot ?");
            string response = Console.ReadLine().ToLower();

            string answer = null;
            do
            {
                switch (response)
                {
                    case "hello":
                        Console.WriteLine("Hi, good to see you !" + "\nWould you like to continue y/n ?");
                        string response1 = Console.ReadLine();
                        if (response1 == "hello")
                        { 
                            Console.WriteLine("I'm sorry, but you have already said that."); 
                        }
                        break;

                    case "sup":
                        Console.WriteLine("I am good" + "\nWould you like to continue y/n ?");
                        string response2 = Console.ReadLine();
                        if (response2 == "sup")
                        {
                            Console.WriteLine("I'm sorry, but you have already said that.");
                        }
                        break;

                    case "hello there":
                        Console.WriteLine("General Kenobi" + "\nWould you like to continue y/n ?");
                        string response3 = Console.ReadLine();
                        if (response3 == "hello there")
                        {
                            Console.WriteLine("I'm sorry, but you have already said that.");
                        }
                        break;

                    case "bye":
                        Console.WriteLine("Good Bye !");
                        break;
                    default:
                        break;

                }
            } while (response == "y");
        }
    }
}
