
internal class Rectangle
{

    public double Length { get; set; }

    public double Width { get; set; }

    /// <summary>
    /// Default/Empty Constructor
    /// </summary>
    public Rectangle()
    {
        Length = 0;
        Width =  0;
    }

    /// <summary>
    /// Overloaded Constructor
    /// </summary>
    /// <param name="length"></param>
    /// <param name="width"></param>
    public Rectangle(double length, double width)
    {
        Length= length;
        Width= width;
    }

    public double CalculateArea()
    {
        return Width * Length;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Length + Width);
    }

    public double CalculateAreaForXRectangles(int x)
    {
        double areaForAllrects = (CalculateArea() * x);

        return areaForAllrects;
    }

    public override string ToString()
    {
        return $"A rectangle with length: {Length} AND width {Width} has an area of {CalculateArea()} ";
    }

}

