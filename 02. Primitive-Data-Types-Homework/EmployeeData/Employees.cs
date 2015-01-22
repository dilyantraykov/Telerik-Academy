// Problem 10. Employee Data
   
// A marketing company wants to keep record of its employees. Each record would have the following characteristics:
   
// First name
// Last name
// Age (0...100)
// Gender (m or f)
// Personal ID number (e.g. 8306112507)
// Unique employee number (27560000…27569999)
// Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;

class Employees
{
    static void Main()
    {
        string firstName = "Trendaphil";
        string lastName = "Popov";
        byte age = 40;
        char gender = 'm';
        ulong id = 8306115507;
        uint employeeNumber = 27563129;
        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Personal ID: " + id);
        Console.WriteLine("Employee Number:" + employeeNumber);
    }
}
