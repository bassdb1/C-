// adding this namespace, or library in my program.
using System;

// Namespace
namespace NumberGuesser
{
    // Main Class - Inside this class, I can have Methods(functions) and properties (variables), I can also make objects
    class Program
    {
        // Entry Point Method for our Application
        static void Main(string[] args)
        {
            // Here is where we start our code

            GetAppInfo();  // This function gets AppInfo

            GreetUser();   // Ask for users name and greet

            // While Loop to keep this program from starting - on going loop
            while (true)
            {

                // Initialize correct number for the game
                // int correctNumber = 7;


                //Create a new Random object
                Random random = new Random();

                // Creates a random number between 1 and 10 
                int correctNumber = random.Next(1, 10);


                // Initialize the guessNumber variable to 0
                int guessNumber = 0;

                // Ask user for a number
                Console.WriteLine("Guess a number between 1 and 10");

                //while loop - to run until the right number is chosen
                while (guessNumber != correctNumber)
                {
                    // Get users input, and store the value in the variable inputGuess
                    string inputGuess = Console.ReadLine();

                    //Make sure the user entered a number
                    if (!int.TryParse(inputGuess, out guessNumber))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");

                        // Keep going, breaks out of the loop
                        continue;

                    }

                    // Cast 'String' Input from user into an int
                    guessNumber = Int32.Parse(inputGuess);

                    // If statement to give a message if the number is wrong
                    if (guessNumber != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

               
                // Output success message
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!");


                // Ask the user if they want to play again
                Console.WriteLine("Play Again? [ Y or N]");

                // Get Answer 
                string answer = Console.ReadLine().ToUpper();

                //Check Answer

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N") {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        // Get and Display App Info
        static void GetAppInfo()
        {
            // Set App Vars - Header
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "David Bass";

            // Change Header Color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out Header to the Screen
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Change text color back to default
            Console.ResetColor();
        }
        // Ask users name and greet
        static void GreetUser()
        {
            // Ask for users name
            Console.WriteLine("What is your name?");

            // Get user input and store input in the variable userName
            string userName = Console.ReadLine();

            // Display users name and ask if they want to play a game
            Console.WriteLine("Hello {0}, let's play a game...", userName);

        }
        // Print color message, will take parameters
        static void PrintColorMessage(ConsoleColor color, string message)  // define the arguments
        {
            // Change text Color
                // Console.ForegroundColor = ConsoleColor.Red;  // before Method
            Console.ForegroundColor = color;  // Using  Method


            // Tell user it is not a number
                // Console.WriteLine("Please enter an actual number"); // before Method
            Console.WriteLine(message); // Using Method


            // Change text color back to default
            Console.ResetColor();
        }
    }
}
