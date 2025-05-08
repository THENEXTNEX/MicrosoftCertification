// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// string quantity = "";
// string output = "";
// string openSpan = "<span>";
// string closeSpan = "</span>";
// string openDiv = "<div>";
// string closeDiv = "</div>";
// int spanLength = 6;
// int divLength = 5;

// // Your work here
// int startSpan = input.IndexOf(openSpan) + spanLength;
// int endSpan = input.IndexOf(closeSpan);
// int stringLength = endSpan - startSpan;

// quantity = input.Substring(startSpan, stringLength);

// string removed = "";

// int startDiv = input.IndexOf(openDiv) + divLength;
// int endDiv = input.IndexOf(closeDiv);

// removed = input.Remove(startDiv - divLength, divLength).Remove(endDiv - divLength, divLength+1);
// removed = removed.Replace("trade", "reg");


// Console.WriteLine($"Quantity: {quantity}");
// Console.WriteLine(removed);