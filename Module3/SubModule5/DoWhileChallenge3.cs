// string? readResult;
// bool validInput = false;
// string removeFormat; 

// do{
//     Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
//     readResult = Console.ReadLine();
//     if(readResult != null){
//         removeFormat = readResult.Trim().ToLower();
//         if(removeFormat.Contains("administrator") || removeFormat.Contains("manager") || removeFormat.Contains("user")){
//             validInput = true;
//             continue;
//         }
//         else{
//             Console.WriteLine($"The role name you entered, \"{readResult}\" is not valid");
//             continue;
//         }
//     }
// }while(validInput == false);

// Console.WriteLine($"Your input ({readResult} has been accepted)");