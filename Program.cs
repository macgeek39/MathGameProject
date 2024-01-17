﻿var divider = "----------------------------------";



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

switch (char.ToLower(userOption))
{
    case 'a':
        AdditionGame("You're playing an addition game");
        break;
    case 's':
        SubtractionGame("You're playing a subtraction game");
        break;
    case 'm':
        MultiplicationGame("You're playing a multiplication game");
        break;
    case 'd':
        DivisionGame("You're playing a division game");
        break;
    case 'v':
        ViewPreviousGames("List of Games");
        break;
    case 'q':
        Console.WriteLine("Goodbye");
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}

void AdditionGame(string message)
{

    var random  = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    Console.WriteLine($"\n{divider}");
    Console.WriteLine($"How many times would you like to play?");
    
    var numberOfRounds = int.Parse( Console.ReadLine() );

    for (int i =0; i < numberOfRounds; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Your answer was correct!");
            score++;
            Console.WriteLine(divider);
        }
        else
        {
            Console.WriteLine("Your answer was incorrect!");
            Console.WriteLine(divider);
        }
    }
    Console.WriteLine($"Game over. Your final score is {score} out of {numberOfRounds}");
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);
}

void DivisionGame(string message)
{
    Console.WriteLine(message);
}

void ViewPreviousGames(string message)
{
    Console.WriteLine(message);
}