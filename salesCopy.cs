// // Exercise - Complete a challenge to apply string interpolation to a form letter
// // my solution to the challenge
// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// // Your logic here

// Console.WriteLine("Here's a quick comparison:\n");

// // string comparisonMessage = "";
// string greeting = $"Dear Ms. {customerName},";
// string title = "As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.";
// string customerMessage = $"Currently, you own {currentShares:N} shares at a return of {currentReturn:P2}.";
// string newProductInfo = $"Our new product, {newProduct}, offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}.";

// string quickComparison = "\nHere's a quick comparison:\n";
// string productTable = $"Magic Yeild\t\t {currentReturn:P2}\t{currentProfit:C}\nGlorious Future\t\t {newReturn:P2}\t{newProfit:C}";

// // Your logic here

// Console.WriteLine($"{greeting}\n{title}\n\n{customerMessage}\n\n{newProductInfo}\n\n{quickComparison}\n{productTable}\n\nWe look forward to hearing from you,\n\nDaniyar Suleymanov\nHead of Finance");


// // solution from the course
// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// Console.WriteLine($"Dear {customerName},");
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
// Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";

// comparisonMessage = currentProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

// comparisonMessage += "\n";
// comparisonMessage += newProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

// Console.WriteLine(comparisonMessage);