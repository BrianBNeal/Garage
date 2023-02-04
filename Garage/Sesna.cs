namespace Garage;

public class Sesna : Vehicle, IGasPowered, IFlying
{
    public int NumberOfPropBlades { get; set; }
    public int WeightLimit { get; set; }
    public int MaxAltitude { get; set; }
    public double FuelCapacity { get; set; }

    public void Fly()
    {
        Console.WriteLine("The propellers start buzzing and you take off!");
    }

    public void Land()
    {
        Console.WriteLine("You land gently in a field (on purpose)");
    }

    public void Refuel()
    {
        Console.WriteLine("");
    }
    public string GetInputThatINeed()
    {
        throw new NotImplementedException();
    }
}
