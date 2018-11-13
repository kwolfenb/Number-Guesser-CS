using System;

namespace HLGame
{

  class HLGame
  {
    private int Number=50;
    private int MaxBound= 101;
    private int MinBound= 0;
    private bool EndGame= false;
    public void Guess(string userInput){
      if (userInput == "Lower")
      {
        MaxBound = Number;
        Number= (MaxBound+MinBound)/2;
        Console.WriteLine("Is your number higher or lower than "+Number+ "(Higher/Lower/Correct)");
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
    public int GetNumber() {
      return Number;
    }
    public bool GetEndGame()
    {
      return EndGame;
    }
  }
}
