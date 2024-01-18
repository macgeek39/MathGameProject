﻿var divider = "----------------------------------";



Console.WriteLine($"What's your name?");
string name = Console.ReadLine();
DateTime date = DateTime.Now;
int gamesPlayed = 0;
char userOption;
decimal averageScore;
bool isScoreEmpty = true;
List<string> gamesHistory = new();

Console.WriteLine(@$"{divider}
Hello {name}! 
Today is {date}. 
This is your math's game. 
That's great that you're working on improving yourself!");
Console.WriteLine(divider);
Console.WriteLine("Press any key to continue.");
Console.ReadLine();

var isGameOn = true;

do
{
    Console.Clear();
    Console.WriteLine($"Games played: {gamesPlayed}");
    Console.WriteLine(@"What game would you like to play?
A - Addition
S - Subtraction
M - Multiplication
D - Division
V - View Previous Games
Q - Quit The Program");

    userOption = Console.ReadKey().KeyChar;

    switch (char.ToLower(userOption))
    {
        case 'a':
            AdditionGame();
            break;
        case 's':
            SubtractionGame();
            break;
        case 'm':
            MultiplicationGame();
            break;
        case 'd':
            DivisionGame();
            break;
        case 'v':
            ViewPreviousGames("List of Games");
            break;
        case 'q':
            Console.WriteLine("Goodbye");
            isGameOn = false;
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }
    gamesPlayed++;
} while (isGameOn);
void AdditionGame()
{

    Console.Clear();
    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    Console.WriteLine($"How many times would you like to play?");
    var numberOfRounds = int.Parse(Console.ReadLine());

    for (int i = 0; i < numberOfRounds; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine($"Your answer was correct.");
            score++;
        }
        else
        {
            Console.WriteLine($"Your answer was incorrect.");
        }
    }

    Console.WriteLine($"Game over. Your final score is {score} out of {numberOfRounds}. Press any key to go back to main menu.");
    Console.ReadKey();

    gamesHistory.Add($"{DateTime.Now} - Addition - Score: {score} out of {numberOfRounds}");
}

void SubtractionGame()
{
    Console.WriteLine();
}

void MultiplicationGame()
{
    Console.WriteLine();
}

void DivisionGame()
{
    Console.WriteLine($"\nHow many times would you like to play?");
    var numberOfRounds = int.Parse(Console.ReadLine() );

    for (int i =0;i < numberOfRounds; i++)
    {
        var divisionNumbers = GetDivisionNumbers();
        int[] GetDivisionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(1, 99);
            var secondNumber = random.Next(1, 99);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }
    }
    
}

void ViewPreviousGames(string message)
{
    Console.Clear();
    if (gamesHistory.Count == 0)
    {
        Console.WriteLine("No game have been played yet. Press any key to go back to main menu.");
        Console.ReadKey();
        return;
    }

    Console.WriteLine("Games List");
    Console.WriteLine("------------------------------------");
    foreach (var game in gamesHistory)
    {
        Console.WriteLine(game);
    }
    Console.WriteLine("------------------------------------");

    Console.WriteLine($"\nPress any key to go back to main menu.");
    Console.ReadKey();
}


