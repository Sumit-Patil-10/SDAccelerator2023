// C# Array to List
Console.WriteLine("C# Array to List Example!");

// Array of string items
string[] names = { "Sumit Patil", "Sunil", "Sahil" };

// Covert array to List #1
Console.WriteLine("----AddRange method----");
List<string> list = new();
list.AddRange(names);
foreach(string name in names)
    Console.WriteLine(name);


// Convert array to List #2
Console.WriteLine("----ToList method----");
List<string> namesList = names.ToList();
foreach (string name in namesList)
    Console.WriteLine(name);

Console.ReadKey();
