namespace Garage;

public class Glider : Vehicle, IFlying
{
    public string Material { get; set; }
    public int MaxAltitude { get; set; }

    public void Fly()
    {
        Console.WriteLine("You run off the edge of the cliff and start flying.");
    }

    public void Land()
    {
        Console.WriteLine("You gracefully glide to earth and definitely don't break anything.");
    }
    public string GetInputThatINeed()
    {
        throw new NotImplementedException();
    }
}
