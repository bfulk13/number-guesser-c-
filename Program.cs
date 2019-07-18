using System;

// namespace
namespace NumberGuesser
{
    // main class
    class Program
    {
        // entry point method
        public static void Main(string[] args)
        {
            GetAppInfo();  // run GetAppInfo function

            GreetUser();

            while (true) { 

                // Set correct number
                //int correctNumber = 7;

                // create a random object
                Random random = new Random();

                // init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // ask user for number
                Console.WriteLine("Guess a number between 1 and 10.");

                // while guess is not correct
                while (guess != correctNumber)
                {
                    // get users input
                    string input = Console.ReadLine();

                    // Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        // print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use a valid number");

                        // keep going
                        continue;
                    }

                    // convert to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again!");
                    }
                }
                // print success message
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!");

                // ask user to play again
                Console.WriteLine("Do you want to play again? [Y or N]");

                // get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        // get and display app info
        static void GetAppInfo()
        {
            // set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Barry Fulk";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // reset color to default
            Console.ResetColor();
        }

        // ask users name and greet
        static void GreetUser()
        {
            // ask user's name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game...", inputName);
        }

        // print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user it is not a number
            Console.WriteLine(message);

            // reset color to default
            Console.ResetColor();
        }
    }
}
