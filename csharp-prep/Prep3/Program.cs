using System;

class Program
{
    static void Main(string[] args)
    {
      var magicNumber = new Random().Next(1, 100);
      Console.WriteLine("Guess a number between 1 and 100:");
      int guess = Convert.ToInt32(Console.ReadLine());
      while (guess != magicNumber)
      {
        if (guess > magicNumber)
        {
          Console.WriteLine("Lower");
        }
        else
        {
          Console.WriteLine("Higher");
        }
        guess = Convert.ToInt32(Console.ReadLine());
      }
      Console.WriteLine("You guessed it!");
    }
}
