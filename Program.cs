using System;

//Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry Point Method 
        static void Main(string[] args)
        {
            //run function to grab version info 
            GetAppInfo();

            //Ask for user's name and greet 
            GreetUser(); 

            while (true)
            {

                //create new random Object 
                Random random = new Random();

                int correctNum = random.Next(1, 11);


                //Init guess variable
                int guess = 0;

                //ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //while guess is not correct 
                while (guess != correctNum)
                {
                    //get users input 
                    string input = Console.ReadLine();

                    //Make sure input val is a number 
                    if (!int.TryParse(input, out guess))
                    {
                        //call function created below to change color and show error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter a NUMBER!"); 

                        //continue on with program  
                        continue;
                    }
                    //Cast to Int and put in guess variable 
                    guess = Int32.Parse(input);

                    //if the guess does not match the correct number
                    if (guess != correctNum)
                    {
                        //call function to change color and show error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong, guess again!");
                    }

                }

                // Success message for correct guesses 

                //call function to change color and show success message
                PrintColorMessage(ConsoleColor.Cyan, "WINNER YOU ARE CORRECT!");

                //Ask user if they'd like to play again
                Console.WriteLine("Play Again? [Y or N]");

                //Get Answer 
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
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

        static void GetAppInfo()
        {
            // Set variables for app 
            string appName = "Number Guess Game!";
            string appVersion = "1.0.0";
            string appAuthor = "Brandi Murray";

            // changing text color 
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info 
            Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");

            //Resets Text Color
            Console.ResetColor();
        }

        static void GreetUser() {
            //Asks Users name 
            Console.WriteLine("What is your name?");

            //Get user input 

            string inputName = Console.ReadLine();

            //Text to start game with user's name

            Console.WriteLine($"Hello {inputName}, let's play a game!");
        }

        //for changing the console color and writing a custom message 
        static void PrintColorMessage(ConsoleColor color, string message){
            // change text color 
            Console.ForegroundColor = color;

            //Write error message (must be a number) 
            Console.WriteLine(message);

            //Resets Text Color
            Console.ResetColor();
        }

    }
}
