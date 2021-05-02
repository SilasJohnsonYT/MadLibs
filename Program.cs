using System;

namespace Libs_Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            // god bagels are so freaking good
            // credit to Silas Johnson and Lemon. Use with credit.

            Console.Title = "Mad Libs Console";

            string num01;
            string num02;
            string num03;
            string name01;
            string name02;
            string name03;
            string noun01;
            string noun02;
            string noun03;
            string plNoun01;
            string plNoun02;
            string plNoun03;
            string adj01;
            string adj02;
            string adj03;
            string verb01;
            string verb02;
            string verb03;
            // holy shit that's a lot of variables
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WindowHeight = 40;
            Console.WriteLine("Welcome to Mad Libs Console! A game about putting words into stories that you don't know.\nPress any key to continue...");
            Console.ReadKey();

            // menu shit lol

            Console.Clear();
            Console.WriteLine("Please enter a number 1-5 to pick a story.");
            int story = Convert.ToInt32(Console.ReadLine());

            if(story < 1 || story > 5){
                Console.WriteLine("That isn't valid.");
                Console.ReadKey();
            }
            if(story == 1){
                Console.WriteLine("You have chosen Story 1! Press Enter to type some words...");
                Console.ReadKey();
                Console.Write("Type a number: ");
                Console.ForegroundColor = ConsoleColor.Black;
                num01 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("You have chosen " + num01 + "! Nice one. Press Enter to continue...");
                Console.ReadKey();
                Console.Write("We're going to need 2 more numbers. Type another here: ");
                Console.ForegroundColor = ConsoleColor.Black;
                num02 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(num02 + ", another great choice. Press Enter to continue...");
                Console.ReadKey();
                Console.Write("And now for our final number... ");
                Console.ForegroundColor = ConsoleColor.Black;
                num03 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("..." + num03 + ". Very dapper. Press Enter to continue...");
                Console.ReadKey();
                Console.Clear();
                
                //names now lol

                Console.WriteLine("And now for our next category...\n\nNAMES!");

                //this is lemon code realm
                //ugh

                Console.WriteLine("Type the first name you want to enter...");
                Console.ForegroundColor = ConsoleColor.Black;
                name01 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(name01 + ". Nice name! Thats what I'm naming my child! Press Enter to continue...");
                Console.ReadKey();
                Console.WriteLine("Type your next name...");
                Console.ForegroundColor = ConsoleColor.Black;
                name02 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Wow, " + name02 + ". That's beutiful! Press Enter to continiue...");
                Console.ReadKey();
                Console.WriteLine("Now time for your last name...");
                Console.ForegroundColor = ConsoleColor.Black;
                name03 = Console.ReadLine();
                Console.Clear();
                
                //nounssss

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Time for...\n\nNouns!");
                Console.WriteLine("Type a noun, any noun...");
                Console.ForegroundColor = ConsoleColor.Black;
                noun01 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(noun01 + ", that's my favorite noun! Press Enter to coninue..."); //this is a comment
                Console.ReadKey();
                Console.WriteLine("Type your next noun...");
                Console.ForegroundColor = ConsoleColor.Black;
                noun02 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(noun02 + ", that is an amazing noun! Press Enter to continue...");
                Console.ReadKey();
                Console.WriteLine("Time for your very last noun...");
                Console.ForegroundColor = ConsoleColor.Black;
                noun03 = Console.ReadLine();
                Console.Clear();

                //plural noun yes yes
                
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Next category is...\n\nPlural Nouns!\nSimilar to nouns, but many of them!");
                Console.WriteLine("Type your first of many plural nouns here...");
                Console.ForegroundColor = ConsoleColor.Black;
                plNoun01 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(plNoun01 + ", That is indeed plural! Press Enter to continue...");
                //silas code here
                //lemon just painted mah nails, we gettin freaky on a saturday night yea
                Console.WriteLine("And now onto our second plural noun! Or the fourth? I can't really tell...\nType another plural noun...");
                plNoun02 = Console.ReadLine();

            }
        }
    }
}
