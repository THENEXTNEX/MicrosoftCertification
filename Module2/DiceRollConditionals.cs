// Random dice = new();

// int roll1 = dice.Next(1,7);
// int roll2 = dice.Next(1,7);
// int roll3 = dice.Next(1,7);

// //Testing conditionals
// // int roll1 = 6;
// // int roll2 = 6;
// // int roll3 = 6;

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1)){

//     if((roll1 == roll2) && (roll2 == roll3)) {
//         Console.WriteLine("You rolled triples! +6 bonus to total!");
//         Console.WriteLine($"Your current total is {total}");
//         total+= 6;
//         Console.WriteLine($"Your new total {total}");
//     }
//     else{
//         Console.WriteLine("You rolled doubles! +2 bonus to total!");
//         Console.WriteLine($"Your current total is {total}");
//         total+= 2;
//         Console.WriteLine($"Your new total {total}");
//     }
// }

// if (total >= 16){
//     Console.WriteLine("You win a brand new car!");
// }
// else if (total >= 10){
//     Console.WriteLine("You win a brand new laptop!");
// }
// else if(total >= 5){
//     Console.WriteLine("You win brand new shoes!");
// }
// else{
//     Console.WriteLine("You win $20!");
// }