// Problem 11. Bank Account Data
   
// A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
// Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Trendaphil";
        string middleName = "Ivanov";
        string lastName = "Popov";
        decimal balance = 402500.14662M;
        string iban = "GB29 NWBK 6016 1331 9268 19";
        ulong? card1 = 1234567891234;
        ulong? card2 = null;
        ulong? card3 = null;
        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Middle Name: " + middleName);
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("Balance: " + balance);
        Console.WriteLine("IBAN: " + iban);
        Console.WriteLine("Credit Card #1: " + card1);
        Console.WriteLine("Credit Card #2: " + card2);
        Console.WriteLine("Credit Card #3: " + card3);
    }
}

