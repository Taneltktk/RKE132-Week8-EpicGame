using System.Runtime.CompilerServices;

string folderPath = @"C:\data";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath,heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));


//string[] heroes = { "Batman", "Ironman", "Johnny Bravo", "Robocop" };
//string[] villains = { "Käsnakalle", "Teletups", "Lotte", "Muumipapa", "Elmo" };



string[] weapon = { "hundinui", "kirvevars", "käekott", "padi", "porgand" };

//Random rnd = new Random();
//int randomIndex = rnd.Next(0, heroes.Length);

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} wielding {heroWeapon} saves the day!");

string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} wielding {villainWeapon} tries to take over the world");


static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}