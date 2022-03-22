
Console.WriteLine("Please enter your grade for Accounting as a double (e.g. .98, .75) <<");
double accountingGrade = Convert.ToDouble(Console.ReadLine());

string accountingLetter = ConvertGradeToLetterGrade(accountingGrade);

Console.WriteLine($"{accountingGrade.ToString("P")} = {accountingLetter}");

Console.WriteLine("Please enter your grade for Marketing as a double (e.g. .98, .75) <<");
double marketingGrade = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"{marketingGrade.ToString("P")} = {ConvertGradeToLetterGrade(marketingGrade)}");


static string ConvertGradeToLetterGrade(double grade)
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
