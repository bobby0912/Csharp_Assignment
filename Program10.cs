//using c__Assignment;

//**Design a Role-Based Access System**

//Create a base class `User` with properties like `Username` and `Role`. Derive `Admin` and `Customer`
//classes that override a method `AccessControl()`, where `Admin` can access all features,
//but `Customer` has limited access.




using System;

namespace c__Assignment
{
    class User
    {
        public string Username { get; set; }
        public string Role { get; set; }

        public User(string username, string role)
        {
            Username = username;
            Role = role;
        }

        public virtual void AccessControl()
        {
            Console.WriteLine("User access control.");
        }
    }

    class Admin : User
    {
        public Admin(string username) : base(username, "Admin") { }

        public override void AccessControl()
        {
            Console.WriteLine("Admin has access to all features.");
        }
    }

    class Customer : User
    {
        public Customer(string username) : base(username, "Customer") { }

        public override void AccessControl()
        {
            Console.WriteLine("Customer has limited access.");
        }
    }

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        User admin = new Admin { Username = "adminUser" };
    //        admin.AccessControl();

    //        User customer = new Customer { Username = "customerUser" };
    //        customer.AccessControl();
    //    }
    //}
}

