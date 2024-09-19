using System;

class Program
{
    static void Main(string[] args)
    {
      string letter;
      Console.WriteLine("What is your grade?");
      var grade = Convert.ToInt32(Console.ReadLine());

      if (grade >= 90)
      {
        letter = "A";
      } else if (grade >= 80)
      {
        letter = "B";
      } else if (grade >= 70)
      {
        letter = "C";
      } else if (grade >= 60)
      {
        letter = "D";
      } else
      {
        letter = "F";
      }

      Console.WriteLine($"Your grade is {letter}");

      if (grade >= 70)
      {
        Console.WriteLine("Props mate!");
      } else
      {
        Console.WriteLine("Better luck next time!");
      }
    }
}
