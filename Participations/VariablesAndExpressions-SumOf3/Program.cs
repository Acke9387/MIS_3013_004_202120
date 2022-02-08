Console.WriteLine("Please enter your first value >>");
string response1 = Console.ReadLine();

double val1;
bool isValidNumber = double.TryParse(response1, out val1);

if (isValidNumber == true)
{
    //val1 = Convert.ToDouble(response1);
}
else
{
    Console.WriteLine($"{response1} is an invalid number.  Goodbye.");
    //return;
    Environment.Exit(-5);
}


Console.WriteLine("Please enter your second value >>");
string response2 = Console.ReadLine();
double val2;// = Convert.ToDouble(response2);

if (double.TryParse(response2, out val2) == false)
{
    Console.WriteLine($"{response2} is an invalid number.  Goodbye.");
    //return;
    Environment.Exit(-6);
}

Console.WriteLine("Please enter your third value >>");
string response3 = Console.ReadLine();
double val3;// = Convert.ToDouble(response3);
if (double.TryParse(response3, out val3) == false)
{
    Console.WriteLine($"{response3} is an invalid number.  Goodbye.");
    //return;
    Environment.Exit(-7);
}

//  How to use random numbers
//Random rand = new Random();
//int val4 = rand.Next(1, 11);

double sum = val1 + val2 + val3;
Console.WriteLine($"{val1.ToString("N3")} + {val2.ToString("N3")} + {val3.ToString("N3")} = {sum.ToString("N3")} ");



const double MAGIC_NUMBER = 7.777;
double newSum = sum * MAGIC_NUMBER;

Console.WriteLine($"{sum.ToString("N3")} * {MAGIC_NUMBER.ToString("N3")} = {newSum.ToString("N3")}");