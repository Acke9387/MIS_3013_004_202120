
Console.WriteLine("Please enter your grade for Accounting as a double (e.g. .98, .75) >>");
string input = Console.ReadLine();
double accountingGrade = VerifyGrade(input, "Accounting");

string accountingLetter = ConvertGradeToLetterGrade(accountingGrade);

Console.WriteLine($"{accountingGrade.ToString("P")} = {accountingLetter}");

Console.WriteLine("Please enter your grade for Marketing as a double (e.g. .98, .75) >>");
double marketingGrade = VerifyGrade(Console.ReadLine(), "Marketing");
Console.WriteLine($"{marketingGrade.ToString("P")} = {ConvertGradeToLetterGrade(marketingGrade)}");

static double VerifyGrade(string answer, string subject)
{
    double grade;

    do
    {
        while ((Double.TryParse(answer, out grade) == false))
        {
            Console.WriteLine($"{answer} was not a valid grade.  Please enter a valid grade for {subject} >>");
            answer = Console.ReadLine();
        }
    } while ((grade < 0 || grade > 1));

    return grade;
}

static string ConvertGradeToLetterGrade(double grade) // Method/Function Signature
{
    string letterGrade = "";

    if (grade >= .90)
    {
        letterGrade = "A";
    }
    else if (grade >= .80)
    {
        letterGrade = "B";
    }
    else if (grade >= .70)
    {
        letterGrade = "C";
    }
    else if (grade >= .60)
    {
        letterGrade = "D";
    }
    else
    {
        letterGrade = "F";
    }

    return letterGrade;
}
