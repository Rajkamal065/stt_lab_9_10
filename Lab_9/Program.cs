/*using System;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            calculator myCalculator = new calculator();

            Console.WriteLine("Enter the first number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("--------------------");

            double sum = myCalculator.Add(num1, num2);
            double difference = myCalculator.Subtract(num1, num2);
            double product = myCalculator.Multiply(num1, num2);
            double quotient = myCalculator.Divide(num1, num2);

            Console.WriteLine($"Addition:       {num1} + {num2} = {sum}");
            Console.WriteLine($"Subtraction:    {num1} - {num2} = {difference}");
            Console.WriteLine($"Multiplication: {num1} * {num2} = {product}");
            Console.WriteLine($"Division:       {num1} / {num2} = {quotient}");

            if (sum % 2 == 0)
            {
                Console.WriteLine($"The sum ({sum}) is an EVEN number.");
            }
            else
            {
                Console.WriteLine($"The sum ({sum}) is an ODD number.");
            }

        }
    }
}*/

/*using System;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    For Loop (1-10) ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n   Foreach Loop (1-10)    ");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\n   Do-While Loop (enter 'exit' to stop)    ");
            string userInput;
            do
            {
                Console.Write("Enter text: ");
                userInput = Console.ReadLine();
            }
            while (userInput.ToLower() != "exit");

            Console.WriteLine("\n   Factorial Function   ");
            Console.Write("Enter a number to calculate its factorial: ");
            int factInput = int.Parse(Console.ReadLine());

            long result = CalculateFactorial(factInput);

            Console.WriteLine($"The factorial of {factInput} is {result}");
        }

        public static long CalculateFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            long result = 1;
            for (int i = n; i >= 1; i--)
            {
                result = result * i;
            }
            return result;
        }
    }
}
// Program.cs
using System;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of our arrayoperations class
            // Note the lowercase 'a' matches your class file
            arrayoperations operations = new arrayoperations();

            // --- 1. Bubble Sort ---
            Console.WriteLine("--- Bubble Sort ---");
            int[] unsortedArray = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Original array:");
            // Call the static helper method using the lowercase class name
            arrayoperations.PrintArray(unsortedArray);

            operations.BubbleSort(unsortedArray); // Sorts the array in place

            Console.WriteLine("Sorted array:");
            arrayoperations.PrintArray(unsortedArray);

            Console.WriteLine("\n--- 2D to 1D Conversion ---");
            int[,] matrix = {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };
            Console.WriteLine("Original 2D Matrix:");
            arrayoperations.PrintMatrix(matrix);

            int[] rowMajor = operations.ConvertTo1DRowMajor(matrix);
            Console.WriteLine("Row-Major Order:");
            arrayoperations.PrintArray(rowMajor);

            int[] colMajor = operations.ConvertTo1DColumnMajor(matrix);
            Console.WriteLine("Column-Major Order:");
            arrayoperations.PrintArray(colMajor);

            // --- 3. Matrix Multiplication ---
            Console.WriteLine("\n--- Matrix Multiplication ---");
            int[,] matrixA = {
                { 1, 2, 3 },
                { 4, 5, 6 }
            }; // 2x3 matrix

            int[,] matrixB = {
                { 7, 8 },
                { 9, 10 },
                { 11, 12 }
            }; // 3x2 matrix

            Console.WriteLine("Matrix A (2x3):");
            arrayoperations.PrintMatrix(matrixA);
            Console.WriteLine("Matrix B (3x2):");
            arrayoperations.PrintMatrix(matrixB);

            int[,] matrixC = operations.MatrixMultiply(matrixA, matrixB);

            if (matrixC != null)
            {
                Console.WriteLine("Result Matrix C (2x2):");
                arrayoperations.PrintMatrix(matrixC);
            }
        }
    }
}

Output reasoning level 0

1st qn
using System; //namespace
class Program //default visibility4 is ‘internal’ if not specified
{
    public static void Main(string[] args)
    {
        int a = 0; //default visibility is ‘private’ (in a class)
        Console.WriteLine(a++);
    }
}

2nd qn 
using System;
class Program
{
    public void Main(string[] args)
    {
        int a = 0;
        Console.WriteLine(a++);
    }
}
Output reasoning level 1
1st qn 

class Program
{
    public static void Main(string[] args)
    {
        int a = 0;
        int b = a++;
        Console.WriteLine(a++.ToString(), ++a, -a++);
        Console.WriteLine((a++).ToString() + (-a++).ToString());
        Console.WriteLine(~b);
    }
}

qn -2
using System;
/*you can also write top level code outside of a class. C# takes
care of this by providing internal entry point Main
using System.Reflection.Emit;

Console.WriteLine("int x = 3;");
Console.WriteLine("int y = 2 + ++x;");
int x = 3; //default visibility is ‘internal’ (outside a class)
int y = 2 + ++x;
Console.WriteLine($"x = {x} and y = {y}");
Console.WriteLine("x = 3 << 2;");
Console.WriteLine("y = 10 >> 1;");
x = 3 << 2;
y = 10 >> 1;
Console.WriteLine($"x = {x} and y = {y}");
x = ~x;
y = ~y;
Console.WriteLine($"x = {x} and y = {y}");

Output Reasoning(Level 2)

qn-1
using System;
public class Program
{
    static void Main()
    {
        try
        {
            int i = int.MaxValue;
            Console.WriteLine(-(i + 1) - i);
            for (i = 0; i <= int.MaxValue; i++) ; //note semicolon here
            Console.WriteLine("Program ended!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}

Qn-2

using System;
public class Program
{
    static void Main(string[] args)
    {
        Main(["CS202"]);
    }
}
*/