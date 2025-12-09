using System;  // Import the System namespace, needed for basic console operations

namespace ConsoleApp
{
    // Define the main class of the application
    class MathOperations
    {
        // Create a method that accepts two integers as parameters.
        // The method performs an operation on the first integer and displays the second integer.
        public void PerformOperation(int num1, int num2)
        {
            // Perform a math operation on num1 (we're simply multiplying it by 2 here)
            int result = num1 * 2;  

            // Display the result of the operation to the console (i.e., the calculated result)
            Console.WriteLine($"The result of doubling {num1} is {result}.");

            // Now display the second integer as requested
            Console.WriteLine($"The second number passed was {num2}.");
        }
    }

    // The Main method is the entry point of any C# console application
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class to call its method
            MathOperations mathOp = new MathOperations();

            // Call the PerformOperation method with two numbers (passing the values directly)
            mathOp.PerformOperation(5, 10);

            // Call the PerformOperation method again, but this time specify the parameters by name
            mathOp.PerformOperation(num1: 7, num2: 20);

            // Wait for the user to press a key before closing the application
            Console.ReadKey();
        }
    }
}
