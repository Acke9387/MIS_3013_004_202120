
class Student
{
    public string Name { get; set; }

    public int Id { get; set; }
    public List<double> Grades { get; set; }


    public Student()
    {
        Name = "";
        Id = 0;
        Grades = new List<double>();
    }

    public void StudentInformation()
    {
        double average = 0;
        double sum = 0;
        foreach (double grade in Grades)
        {
            sum += grade;
        }
        //sum = grades.Sum();
        //average = sum / grades.Count();
        //average = grades.Average();
        average = sum / Grades.Count;

        Console.WriteLine($"{Name} ({Id}) has {Grades.Count.ToString("N")} # of grades and has an average of {average.ToString("P")}!");
    }

    public override string ToString()
    {
            double average = 0;
            double sum = 0;
            foreach (double grade in Grades)
            {
                sum += grade;
            }
            //sum = grades.Sum();
            //average = sum / grades.Count();
            //average = grades.Average();
            average = sum / Grades.Count;

            return $"{Name} ({Id}) has {Grades.Count.ToString("N")} # of grades and has an average of {average.ToString("P")}!";
        }
    }


