Console.WriteLine("Hi");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd to TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine().ToUpper();
bool isUserInputA = userChoice == "A";

Console.WriteLine(isUserInputA);

switch (userChoice)
{

    case "S":
        PrintSelectedOption("See all TODOs");
        break;
    case "a":
    case "A":
        PrintSelectedOption("Add to TODO");
        break;
    case "R":
        PrintSelectedOption("Remove a TODO");
        break;
    case "E":
        PrintSelectedOption("Exit");
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;
}

var a = 5;
var b = 10;
var c = 3;
Console.WriteLine($"{a} {b} {c}");
Console.WriteLine(Add(a, b) / c);
Console.WriteLine("User has chose: " + userChoice);



Console.ReadKey();

static void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}

int Add(int a, int b)
{
    return a + b;
}