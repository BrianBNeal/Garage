namespace Garage;

public abstract class Car : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Vroooommmmmmmm!!!!");
    }

    public void Brake()
    {
        Console.WriteLine("Screeeeeeeeech!!!!");
    }

}
