using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        // Creating instances
        Car car = new Car();
        Bus bus = new Bus();
        Train train = new Train();

        Human human = new Human();

        Route route = new Route
        {
            StartPoint = "City A",
            EndPoint = "City B"
        };

        TransportNetwork transportNetwork = new TransportNetwork();

        // Adding vehicles to the transport network
        transportNetwork.AddVehicle(car);
        transportNetwork.AddVehicle(bus);
        transportNetwork.AddVehicle(train);

        // Moving all vehicles
        transportNetwork.MoveAllVehicles();

        // Calculating optimal routes
        transportNetwork.CalculateOptimalRoute(route, car);
        transportNetwork.CalculateOptimalRoute(route, bus);
        transportNetwork.CalculateOptimalRoute(route, train);

        // Boarding and disembarking passengers
        transportNetwork.PassengerBoarding(bus);
        transportNetwork.PassengerDisembarking(train);

        Console.ReadLine(); // Pause to see the output
    }
}

