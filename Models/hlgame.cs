using System;

namespace HLGame
{

  class HLGame
  {
    private int Number=50;
    private int MaxBound= 101;
    private int MinBound= 0;
    private bool EndGame= false;
    private int ComputerNumber;
    public void Result()
    {
      Random RandomNumber = new Random();
      ComputerNumber = RandomNumber.Next(1,100);
    }
    public void Guess(string userInput){
      if (userInput == "Lower")
      {
        MaxBound = Number;
        Number= (MaxBound+MinBound)/2;
        Console.WriteLine("Is your number higher or lower than " +Number+ "(Higher/Lower/Correct)");
      } else if (userInput == "Higher")
      {
        MinBound = Number;
        Number= (MaxBound+MinBound)/2;
        Console.WriteLine("Is your number higher or lower than "+Number+ "(Higher/Lower/Correct)");
      } else if (userInput == "Correct")
      {
        EndGame = true;
      }
    }

    public void UserGuess(int userGuess)
    {
      if (userGuess > ComputerNumber)
      {
        Console.WriteLine("Lower");
      }
      else if (userGuess < ComputerNumber)
      {
        Console.WriteLine("Higher");
      }
      else if (userGuess == ComputerNumber)
      {
        Console.WriteLine("You Got it!");
        EndGame = true;
      }
    }

    public bool GetEndGame()
    {
      return EndGame;
    }
  }
}
