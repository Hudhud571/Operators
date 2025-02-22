using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the first Employee object and assign values to its properties
        Employee emp1 = new Employee
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe"
        };

        // Create the second Employee object and assign values to its properties
        Employee emp2 = new Employee
        {
            Id = 2,
            FirstName = "Jane",
            LastName = "Smith"
        };

        // Create the third Employee object with the same Id as the first Employee
        Employee emp3 = new Employee
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe"
        };

        // Compare emp1 and emp2 using the overloaded "==" operator
        Console.WriteLine($"Are emp1 and emp2 equal? {emp1 == emp2}"); // Expected: False

        // Compare emp1 and emp3 using the overloaded "==" operator
        Console.WriteLine($"Are emp1 and emp3 equal? {emp1 == emp3}"); // Expected: True

        // Compare emp1 and emp2 using the overloaded "!=" operator
        Console.WriteLine($"Are emp1 and emp2 not equal? {emp1 != emp2}"); // Expected: True

        // Compare emp1 and emp3 using the overloaded "!=" operator
        Console.WriteLine($"Are emp1 and emp3 not equal? {emp1 != emp3}"); // Expected: False
    }
}
