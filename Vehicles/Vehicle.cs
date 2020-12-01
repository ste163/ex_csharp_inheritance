using System;

public class Vehicle
{
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public virtual void Drive()
    {
        Console.Write("Vrooom!");
    }

    public virtual void Turn(string direction)
    {
        Console.WriteLine($"Next the vehicle makes a {direction} turn.");
    }
    
    public virtual void Stop()
    {
        Console.WriteLine("Finally, the vehicle stops.");
    }
}