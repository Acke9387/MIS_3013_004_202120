string courseName = "MIS-3013";

DeveloperInformation("Instructor Ackerman", courseName, "4/12/2022");
string goAgain;

double answer = 0;
bool shouldAskFirstQuestionoverFirstOperand = true;
do
{
    Console.WriteLine($"Would you like to perform a Add, Subtract, Multiply or Divide calculation? >>");
    string calculation = Console.ReadLine();
    double lhOperand, rhOperand;

    if (shouldAskFirstQuestionoverFirstOperand)
    {
        Console.WriteLine($"What is the first value? >>");
        lhOperand = Convert.ToDouble(Console.ReadLine()); 
    }
    else
    {
        lhOperand = answer;
    }

    Console.WriteLine($"What is the second value? >>");
    rhOperand = Convert.ToDouble(Console.ReadLine());
    
    switch (calculation.ToLower())
    {
        case "add":
            answer = Add(lhOperand, rhOperand);
            Console.WriteLine($"{lhOperand} + {rhOperand} = {answer}");
            break;
        case "subtract":
            answer = Subtract(lhOperand, rhOperand);
            Console.WriteLine($"{lhOperand} - {rhOperand} = {answer}");
            break;
        case "multiply":
            answer = Multiply(lhOperand, rhOperand);
            Console.WriteLine($"{lhOperand} * {rhOperand} = {answer}");
            break;
        case "divide":
            answer = Divide(lhOperand, rhOperand);
            Console.WriteLine($"{lhOperand} / {rhOperand} = {answer}");
            break;
        default:
            break;
    }

    Console.WriteLine("Do you want to perform another calculation? yes or no >>");
    goAgain = Console.ReadLine();

    if (goAgain.ToLower() == "yes")
    {
        Console.WriteLine($"Do you want to use {answer} as your first value? yes or no>>");

        if (Console.ReadLine().ToLower() == "yes")
        {
            shouldAskFirstQuestionoverFirstOperand = false;
        }
        else
        {
            shouldAskFirstQuestionoverFirstOperand = true;
        }

    }
} while (goAgain.ToLower()[0] == 'y');




/// <summary>
/// Add's two values up and returns the sum
/// </summary>
static double Add(double num1, double num2)
{
    double result = 0;

    result = num1 + num2;

    return result;
}

/// <summary>
/// Subtract's the two values and returns the difference
/// </summary>
static double Subtract(double num1, double num2)
{
    return num1 - num2;
}

static double Multiply(double num1, double num2)
{
    return num1 * num2;
}

static double Divide(double num1, double num2)
{
    if (num2 == 0)
    {
        return 0;
    }
    else
    {
        return num1 / num2;
    }
}

static void DeveloperInformation(string name, string course, string date)
{
    Console.WriteLine($"{name} wrote this application for {course} on {date}");
}