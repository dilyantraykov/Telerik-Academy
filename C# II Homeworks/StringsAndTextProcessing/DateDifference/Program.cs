/*
Problem 16. Date difference

Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
Example:

Enter the first date: 27.02.2006
Enter the second date: 3.03.2006
Distance: 4 days
*/

using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first date: ");
        DateTime firstDate;
        bool validFirstDate = DateTime.TryParseExact(Console.ReadLine(), "d.M.yyyy",  new CultureInfo("en-US"), DateTimeStyles.None, out firstDate);
        if (validFirstDate)
        {
            Console.Write("Enter the second date: ");
            DateTime secondDate;
            bool validSecondDate = DateTime.TryParseExact(Console.ReadLine(), "d.M.yyyy", new CultureInfo("en-US"), DateTimeStyles.None, out secondDate);
            if (validSecondDate)
            {
                Console.WriteLine("Distance: {0} days", Math.Abs((firstDate - secondDate).TotalDays));
            }
            else
            {
                Console.WriteLine("Invalid date!");
            }
        }
        else
        {
            Console.WriteLine("Invalid date!");
        }
    }
}
