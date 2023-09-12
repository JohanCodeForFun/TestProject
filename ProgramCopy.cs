// // Console.WriteLine("Signed integral types:");

// // Console.WriteLine($"sbyte\t: {sbyte.MinValue} to {sbyte.MaxValue}");
// // Console.WriteLine($"short\t: {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int\t: {int.MinValue} to {int.MaxValue}");
// // Console.WriteLine($"long\t: {long.MinValue} to {long.MaxValue}");

// // Console.WriteLine("");
// // Console.WriteLine("Unsigned integral types:");
// // // write byte, ushort, uint, ulong min and max values in Console.WriteLine
// // Console.WriteLine($"byte\t: {byte.MinValue} to {byte.MaxValue}");
// // Console.WriteLine($"ushort\t: {ushort.MinValue} to {ushort.MaxValue}");
// // Console.WriteLine($"uint\t: {uint.MinValue} to {uint.MaxValue}");
// // Console.WriteLine($"ulong\t: {ulong.MinValue} to {ulong.MaxValue}");

// // write floating point types min and max values in Console.WriteLine
// // Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float\t: {float.MinValue} to {float.MaxValue}");
// Console.WriteLine($"double\t: {double.MinValue} to {double.MaxValue}");
// Console.WriteLine($"decimal\t: {decimal.MinValue} to {decimal.MaxValue}");


// // using System;
// // using cSharp_Practice;

// // namespace cSharp_Practice
// // {
// //   class Program
// //   {
// //     static void Main(string[] args)
// //     {
// //       Console.WriteLine("Hello World!");
// //       // userValidation("Admin", 60);
// //       // userValidation("Admin", 20);
// //       // userValidation("Manager", 20);
// //       // userValidation("Manager", 8);
// //       // userValidation("User", 0);
// //       // coinFlip();
// //       // Q: how do i solve The name 'coinFlip' does not exist in the current context
// //       // A: declare the method coinFlip() before calling it
// //       // coinFlip();
// //       // Q: how do i import a method from another file?
// //       // A: use the using keyword
// //       // q: how do I import coinFlip from coinFlip.cs?
// //       // a: using cSharp_Practice;
// //       // fizzBuzz();
// //       // doWhile();
// //       rpgGame();
// //     }

// //     static void rpgGame()
// //     {
// //       int playerHealth = 10;
// //       int monsterHealth = 10;
// //       Random random = new Random();

// //       int attack = random.Next(1, 11);

// //       do
// //       {
// //         monsterHealth -= attack;
// //         Console.WriteLine($"Monster was damaged and lost {attack} health and how has {monsterHealth} health.");

// //         if (monsterHealth <= 0) continue;

// //         playerHealth -= attack;
// //         Console.WriteLine($"Player was damaged and lost {attack} health and how has {playerHealth} health.");
// //       } while (playerHealth > 0 && monsterHealth > 0);

// //       Console.WriteLine(playerHealth > monsterHealth ? "Hero wins!" : "Monster wins!");
// //     }

// //     static void doWhile()
// //     {
// //       Random random = new Random();
// //       int current = 0;

// //       do
// //       {
// //         current = random.Next(1, 11);
// //         Console.WriteLine(current);
// //       } while (current != 7);
// //     }
// //     static void fizzBuzz()
// //     {
// //       for (int i = 1; i <= 100; i++)
// //       {

// //         if (i % 3 == 0 && i % 5 == 0)
// //         {
// //           Console.WriteLine(i + " - FizzBuzz");
// //         }

// //         else if (i % 3 == 0)
// //         {
// //           Console.WriteLine(i + " - Fizz");
// //         }

// //         else if (i % 5 == 0)
// //         {
// //           Console.WriteLine(i + " - Buzz");
// //         }

// //         else
// //         {
// //           Console.WriteLine(i);
// //         }
// //       }
// //     }

// //     static void userValidation(string permission, int level)
// //     {
// //       // string permission = "Admin|Manager";
// //       // int level = 55;

// //       if (permission == "Admin")
// //       {
// //         if (level > 55)
// //         {
// //           Console.WriteLine("Welcome, Super Admin");
// //         }
// //         else if (level <= 55)
// //         {
// //           Console.WriteLine("Welcome, Admin user");
// //         }
// //         else if (level >= 20)
// //         {
// //           Console.WriteLine("Contact a Manager for access.");
// //         }
// //       }

// //       else if (permission == "Manager")
// //       {
// //         if (level >= 20)
// //         {
// //           Console.WriteLine("Contact an Admin for access.");
// //         }
// //         else if (level < 20)
// //         {
// //           Console.WriteLine("You do not have sufficient privileges.");
// //         }
// //         else
// //         {
// //           Console.WriteLine("You do not have sufficient privileges.");
// //         }
// //       }
// //       else
// //       {
// //         Console.WriteLine("You do not have sufficient privileges.");
// //       }
// //     }
// //   }
// // }