
public class Toy
{
    public string Manufacturer { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    
    private string Notes;

    public Toy()
    {
        Manufacturer = string.Empty;
        Name = string.Empty;
        Price = 0;
        Notes = string.Empty;
    }

    public Toy(string note)
    {
        Manufacturer = string.Empty;
        Name = string.Empty;
        Price = 0;
        Notes = note;
    }

    public string GetAisle()
    {
        int aisleNbr;
        string aisle = string.Empty;

        Random r = new Random();
        aisleNbr = r.Next(1, 25);
        aisle = Manufacturer.ToUpper()[0].ToString();

        return aisle + aisleNbr;
    }

    public void SetNote (string note)
    {
        Notes = note;
    }

    public override string ToString()
    {
        return $"{Name} is made by {Manufacturer} and sells for {Price.ToString("C")} and can be found on {GetAisle()}.\n\t{Notes}";
    }

}

