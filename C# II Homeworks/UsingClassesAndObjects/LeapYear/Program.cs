/*
Problem 1. Leap year

Write a program that reads a year from the console and checks whether it is a leap one.
Use System.DateTime.
*/

using System;

class Program
{
    static void Main()
    {
        int year;
        bool input = int.TryParse(Console.ReadLine(), out year);
        if (input && year >= 0 && year <= 9999)
        {
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0} is a leap year!", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year!", year);
            }
        }
        else
        {
            Console.WriteLine("Invalid year!");
        }
        
    }
}
