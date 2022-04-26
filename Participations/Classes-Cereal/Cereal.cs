﻿
public class Cereal
{
    public string Manufacturer{get;set;}
   
    public string Name{get;set;}
    
    public double Calories{get;set;}

    public double Cups { get; set; }


    public Cereal()
    {
        Manufacturer = String.Empty;
        Name = String.Empty;
        Calories = 0;
        Cups = 0;
    }

    public override string ToString()
    {
        return $"{Name} is made by {Manufacturer} and has {Calories.ToString("N")} per {Cups.ToString("N")} cups.";
    }

}
