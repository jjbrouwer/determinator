Console.WriteLine("Discover your Hogwarts House!");
Console.WriteLine("The Sorting Hat will place you into your rightful house.");
Console.WriteLine("The Sorting Hat's decision is final...");
Console.WriteLine("Start the sorting ceremony...");

while (true)
{
    Console.WriteLine("What is your name?");

    var input = Console.ReadLine() ?? "";

    if (input == "") break;

    var options = new [] { "Hufflepuff", "Ravenclaw", "Slytherin", "Gryffindor" };
    var code = Determinator.Determinator.GetSimpleHashCode(input, options.Length);
    var value = options[code];

    Console.WriteLine($"You belong to.... {value}!");
    Console.WriteLine();
}