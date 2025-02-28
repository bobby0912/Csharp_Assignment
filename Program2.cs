//using System.Xml.Linq;

//**Data Hiding with Properties**

//Create a `Student` class where `Name` and `RollNo` are private fields.Use properties
//to enforce validation (e.g., `RollNo` cannot be negative, `Name` cannot be empty).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Assignment
{
    class Student2
    {
        private string name;
        private int rollNo;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                name = value;
            }
        }

        public int RollNo
        {
            get { return rollNo; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("RollNo cannot be negative.");
                }
                rollNo = value;
            }
        }
    }

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Student2 student = new Student2();
    //        student.Name = "John";
    //        student.RollNo = 1;
    //        Console.WriteLine($"Name: {student.Name}, RollNo: {student.RollNo}");
    //    }
    //}
}
