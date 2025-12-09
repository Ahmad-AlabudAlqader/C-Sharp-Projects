using System;  // Importing System namespace for basic functionalities, like Console input/output

namespace EmployeeApp
{
    // Defining the Employee class with necessary properties: Id, FirstName, and LastName.
    public class Employee
    {
        // Auto-implemented properties for Id, FirstName, and LastName.
        public int Id { get; set; }         // Unique identifier for the employee
        public string FirstName { get; set; }  // Employee's first name
        public string LastName { get; set; }   // Employee's last name

        // Overloading the equality (==) operator to compare two Employee objects based on their Id property.
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Return true if both Employee objects are the same or their Ids are equal
            if (ReferenceEquals(emp1, emp2)) // Checks if both references point to the same object
                return true;

            // If any of the Employee objects is null, they are not equal
            if (emp1 == null || emp2 == null)
                return false;

            // Compare the Id properties of the two Employee objects
            return emp1.Id == emp2.Id;
        }

        // Overloading the inequality (!=) operator. This is a required complement to the == operator.
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // If the == operator returns false, the objects are not equal.
            return !(emp1 == emp2);
        }

        // Override the Equals method to make sure that we are consistently comparing objects by Id.
        public override bool Equals(object obj)
        {
            // Check if the object is null or not of type Employee
            if (obj == null || !(obj is Employee))
                return false;

            // Safely cast the object to Employee and compare the Ids
            var other = (Employee)obj;
            return this.Id == other.Id;
        }

        // Override the GetHashCode method to maintain consistency with the Equals method.
        public override int GetHashCode()
        {
            // Use the Id as the hash code, as that's the field we're comparing for equality
            return this.Id.GetHashCode();
        }
    }

    // The entry point of the application
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee { Id = 1, FirstName = "Ahmed", LastName = "AlabudAlqader" };

            Employee emp2 = new Employee { Id = 2, FirstName = "Mohammed", LastName = "Ahmed" };

            // Displaying the result of comparing the two Employee objects using the overloaded == operator
            if (emp1 == emp2)
            {
                Console.WriteLine("Employee 1 and Employee 2 are equal (same Id).");
            }
            else
            {
                Console.WriteLine("Employee 1 and Employee 2 are not equal (different Ids).");
            }

            // Displaying the result of comparing the two Employee objects using the overloaded != operator
            if (emp1 != emp2)
            {
                Console.WriteLine("Employee 1 and Employee 2 are not equal (different Ids).");
            }
            else
            {
                Console.WriteLine("Employee 1 and Employee 2 are equal (same Id).");
            }

            // Pause the console to view the results before closing
            Console.ReadKey();
        }
    }
}
