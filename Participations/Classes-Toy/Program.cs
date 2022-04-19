Toy t1 = new Toy();
t1.Manufacturer = "Hasbro";
t1.Name = "Monopoly";
t1.Price = 19.99;
t1.SetNote("Great way to ruin friendships");

Toy t2 = new Toy();
t2.Manufacturer = "Hasbro";
t2.Name = "Life";
t2.Price = 29.99;
t2.SetNote("Great for all ages");

Toy t3 = new Toy();
t3.Manufacturer = "Hasbro";
t3.Name = "Risk";
t3.Price = 9.99;
t3.SetNote("Bleh");

List<Toy> toys = new List<Toy>();
toys.Add(t1);
//toys.Add("Buzz");   //Can't add because "Buzz" is a string, not a Toy


//Console.WriteLine(t1);
//Console.WriteLine(t2);
//Console.WriteLine(t3);

foreach (Toy toy in toys)
{
    Console.WriteLine(toy);
}