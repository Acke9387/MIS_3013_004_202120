/*Create a dictionary that the key will be the student id and the value will be their GPA.
 * Ask the user if there is another student they want to add, make sure it doesn’t exist then add it
 * Ask them for a student id and output their GPA
 * 
 */

Dictionary<int, double> students = new Dictionary<int, double>();
students.Add(1, 2.5);
students.Add(2, 4.0);
students.Add(3, 3.7);

Console.WriteLine("Do you want to add another student? yes or no >>");
if (Console.ReadLine() == "yes")
{
    Console.WriteLine("What is their id? >>");
    int tempId = Convert.ToInt32(Console.ReadLine());
    if (students.ContainsKey(tempId) == false)
    {
        Console.WriteLine("What is their GPA? >>");
        double tempGpa = Convert.ToDouble(Console.ReadLine());
        students.Add(tempId, tempGpa);
    }
    else
    {
        Console.WriteLine($"{tempId} already exists. Not making any changes");
    }
}

Console.WriteLine("Student ids: \t");
foreach (int studentId in students.Keys)
{
    Console.Write(studentId + "\t");
}

Console.WriteLine();
Console.WriteLine($"Which ID do you want to see the GPA of? >>");
int id = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{id} has a gpa of {students[id]}");