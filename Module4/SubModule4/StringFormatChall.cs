// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// string introMsg = "offering we are excited to tell you about a new financial product that would dramatically increase your return.";
// // Your logic here
// Console.WriteLine($"Dear {customerName}\nAs a customer of our {currentProduct} {introMsg}");
// Console.WriteLine($"Currently, you own {currentShares:N2} shares are a return of {currentReturn:P2}");
// Console.WriteLine($"Our new product {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}");

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