// Problem 2. Print Company Information

// A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
// Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class CompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Company name: ");
        string companyName = Console.ReadLine();
        Console.WriteLine("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Phone number: ");
        string companyPhoneNumber = Console.ReadLine();
        Console.WriteLine("Fax number: ");
        string companyFaxNumber = Console.ReadLine();
        Console.WriteLine("Website: ");
        string website = Console.ReadLine();
        Console.WriteLine("Manager first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Manager last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Manager age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Manager phone: ");
        string managerPhoneNumber = Console.ReadLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: " + companyAddress);
        Console.WriteLine("Tel. " + companyPhoneNumber);
        Console.WriteLine("Fax: " + companyFaxNumber);
        Console.WriteLine("Web site: " + website);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstName, lastName, age, managerPhoneNumber);
    }
}
