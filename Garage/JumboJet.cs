namespace Garage;

public class JumboJet : Vehicle, IGasPowered, IFlying
{
    public int CrewCapacity { get; set; } //auto property
    public int MinRunwayLength { get; set; }
    public int NumberOfEngines { get; set; }
    public int MaxAltitude { get; set; }
    public double FuelCapacity { get; set; }

    public void ServeMeal()
    {
        Console.WriteLine();
    }

    public void Fly()
    {
        Console.WriteLine("After the engines warm up for a while you taxi forever and then finally take off with a roar.");
    }

    public void Land()
    {
        Console.WriteLine("You descend gradually from 40,000 feet before touching down.");
    }

    public void Refuel()
    {
        Console.WriteLine("refueling");
    }
}
