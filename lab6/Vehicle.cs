// Abstract class representing a Vehicle
abstract class Vehicle
{
    public int Speed { get; set; }
    public int Capacity { get; set; }

    public abstract void Move();
}

// Class representing a Human
class Human
{
    public int Speed { get; set; }

    public void Move()
    {
        Console.WriteLine("Walking...");
    }
}

// Derived class Car from Vehicle
class Car : Vehicle
{
    public Car()
    {
        Speed = 60;
        Capacity = 4;
    }

    public override void Move()
    {
        Console.WriteLine("Driving a car...");
    }
}

// Derived class Bus from Vehicle
class Bus : Vehicle
{
    public Bus()
    {
        Speed = 40;
        Capacity = 30;
    }

    public override void Move()
    {
        Console.WriteLine("Taking a bus...");
    }
}

// Derived class Train from Vehicle
class Train : Vehicle
{
    public Train()
    {
        Speed = 80;
        Capacity = 200;
    }

    public override void Move()
    {
        Console.WriteLine("Riding a train...");
    }
}

// Class representing a Route
class Route
{
    public string? StartPoint { get; set; }
    public string? EndPoint { get; set; }
}

// Class representing a TransportNetwork
class TransportNetwork
{
    private List<Vehicle> vehicles = new List<Vehicle>();

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void MoveAllVehicles()
    {
        foreach (var vehicle in vehicles)
        {
            vehicle.Move();
        }
    }

    public void CalculateOptimalRoute(Route route, Vehicle vehicle)
    {
        Console.WriteLine($"Calculating optimal route from {route.StartPoint} to {route.EndPoint} for {vehicle.GetType().Name}...");
    }

    public void PassengerBoarding(Vehicle vehicle)
    {
        Console.WriteLine($"Passengers boarding on {vehicle.GetType().Name}...");
    }

    public void PassengerDisembarking(Vehicle vehicle)
    {
        Console.WriteLine($"Passengers disembarking from {vehicle.GetType().Name}...");
    }
}