namespace Garage;

public interface IGasPowered
{
    double FuelCapacity { get; set; }
    void Refuel();
    string GetInputThatINeed()
    {
        return "IGasPowered";
    }
}
