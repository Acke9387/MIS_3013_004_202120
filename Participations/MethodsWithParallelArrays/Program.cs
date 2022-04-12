string[] names = { "John", "Sally", "Jane", "Will", "Herman" };
int[] ids = { 1, 2, 3, 4, 5 };
List<List<double>> grades = new List<List<double>>();
//grades.Add(new List<double>());
//grades[0].Add(.54);
//grades[0].Add(.578);
//grades[0].Add(.56);
grades.Add(CreateRandomSizedListWithRandomValues());
grades.Add(CreateRandomSizedListWithRandomValues());
grades.Add(CreateRandomSizedListWithRandomValues());
grades.Add(CreateRandomSizedListWithRandomValues());
grades.Add(CreateRandomSizedListWithRandomValues());


//StudentInformation(names[0], ids[0], grades[0]);
//StudentInformation(names[1], ids[1], grades[1]);

for (int i = 0; i < names.Length; i++)
{
    StudentInformation(names[i], ids[i], grades[i]);
}

static void StudentInformation(string name, int id, List<double> grades)
{
    double average = 0;
    double sum = 0;
    foreach (double grade in grades)
    {
        sum += grade;
    }
    //sum = grades.Sum();
    //average = sum / grades.Count();
    //average = grades.Average();
    average = sum/ grades.Count;

    Console.WriteLine($"{name} ({id}) has {grades.Count.ToString("N")} # of grades and has an average of {average.ToString("P")}!");
}

static List<double> CreateRandomSizedListWithRandomValues()
{
    List<double> randoGrades = new List<double>();
    Random rand = new Random();
    int numberOfGrades = rand.Next(3, 8);

    for (int i = 0; i < numberOfGrades; i++)
    {
        double grade = rand.NextDouble() ;
        randoGrades.Add(grade);
    }

    return randoGrades;
}