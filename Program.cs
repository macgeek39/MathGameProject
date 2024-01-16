var divider = "----------------------------------";



Console.WriteLine("What's your name?");
var name = Console.ReadLine();
DateTime date = DateTime.Now;
var gamesPlayed = 0;
char userOption;
decimal averageScore;
var isScoreEmpty = true;

Console.WriteLine(@$"{divider}
Hello {name}! 
Today is {date}. 
This is your math's game. 
That's great that you're working on improving yourself!");
Console.WriteLine(divider);
Console.WriteLine("Press any key to continue.");
Console.ReadLine();
Console.Clear();
Console.WriteLine($"Games played: {gamesPlayed}");
Console.WriteLine(@$"What game would you like to play?
{divider}
A - Addition
S - Subtraction
M - Multiplication
D - Division
V - View Previous Games
Q - Quit The Program
{divider}");

userOption = Console.ReadKey().KeyChar;

if (char.ToLower(userOption) == 'a')
{
    Console.WriteLine("\nAddition selected");
}
else if (char.ToLower(userOption) == 's')
{
    Console.WriteLine("\nSubtraction selected");
}
else if (char.ToLower(userOption) == 'm')
{
    Console.WriteLine("\nMultiplication selected");
}
else if (char.ToLower(userOption) == 'd')
{
    Console.WriteLine("\nDivision selected");
}
else if (char.ToLower(userOption) == 'v')
{
    Console.WriteLine("\nView previous games selected");
}
else if (char.ToLower(userOption) == 'q')
{
    Console.WriteLine("\nByeeeeeeeeeeeeee!!");
}
else
{
    Console.WriteLine("\nInvalid input");
}