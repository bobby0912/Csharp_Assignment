//using c__Assignment;

//**Sealed Class in a Security System**

//Create a sealed class `SecuritySystem` that prevents inheritance. Show how sealing a class stops further extension.



using System;

namespace c__Assignment
{
    sealed class SecuritySystem
    {
        public string SystemName { get; set; }

        public SecuritySystem(string systemName)
        {
            SystemName = systemName;
        }

        public void Activate()
        {
            Console.WriteLine($"{SystemName} is now activated.");
        }
    }

    // The following class definition would cause a compile-time error
    // because SecuritySystem is sealed and cannot be inherited.
    // class AdvancedSecuritySystem : SecuritySystem
    // {
    //     public AdvancedSecuritySystem(string systemName) : base(systemName)
    //     {
    //     }
    // }

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        SecuritySystem securitySystem = new SecuritySystem("Home Security");
    //        securitySystem.Activate(); // Output: Home Security is now activated.
    //    }
    //}
}

