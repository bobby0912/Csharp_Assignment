//using c__Assignment;

//**Method Overriding for a Vehicle System**

//Create a base class `Vehicle` with a method `Start()`. Override it in `Car` and `Bike` classes to provide specific implementations. Use the `override` keyword and demonstrate polymorphism.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Assignment
{
    class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle is starting.");
        }
    }

    class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car is starting with a roar.");
        }
    }

    class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike is starting with a vroom.");
        }
    }

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Vehicle myCar = new Car();
    //        myCar.Start(); // Output: Car is starting with a roar.

    //        Vehicle myBike = new Bike();
    //        myBike.Start(); // Output: Bike is starting with a vroom.
    //    }
    //}
}
