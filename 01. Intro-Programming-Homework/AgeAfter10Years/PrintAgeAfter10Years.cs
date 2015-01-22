// Problem 15.* Age after 10 Years

// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class PrintAgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Write your birthday (DD/MM/YYYY):");
        string input = Console.ReadLine(); // get the user's input
        DateTime today = DateTime.Today; // get current date
        DateTime birthday; // initialize a variable for the date
        if (DateTime.TryParse(input, out birthday)) // check if the date is valid (google DateTime.TryParse)
        {
            int age = today.Year - birthday.Year; // get difference in years from the birth year to the current
            if (birthday > today.AddYears(-age)) age--; // if the user hasn't turned the above age, substract one from it
            Console.WriteLine("Your age now: " + age);
            Console.WriteLine("Your age in 10 years: " + (age + 10));
        }
        else
        {
            Console.WriteLine("Invalid Date!"); // if the date is not valid - send this error
        }
    }
}