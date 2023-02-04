using Garage;


NissanLeaf car = new NissanLeaf();

// Build a collection of all vehicles that fly
List<IGasPowered> fliers = new List<IGasPowered>
{
    new JumboJet() { CrewCapacity = 10, MinRunwayLength = 1000, NumberOfEngines = 4,FuelCapacity= 1500.67,Color = "white", PassengerCapacity = 150 },
    
};

// With a single `foreach`, have each vehicle Fly()
foreach (IGasPowered flier in fliers)
{
    Console.WriteLine(flier.GetInputThatINeed());
}


// Build a collection of all vehicles that operate on roads
// With a single `foreach`, have each road vehicle Drive()

// Build a collection of all vehicles that operate on water
// With a single `foreach`, have each water vehicle Drive()


