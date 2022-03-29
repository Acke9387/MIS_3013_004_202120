Console.WriteLine("Please enter an animal >>");
string answer = Console.ReadLine();
string animalSound = "";

animalSound = Speak(answer);

Console.WriteLine($"{answer} makes the sound {animalSound}");

static string Speak(string animal)
{
    string result = "";

    switch (animal)
    {
        case "Dog":
            result = "Woof woof";
            break;
        case "Monkey":
            result = "oooo oooo ahhh ahhh";
            break;
        case "Goat":
            result = "people screaming";
            break;
        default:
            result = "Grrrr";
            break;
    }

    if (animal == "Dog")
    {
        result = "Woof woof";
    }
    else if (animal == "Monkey")
    {
        result = "oooo oooo ahhh ahhh";
    }
    else if (animal == "Goat")
    {
        result = "people screaming";
    }
    else
    {
        result = "Grrrr";
    }

        return result;
}
