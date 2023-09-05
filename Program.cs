// string[] fraudluentOrderIDs = new string[3];

// fraudluentOrderIDs[0] = "A123";
// fraudluentOrderIDs[1] = "B456";
// fraudluentOrderIDs[2] = "C789";
// fraudluentOrderIDs[3] = "666";

string[] fraudluentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine("First:\t" + fraudluentOrderIDs[0]);
Console.WriteLine("Second:\t" + fraudluentOrderIDs[1]);
Console.WriteLine("Third:\t" + fraudluentOrderIDs[2]);

fraudluentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign first:\t {fraudluentOrderIDs[0]}");

Console.WriteLine($"There are {fraudluentOrderIDs.Length} fraudulent orders to process.");