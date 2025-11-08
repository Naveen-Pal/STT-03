using System;

class Vehicle
{
    protected int speed;
    protected int fuel;

    public Vehicle(int speed, int fuel)
    {
        this.speed = speed;
        this.fuel = fuel;
    }


    public virtual void ShowInfo()
    {
        Console.WriteLine($"Speed: {speed} km/h, Fuel: {fuel} L");
    }


    public virtual void Drive()
    {
        Console.WriteLine("Vehicle is moving...");
        fuel -= 5;
    }
}


class Car : Vehicle
{
    private int passengers;

    public Car(int speed, int fuel, int passengers) : base(speed, fuel)
    {
        this.passengers = passengers;
    }

    public override void Drive()
    {
        fuel -= 10;
        Console.WriteLine("Car is moving with passengers...");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Speed: {speed} km/h, Fuel: {fuel} L, Passengers: {passengers}");
    }
}

class Truck : Vehicle
{
    private int cargoWeight;

    public Truck(int speed, int fuel, int cargoWeight) : base(speed, fuel)
    {
        this.cargoWeight = cargoWeight;
    }

    public override void Drive()
    {
        fuel -= 15;
        Console.WriteLine("Truck is moving with cargo...");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Speed: {speed} km/h, Fuel: {fuel} L, Cargo Weight: {cargoWeight} kg");
    }
}

class MainProgram
{
    static void Main()
    {

        Vehicle v1 = new Vehicle(80, 100);
        Vehicle v2 = new Car(120, 80, 4);
        Vehicle v3 = new Truck(70, 150, 5000);


        Vehicle[] vehicles = { v1, v2, v3 };


        foreach (Vehicle v in vehicles)
        {
            v.Drive();
            v.ShowInfo();
            Console.WriteLine();
        }
    }
}