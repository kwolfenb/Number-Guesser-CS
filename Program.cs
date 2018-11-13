using System;
using System.Collections.Generic;

namespace HLGame
{
  public class Program
  {
    public static void Main()
    {
      HLGame hLGame = new HLGame();
      string userInput="";
      Console.WriteLine("Would you like to play the higher/lower game? (Yes/No)");
      string startGame= Console.ReadLine();
      if (startGame=="Yes")
      {
        Console.WriteLine("Is your number higher or lower than 50? (Higher/Lower/Correct)");
        do
        {
          userInput=Console.ReadLine();
          hLGame.Guess(userInput);
        } while (!hLGame.GetEndGame());
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }
      Console.WriteLine("Great! I guessed your number. Would you like to play again? (Yes/No)");
      string continueGame= Console.ReadLine();
      if (continueGame=="Yes")
      {
        Main();
      }
    }
  }
}
