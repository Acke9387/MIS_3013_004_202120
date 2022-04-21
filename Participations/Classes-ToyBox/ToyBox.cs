public class ToyBox
{
    public List<Toy> Toys { get; set; } /// I know this is correct but I can only get list of string work

    public string Owner { get; set; }

    public string Location { get; set; }


    public ToyBox()
    {
        Owner = string.Empty;
        Location = string.Empty;
        Toys = new List<Toy>();
    }

    public Toy GetRandomToy()
    {
        Random random = new Random();
        int randomToyIndex = random.Next(0, Toys.Count);
        
        return Toys[randomToyIndex];
    }

}
