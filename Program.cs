using System;

// Namespace

namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function to get info

            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

            while (true)
            {


                // Init correct number
                //int correctNumber = 7;

                // Create a new Random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {

                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {

                        // Change text color
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        // Tell user its not a number
                        Console.WriteLine("Please enter an actual number");


                        // Reset text color
                        Console.ResetColor();

                        // Keep going
                        continue;

                    }


                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Change text color
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        // Tell user its the wrong number
                        Console.WriteLine("Wrong number, please try again");

                        // Reset text color
                        Console.ResetColor();

                    }

                }

                // Change text color
                Console.ForegroundColor = ConsoleColor.DarkBlue;

                // Tell user its the right number
                Console.WriteLine("You are CORRECT!!!");

                // Reset text color
                Console.ResetColor();


                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
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


                Console.ReadKey();
            }

        }

        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Denis Rafi";

            // Change text color
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }
    }
}
