// int hero_health = 10;
// int monster_health = 10;
// Random weapon = new();

// do{

//     int hero_attack = weapon.Next(1,10);

//     monster_health -= hero_attack;

//     Console.WriteLine($"Monster was damaged and lost {hero_attack} health and now has {monster_health} health");

//     if (monster_health <= 0) continue;

//     int monster_attack = weapon.Next(1,10);

//     hero_health -= monster_attack;

//     Console.WriteLine($"Hero was damaged {monster_attack} health and now has {hero_health} health");

//     if (hero_health <= 0) continue;
// }while(hero_health > 0 && monster_health > 0);

// Console.WriteLine(hero_health > monster_health ? "Hero Wins!" : "Monster Wins!");