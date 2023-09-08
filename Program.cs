using System;

namespace cSharp_Practice
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      // userValidation("Admin", 60);
      // userValidation("Admin", 20);
      // userValidation("Manager", 20);
      // userValidation("Manager", 8);
      // userValidation("User", 0);
      // coinFlip();
      fizzBuzz();

    }
    static void fizzBuzz()
    {
      for (int i = 0; i <= 100; i++)
        Console.WriteLine(i);
      // return 0;
    }
    static void coinFlip()
    {
      Random Random = new Random();
      int coinFlip = Random.Next(0, 2);
      int coinFlips = 10;

      int countHeads = 0;
      int countTails = 0;

      for (int i = 0; i < coinFlips; i++)
      {
        coinFlip = Random.Next(0, 2);
        if (coinFlip == 0)
        {
          Console.WriteLine("Heads");
          countHeads++;
        }
        else
        {
          Console.WriteLine("Tails");
          countTails++;
        }
      }
      Console.WriteLine($"Heads: {countHeads}, Tails: {countTails}");
    }

    static void userValidation(string permission, int level)
    {
      // string permission = "Admin|Manager";
      // int level = 55;

      if (permission == "Admin")
      {
        if (level > 55)
        {
          Console.WriteLine("Welcome, Super Admin");
        }
        else if (level <= 55)
        {
          Console.WriteLine("Welcome, Admin user");
        }
        else if (level >= 20)
        {
          Console.WriteLine("Contact a Manager for access.");
        }
      }

      else if (permission == "Manager")
      {
        if (level >= 20)
        {
          Console.WriteLine("Contact an Admin for access.");
        }
        else if (level < 20)
        {
          Console.WriteLine("You do not have sufficient privileges.");
        }
        else
        {
          Console.WriteLine("You do not have sufficient privileges.");
        }
      }
      else
      {
        Console.WriteLine("You do not have sufficient privileges.");
      }
    }
  }
}