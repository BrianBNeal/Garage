namespace Garage;

public interface IFlying
{
    int MaxAltitude { get; set; }
    void Fly();
    void Land();
    string GetInputThatINeed()
    {
        return "IFlying";
    }
    
}
