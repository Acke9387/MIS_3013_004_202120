const int HEADS = 1;
const int TAILS = 2;
const string DEVELOPER_NAME = "Professor Ackerman";

Random random = new Random();

// For testing purposes so we know what to guess
//Console.WriteLine(randomNumber);
string answer;
do
{
    int randomNumber = random.Next(1, 3);
    Console.WriteLine("Heads or Tails? >>");
    string guess = Console.ReadLine();

    int guessAsNumber = -1;

    if (guess == "Heads")
    {
        guessAsNumber = HEADS;
    }
    else if (guess == "Tails")
    {
        guessAsNumber = TAILS;
    }
    else
    {
        //guessAsNumber = -1;
        Console.WriteLine("Invalid entry.");
        Environment.Exit(guessAsNumber);
    }

    if (randomNumber == HEADS)
    {
        Console.WriteLine("The coin came up Heads!");
    }
    else
    {
        Console.WriteLine("The coin came up Tails!");
    }

    if (randomNumber == guessAsNumber)
    {
        Console.WriteLine("Congratulations, you guessed correctly!");
    }
    else
    {
        Console.WriteLine("Sorry, you came up short. =(");
    }


    Console.WriteLine("Do you want to play again? yes or no >>");
    answer = Console.ReadLine();

    //} while (Console.ReadLine() == "yes");
} while (answer == "yes");


Console.WriteLine($"Developed by {DEVELOPER_NAME}.");