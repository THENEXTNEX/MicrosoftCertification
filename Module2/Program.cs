Random random = new();

int daysUntilExpirations = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpirations <= 10 && daysUntilExpirations > 5){
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if (daysUntilExpirations <= 5 && daysUntilExpirations > 1){
    Console.WriteLine($"Your subscription ends in {daysUntilExpirations} days.");
    discountPercentage = 10;
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpirations <= 1 && daysUntilExpirations != 0){
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpirations == 0){
    Console.WriteLine("Your subscription has expired");
}
else{
    Console.WriteLine("");
}

Console.WriteLine($"Expiration = {daysUntilExpirations}");
Console.WriteLine($"Disount = {discountPercentage}%");