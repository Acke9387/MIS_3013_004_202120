
string[] linesOfFile = File.ReadAllLines("Cereal_Data.txt");


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


    // Add cereal to a collection

}







// Output based upon the criteria in problem.