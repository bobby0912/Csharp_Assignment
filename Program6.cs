//**Using Virtual Methods in Inheritance**

//Create a `Person` base class with a `GetDetails()` method. Derive `Student` and `Teacher`
//classes that override `GetDetails()` to display their respective properties. Call
//`GetDetails()` using a base class reference.




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Assignment
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual string GetDetails()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }

    class Student6 : Person
    {
        public int RollNo { get; set; }

        public override string GetDetails()
        {
            return $"Name: {Name}, Age: {Age}, RollNo: {RollNo}";
        }
    }

    class Teacher : Person
    {
        public string Subject { get; set; }

        public override string GetDetails()
        {
            return $"Name: {Name}, Age: {Age}, Subject: {Subject}";
        }
    }

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Person student = new Student6 { Name = "John", Age = 20, RollNo = 101 };
    //        Console.WriteLine(student.GetDetails()); // Output: Name: John, Age: 20, RollNo: 101

    //        Person teacher = new Teacher { Name = "Jane", Age = 35, Subject = "Mathematics" };
    //        Console.WriteLine(teacher.GetDetails()); // Output: Name: Jane, Age: 35, Subject: Mathematics
    //    }
    //}
}
