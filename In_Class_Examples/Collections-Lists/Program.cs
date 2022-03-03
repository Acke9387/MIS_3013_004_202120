/*
 * Using a List, ask the user to enter all of their favorite things.  
 * Once they are done, randomly pick a value from the list and display it. * 
 * 
 */

List<string> favoriteThings = new List<string>();

do
{
    Console.WriteLine("Please enter one of your favorite things >>");
    favoriteThings.Add(Console.ReadLine());

    Console.WriteLine("Do you have another favorite thing to enter? yes or no >>");

} while (Console.ReadLine().ToLower()[0] == 'y');

Random rand = new Random();
int randomIndex = rand.Next(0, favoriteThings.Count);
Console.WriteLine("Random Favorite thing:");
Console.WriteLine(favoriteThings[randomIndex]);

//Output all favorite things.
Console.WriteLine("All Favorite things:");
foreach (string favoriteThing in favoriteThings)
{
    Console.WriteLine(favoriteThing);
}

//Equivalent for loop
//for (int i = 0; i < favoriteThings.Count; i++)
//{
//    string favoriteThing = favoriteThings[i];
//}