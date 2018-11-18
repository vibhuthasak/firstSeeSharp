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
      GreetUser();

      while(true) {
        int guessNumber = 0;

        Random random = new Random();
        int correctNumber = random.Next(1, 10);

        Console.WriteLine("Guess a number between 1 and 10");

        while(guessNumber != correctNumber) {
          string input = Console.ReadLine();

          // Make sure it is a number
          if(!int.TryParse(input, out guessNumber)){
            PrintColorMessage(ConsoleColor.Red, "Please enter valid Number");
            continue;
          }

          guessNumber = Int32.Parse(input);

          if(guessNumber != correctNumber) {
            PrintColorMessage(ConsoleColor.DarkRed, "Incorrect Number. Try Again...");
          }
        }

        PrintColorMessage(ConsoleColor.Yellow, "CORRECT");

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

    static void GreetUser(){
      // Ask user name
      Console.WriteLine("What is your name ?");

      string inputName = Console.ReadLine();

      Console.WriteLine("Hello {0}, Welcome to the game....", inputName);
    }

    static void PrintColorMessage(ConsoleColor color, string message) {
      Console.ForegroundColor = color;

      // Writing out app info
      Console.WriteLine(message);

      // Resetting color
      Console.ResetColor();
    }
  }
}