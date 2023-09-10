// static void coinFlip()
//     {
//       Random Random = new Random();
//       int coinFlip = Random.Next(0, 2);
//       int coinFlips = 10;

//       int countHeads = 0;
//       int countTails = 0;

//       for (int i = 0; i < coinFlips; i++)
//       {
//         coinFlip = Random.Next(0, 2);
//         if (coinFlip == 0)
//         {
//           Console.WriteLine("Heads");
//           countHeads++;
//         }
//         else
//         {
//           Console.WriteLine("Tails");
//           countTails++;
//         }
//       }
//       Console.WriteLine($"Heads: {countHeads}, Tails: {countTails}");
//     }