string[] names = { "John", "Sally", "Jane", "Will", "Herman" };
int[] ids = { 1, 2, 3, 4, 5 };

List<Student> students = new List<Student>();
//Student student1 = new Student();
//student1.Name = "John";
//student1.Id = 1;
//student1.Grades = CreateRandomSizedListWithRandomValues();
for (int i = 0; i < names.Length; i++)
{
    Student newStudent = new Student();
    newStudent.Name = names[i];
    newStudent.Id = ids[i];
    newStudent.Grades = CreateRandomSizedListWithRandomValues();

    students.Add(newStudent);
}
//Student student2 = new Student();
//student2.Name = "Sally";
//student2.Id = 2;
//student2.Grades = CreateRandomSizedListWithRandomValues();


//StudentInformation(names[0], ids[0], grades[0]);
//StudentInformation(names[1], ids[1], grades[1]);

foreach (Student student in students)
{
    //student.StudentInformation();

    Console.WriteLine(student);
}



static List<double> CreateRandomSizedListWithRandomValues()
{
    List<double> randoGrades = new List<double>();
    Random rand = new Random();
    int numberOfGrades = rand.Next(3, 8);

    for (int i = 0; i < numberOfGrades; i++)
    {
        double grade = rand.NextDouble();
        randoGrades.Add(grade);
    }

    return randoGrades;
}