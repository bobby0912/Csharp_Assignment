//**Multiple Inheritance Using Interfaces**

//Define two interfaces `IPrintable` (for printing details) and `ISerializable` (for saving to a file). Implement both in a `Report` class and demonstrate multiple interface implementation.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Assignment
{
    interface IPrintable
    {
        void Print();
    }

    interface ISerializable
    {
        void SaveToFile(string filePath);
    }

    class Report : IPrintable, ISerializable
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public void Print()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Content: {Content}");
        }

        public void SaveToFile(string filePath)
        {
            // For demonstration purposes, we'll just simulate saving to a file
            Console.WriteLine($"Saving report to {filePath}...");
        }
    }

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Report report = new Report
    //        {
    //            Title = "Annual Report",
    //            Content = "This is the content of the annual report."
    //        };

    //        report.Print(); // Output: Title: Annual Report, Content: This is the content of the annual report.
    //        report.SaveToFile("report.txt"); // Output: Saving report to report.txt...
    //    }
    //}
}
