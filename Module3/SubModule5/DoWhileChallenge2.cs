//string? readresult;
// bool validInput = false;
// int number = 0;
// Console.WriteLine("Enter an integer value between 5 and 10: ");

// do{
    
//     bool validNumber = false;
//     readresult = Console.ReadLine();
//     validNumber = int.TryParse(readresult, out number);
//     if(validNumber == false){
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//         continue;
//     }
//     else if(validNumber == true){
//         if(number < 5 || number > 10){
//             Console.WriteLine($"You entered {number}. Please enter a number between 5 and 10");
//             continue;
//         }
//         else{
//         validInput = true;
//         continue;
//         }
//     }
    
// }while(validInput == false);

// Console.WriteLine($"Your input value ({number}) has been accepted");