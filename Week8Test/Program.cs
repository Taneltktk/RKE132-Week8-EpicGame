//string path = @"C:\data";
//string fileName = "chuck.txt";

//string[] lines = File.ReadAllLines(Path.Combine(path, fileName));

//foreach (string hero in lines)
//{
//    Console.WriteLine(hero);
//}

//1 - ok
//string path = @"C:\data";
//string fileName = "chuck.txt";
//string[] lines = File.ReadAllLines(Path.Combine(path, fileName));
//Console.WriteLine(lines.Length);

//2 - vale
//string path = @"C:\data";
//string fileName = "chuck.txt";
//string[] lines = File.ReadAllLines($"{path} + {fileName}");

//foreach (string hero in lines)
//{
//    Console.WriteLine(hero);
//}

//3 - vale
//string path = @"C:\data";
//string fileName = "chuck.txt";
//string[] lines = File.ReadAllLines(path + fileName);

//foreach (string hero in lines)
//{
//    Console.WriteLine(hero);
//}

//4 - õige
//string path = @"C:\data\";
//string fileName = "chuck.txt";
//string[] lines = File.ReadAllLines(path + fileName);

//foreach (string hero in lines)
//{
//    Console.WriteLine(hero);
//}




//5
string path = @"C:\data";
string fileName = "chuck.txt";
string[] lines = File.ReadAllLines(Path.Combine(path, fileName));

ShowFileContent(lines);

static void ShowFileContent(string[] fileContentArray)
{
    int i = new int();
    foreach (string line in fileContentArray)
    {
        Console.WriteLine($"{i}. {fileName}");
        i++;
    }
}