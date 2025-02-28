//**Factory Pattern for Object Creation**

//Implement a `VehicleFactory` class that returns different vehicle objects (`Car`, `Bike`) based on an input parameter.



using System;

namespace c__Assignment
{
    abstract class Vehicle
    {
        public abstract void Drive();
    }

    class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Driving a car.");
        }
    }

    class Bike : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Riding a bike.");
        }
    }

    class VehicleFactory
    {
        public static Vehicle GetVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "car":
                    return new Car();
                case "bike":
                    return new Bike();
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = VehicleFactory.GetVehicle("car");
            car.Drive(); // Output: Driving a car.

            Vehicle bike = VehicleFactory.GetVehicle("bike");
            bike.Drive(); // Output: Riding a bike.
        }
    }
}


