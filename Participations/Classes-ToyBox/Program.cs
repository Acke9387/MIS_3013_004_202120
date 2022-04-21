string manufacturer, name, note;
double price;


List<ToyBox> toyBoxes = new List<ToyBox>();

do
{
    ToyBox myToyBox = new ToyBox();
    Console.WriteLine("Who is the owner of this ToyBox? >>");
    myToyBox.Owner = Console.ReadLine();

    Console.WriteLine($"What is the location for {myToyBox.Owner}'s ToyBox? >>");
    myToyBox.Location = Console.ReadLine();

    List<Toy> toys = GetAllToysForToyBoxFromUser();

    myToyBox.Toys = toys;
    Console.WriteLine("Do you have another ToyBox to tell me about? yes or no >>");

    toyBoxes.Add(myToyBox);
} while (Console.ReadLine().ToLower() == "yes");


foreach (ToyBox box in toyBoxes)
{
    Console.WriteLine($"{box.Owner}'s Toys from ToyBox located at {box.Location}");

    foreach (Toy toy in box.Toys)
    {
        Console.WriteLine($"\t {box}");
    }

}

foreach (ToyBox box in toyBoxes)
{
    Console.WriteLine($"A random Toy from {box.Owner}'s  ToyBox located @ {box.Location} is");

    Console.WriteLine(box.GetRandomToy());

}


static List<Toy> GetAllToysForToyBoxFromUser()
{
    List<Toy> toyBoxes = new List<Toy>();
    do
    {
        Console.WriteLine("Please enter the Name of the Toy >> ");
        string name = Console.ReadLine();

        Console.WriteLine($"Please enter the Manufacturer of {name} >> ");
        string manufacturer = Console.ReadLine();

        Console.WriteLine($"Please enter the notes of {name} >> ");
        string note = Console.ReadLine();

        Console.WriteLine($"Please enter the Price of {name} >> ");
        double price = Convert.ToDouble(Console.ReadLine());

        Toy myToy = new Toy();
        myToy.Name = name;
        myToy.Manufacturer = manufacturer;
        myToy.Price = price;
        myToy.SetNote(note);


        toyBoxes.Add(myToy);

        Console.WriteLine("Do you want to add another Toy to your ToyBox? yes or no >>");
    } while (Console.ReadLine().ToLower() == "yes");
    return toyBoxes;
}
