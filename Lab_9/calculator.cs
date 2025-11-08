using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    // Changed 'internal' to 'public' so Program.cs can see it
    public class calculator
    {
        // Performs addition
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Performs subtraction
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        // Performs multiplication
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // Performs division
        public double Divide(double a, double b)
        {
            // Good practice: Check for division by zero
            if (b == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                return 0;
            }
            return a / b;
        }
    }
}