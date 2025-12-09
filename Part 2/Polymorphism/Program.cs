using System;  // Importing System namespace for basic functionality like Console input/output

namespace EmployeeApp
{
    // Define the IQuittable interface
    public interface IQuittable
    {
        // Define the Quit method, which is expected to be implemented by any class that inherits this interface
        void Quit();
    }

    // Define the Employee class that inherits from IQuittable
    public class Employee : IQuittable
    {
        // Employee properties: Id, FirstName, and LastName
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Implementing the Quit method from IQuittable interface
        public void Quit()
        {
            // Print out a message to indicate the employee has quit their job
            Console.WriteLine($"{FirstName} {LastName} (Employee ID: {Id}) has quit their job.");
        }

        // Overload the == operator to compare two Employee objects based on their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both objects are the same reference
            if (ReferenceEquals(emp1, emp2)) return true;

            // If one of the objects is null, they can't be equal
            if (emp1 == null || emp2 == null) return false;

            // Compare the Id properties of both Employee objects
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator (the inverse of ==)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);  // Use the overloaded == operator to return the opposite result
        }

        // Override Equals method to ensure two Employee objects with the same Id are considered equal
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Employee)) return false;
            var other = (Employee)obj;
            return this.Id == other.Id;
        }

        // Override GetHashCode to be consistent with Equals
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }

    // Program class: The entry point of the application
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Employee
            Employee emp1 = new Employee { Id = 1, FirstName = "Ahmed", LastName = "AlabudAlqader" };

            // Create another instance of Employee
            Employee emp2 = new Employee { Id = 2, FirstName = "Mohammed", LastName = "Ahmed" };

            // Demonstrating polymorphism: Create an IQuittable reference to hold an Employee object
            IQuittable quitter = emp1;  // emp1 is an Employee, which implements IQuittable

            // Call the Quit method on the IQuittable object
            quitter.Quit();  // Output: "John Doe (Employee ID: 1) has quit their job."

            // Display the result of comparing the two Employee objects using the overloaded == operator
            if (emp1 == emp2)
            {
                Console.WriteLine("Employee 1 and Employee 2 are equal (same Id).");
            }
            else
            {
                Console.WriteLine("Employee 1 and Employee 2 are not equal (different Ids).");
            }

            // Wait for a key press before closing the console window
            Console.ReadKey();
        }
    }
}
