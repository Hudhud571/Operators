// Define the Employee class
public class Employee
{
    // Properties for Employee class
    public int Id { get; set; } // Unique identifier for the employee
    public string FirstName { get; set; } // First name of the employee
    public string LastName { get; set; } // Last name of the employee

    // Overload the "==" operator to compare two Employee objects based on their Id property
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Check if both objects are null or if one is null
        if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
            return true;
        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            return false;

        // Compare the Id properties of the two Employee objects
        return emp1.Id == emp2.Id;
    }

    // Overload the "!=" operator as it must be paired with the "==" operator
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        // Use the overloaded "==" operator and negate the result
        return !(emp1 == emp2);
    }

    // Override the Equals method to ensure consistency with the overloaded operators
    public override bool Equals(object obj)
    {
        // Check if the object is an Employee and compare using the overloaded "==" operator
        if (obj is Employee other)
            return this == other;
        return false;
    }

    // Override GetHashCode to ensure consistency with the overridden Equals method
    public override int GetHashCode()
    {
        return Id.GetHashCode(); // Use the Id property for hash code generation
    }
}
