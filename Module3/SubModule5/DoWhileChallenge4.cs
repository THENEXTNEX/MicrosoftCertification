// /*
// Struggled a bit with this one - look over again
// */
// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

// int periodLocation;

// foreach (string item in myStrings){
//     string myString = item;
//     periodLocation = myString.IndexOf(".");

//     while(periodLocation != -1){
//         //Important note of SubString to take a smaller portion of the string
//         string sentence = myString.Substring(0, periodLocation).TrimStart();

//         Console.WriteLine(sentence);

//         myString = myString.Remove(0, periodLocation + 1).TrimStart();

//         periodLocation = myString.IndexOf(".");
//     }

//     if(!string.IsNullOrWhiteSpace(myString)){
//         Console.WriteLine(myString.TrimStart());
//     }
// }