using System;

// 1. Define the base class 'Vehicle'
public class Vehicle
{
    // Protected fields are accessible in this class and any derived classes
    protected int speed = 60;
    protected int fuel = 100;

    // A 'virtual' method can be overridden by derived classes
    public virtual void Drive()
    {
        fuel -= 5;
        Console.WriteLine("Vehicle is moving...");
    }

    // Another 'virtual' method
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Speed: {speed} km/h, Fuel: {fuel}%");
    }
}

// 2. Define the derived class 'Car'
public class Car : Vehicle
{
    // A new field specific to Car
    private int passengers = 4;

    // 'override' provides a new implementation for the base class method
    public override void Drive()
    {
        fuel -= 10;
        Console.WriteLine($"Car is moving with {passengers} passengers.");
    }

    // Overriding ShowInfo to include passenger count
    public override void ShowInfo()
    {
        Console.WriteLine($"Speed: {speed} km/h, Fuel: {fuel}%, Passengers: {passengers}");
    }
}

// 3. Define the derived class 'Truck'
public class Truck : Vehicle
{
    // A new field specific to Truck
    private int cargoWeight = 500; // in kg

    // Overriding Drive for the Truck
    public override void Drive()
    {
        fuel -= 15;
        Console.WriteLine($"Truck is moving with {cargoWeight}kg of cargo.");
    }

    // Overriding ShowInfo to include cargo weight
    public override void ShowInfo()
    {
        Console.WriteLine($"Speed: {speed} km/h, Fuel: {fuel}%, Cargo Weight: {cargoWeight}kg");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create an array of Vehicle references
        Vehicle[] vehicles = new Vehicle[3];

        // Create one object of each class and store them in the array
        vehicles[0] = new Vehicle();
        vehicles[1] = new Car();
        vehicles[2] = new Truck();

        // Loop through the array and call methods on each object
        foreach (Vehicle v in vehicles)
        {
            v.Drive();
            v.ShowInfo();
            Console.WriteLine(); // Add a blank line for readability
        }
    }
}