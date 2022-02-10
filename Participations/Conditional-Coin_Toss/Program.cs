const int HEADS = 1;
const int TAILS = 2;
const string DEVELOPER_NAME = "Professor Ackerman";

Random random = new Random();
int randomNumber = random.Next(1, 3);

// For testing purposes so we know what to guess
//Console.WriteLine(randomNumber);

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

Console.WriteLine($"Developed by {DEVELOPER_NAME}.");