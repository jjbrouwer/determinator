Console.WriteLine("Discover your Hogwarts House!");
Console.WriteLine("The Sorting Hat will place you into your rightful house.");
Console.WriteLine("The Sorting Hat's decision is final...");
Console.WriteLine("Start the sorting ceremony...");
Console.WriteLine("What is your name?");

var input = Console.ReadLine() ?? "";
var code = Determinator.Determinator.GetSimpleHashCode(input, 4);

Console.WriteLine($"You belong to.... {GetHouse(code)}!");

static string GetHouse(short code) =>
    code switch
    {
        1 => "Ravenclaw",
        2 => "Hufflepuff",
        3 => "Slytherin",
        _ => "Gryffindor",
    };