
string[] linesOfFile = File.ReadAllLines("Cereal_Data.txt");

List<Cereal> allCereals = new List<Cereal>();

//Cereal cereal = new Cereal();
//cereal.Name = "Raisin Bran";
//cereal.Manufacturer = "Kelloggs";
//cereal.Cups = 5;
//cereal.Calories = 102;


// Go through each line of the file (except for the first one)
for (int i = 1; i < linesOfFile.Length; i++)
{
    //linesOfFile[i] : "100% Bran|Nabisco|70|0.33"
    // Split each line by a | to get an string[] with a Length of 4 (0 has name, 1 has manufacturer etc.)
    string[] partsOfLine = linesOfFile[i].Split("|");

    //partsOfLine[0] : "100% Bran"
    //partsOfLine[1] : "Nabisco"
    //partsOfLine[2] : "70"
    //partsOfLine[3] : "0.33"

    // Processes pieces and create a Cereal
    Cereal temp = new Cereal();
    temp.Name = partsOfLine[0];
    temp.Manufacturer = partsOfLine[1];
    temp.Calories = Convert.ToDouble(partsOfLine[2]);
    temp.Cups =     Convert.ToDouble(partsOfLine[3]);



    // Add cereal to a collection
    allCereals.Add(temp);
}

// Output based upon the criteria in problem.

//The application should output all of the Cereal information that have a serving size that is 1 cup or more.
Console.WriteLine("All cereals with a serving size of 1 cup or more");

foreach (Cereal c in allCereals)
{
    if (c.Cups >= 1)
    {
        Console.WriteLine($"\t" + c); 
    }
}

//After you output all those cereals, we also need to inform them which Cereals have 100 calories or less per serving.

Console.WriteLine("All cereals with a 100 calories or less per serving");

foreach (Cereal c in allCereals)
{
    if (c.Calories <= 100)
    {
        Console.WriteLine($"\t" + c);
    }
}
