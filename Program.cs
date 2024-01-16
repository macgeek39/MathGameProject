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
{divider}");

userOption = Console.ReadKey().KeyChar;
Console.WriteLine($"\nYou chose the option: {userOption}");
