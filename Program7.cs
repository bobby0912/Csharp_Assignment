//**Method Overloading in a Calculator Class**

//Implement a `Calculator` class with overloaded methods `Add()`. It should accept
//two integers, three integers, and two double values separately. Demonstrate how
//method overloading works.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Assignment
{
    class Calculator
    {
        // Method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method to add three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Method to add two double values
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Calculator calculator = new Calculator();

    //        int sum1 = calculator.Add(2, 3);
    //        Console.WriteLine($"Sum of 2 and 3: {sum1}"); // Output: Sum of 2 and 3: 5

    //        int sum2 = calculator.Add(1, 2, 3);
    //        Console.WriteLine($"Sum of 1, 2 and 3: {sum2}"); // Output: Sum of 1, 2 and 3: 6

    //        double sum3 = calculator.Add(2.5, 3.5);
    //        Console.WriteLine($"Sum of 2.5 and 3.5: {sum3}"); // Output: Sum of 2.5 and 3.5: 6.0
    //    }
    //}
}
