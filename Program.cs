using System;

// Namespace
namespace NumberGuess_App
{
  // Main Class
  class Program
  {
    //Entry Point Method
    static void Main(string[] args)
    {
      GetAppInfo();

      while(true) {
        int guessNumber = 0;

        Random random = new Random();
        int correctNumber = random.Next(1, 10);

        Console.WriteLine("Guess a number between 1 and 10");

        while(guessNumber != correctNumber) {
          string input = Console.ReadLine();

          // Make sure it is a number
          if(!int.TryParse(input, out guessNumber)){
            Console.ForegroundColor = ConsoleColor.Red;
            // Tell user NAN
            Console.WriteLine("{0} is not a number", input);
            // Resetting color
            Console.ResetColor();
            continue;
          }

          guessNumber = Int32.Parse(input);

          if(guessNumber != correctNumber) {
            Console.ForegroundColor = ConsoleColor.Red;
            // Tell user incorrect
            Console.WriteLine("{0} is not the correct Number. Try again....", guessNumber);
            // Resetting color
            Console.ResetColor();
          }
        }

        Console.ForegroundColor = ConsoleColor.Blue;
        // Tell user Correct
        Console.WriteLine("{0} is the CORRECT Number..", guessNumber);
        // Resetting color
        Console.ResetColor();

        // Ask to play again
        Console.WriteLine("Play Again ? [Y or N]");

        // Get the answer from the user
        string answer = Console.ReadLine().ToUpper();

        if (answer == "Y") {
          continue;
        } else {
          return;
        }
      }
    }

    static void GetAppInfo(){
      // App Variables
      string appName = "Number Guesser";
      string appVersion = "0.0.1";
      string appAuthor = "Vibhutha Kumarage";

      // Change console text color into Cyan
      Console.ForegroundColor = ConsoleColor.Cyan;

      // Writing out app info
      Console.WriteLine("{0} : Version {1} by {2}", appName, appVersion, appAuthor);

      // Resetting color
      Console.ResetColor();
    }
  }
}