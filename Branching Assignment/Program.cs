using System;   // Using the System namespace for basic console functionality

class Program
{
    static void Main()
    {
        // Display the welcome message (required first line)
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user for the package weight
        Console.WriteLine("Please enter the package weight:");
        float weight = float.Parse(Console.ReadLine());  // Convert input to a number

        // Check if the weight is too heavy
        if (weight > 50)
        {
            // Display error message and exit program
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;  // End program
        }

        // Prompt the user for the package width
        Console.WriteLine("Please enter the package width:");
        float width = float.Parse(Console.ReadLine());  // Convert input to a number

        // Prompt the user for the package height
        Console.WriteLine("Please enter the package height:");
        float height = float.Parse(Console.ReadLine());  // Convert input to a number

        // Prompt the user for the package length
        Console.WriteLine("Please enter the package length:");
        float length = float.Parse(Console.ReadLine());  // Convert input to a number

        // Check if total dimensions exceed limit
        if (width + height + length > 50)
        {
            // Display error and exit program
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;  // End program
        }

        // Calculate the quote by multiplying dimensions, then by weight, then dividing by 100
        float quote = (width * height * length * weight) / 100;

        // Display final quote formatted as currency
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));

        // Display thank-you message
        Console.WriteLine("Thank you!");
    }
}
