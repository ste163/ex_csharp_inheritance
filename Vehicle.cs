using System;

public class Vehicle
{
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public virtual void Drive()
    {
        Console.Write("Vrooom!");
    }
}