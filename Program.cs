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
      Console.WriteLine("Would you like to play the higher/lower game (1) Or guess my number? (2) (Enter 1 or 2)");
      string startGame= Console.ReadLine();
      if (startGame=="1")
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
        hLGame.Result();
        Console.WriteLine("I will pick a number. What is your guess?");
        do
        {

        int userGuess = int.Parse(Console.ReadLine());
        hLGame.UserGuess(userGuess);
        } while (!hLGame.GetEndGame());

        // string userGuessString = Console.ReadLine();
        // int userGuess = int.Parse(userGuessString);
      }
      Console.WriteLine("Would you like to play again? (Yes/No)");
      string continueGame= Console.ReadLine();
      if (continueGame=="Yes")
      {
        Main();
      }
    }
  }
}
