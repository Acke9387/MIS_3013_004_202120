

Console.WriteLine("How many bank accounts do you have? >>");
string answer = Console.ReadLine();
int numberOfBankAccounts;
bool isValid = int.TryParse(answer, out numberOfBankAccounts);

while (isValid == false)
{
    Console.WriteLine("Please enter a valid number for how many bank accounts you have >>");
    answer = Console.ReadLine();
    isValid = int.TryParse(answer, out numberOfBankAccounts);
}

double total = 0;
int i;
for ( i = 1; i <= numberOfBankAccounts; i++)
{
    Console.WriteLine($"Please enter the balance for bank account {(i).ToString("N0")} >>");
    answer = Console.ReadLine();

    //total = total + Convert.ToDouble(answer);
    total += Convert.ToDouble(answer); //short hand notation

}

Console.WriteLine($"Your total for all {numberOfBankAccounts.ToString("N0")} is {total.ToString("C2")}");

double avg = total / numberOfBankAccounts;

Console.Write($"The average of all your accounts is ");
if (avg > 5000)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(avg.ToString("C2"));
}
else
{
    Console.WriteLine(avg.ToString("C2"));
}

