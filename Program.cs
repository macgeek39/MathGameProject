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
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}

void AdditionGame()
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
    Console.WriteLine($"How many times would you like to play?");
    var numberOfRounds = int.Parse(Console.ReadLine() );

    for (int i =0;i < numberOfRounds; i++)
    {
        var divisionNumbers = GetDivisionNumbers();
    }

}

void ViewPreviousGames(string message)
{
    Console.WriteLine(message);
}


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