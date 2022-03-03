/*
 *Create two parallel arrays.  The first will hold student id’s and the second 
 * will hold their overall GPA.  
 * Ask the user for one of the id’s that they want to see the GPA for and then output it.
 */

int[] studentIds = new int[3];
double[] studentGpas = { 2.5, 4.0, 3.7 };

studentIds[0] = 1;
//studentGpas[0] = 2.5;
studentIds[1] = 2;
studentIds[2] = 3;
//studentIds[3] = 3; //index out of bounds

Console.Write("\nStudent Ids in the system: \t");
for (int i = 0; i < studentIds.Length; i++)
{
    Console.Write(studentIds[i] + "\t");
}
Console.WriteLine();
Console.WriteLine($"Which ID do you want to see the GPA of? >>");
int id = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < studentIds.Length; i++)
{
    if (studentIds[i] == id)
    {
        Console.WriteLine($"Student with id {id} has a gpa of {studentGpas[i].ToString("N2")}");
    }
}

