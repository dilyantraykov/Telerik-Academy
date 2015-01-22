// Problem 10.* Beer Time

// A beer time is after 1:00 PM and before 3:00 AM.
// Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.

using System;
using System.Globalization;

class Beer
{
    static void Main()
    {
        Console.WriteLine("Enter a time in format hh:mm tt (with leading zeroes please)");
        string time = Console.ReadLine();
        DateTime beerTime;
        DateTime afterNoon = Convert.ToDateTime("01:00 PM");
        DateTime afterMidnight = Convert.ToDateTime("03:00 AM");
        if (DateTime.TryParseExact(time, "hh:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out beerTime))
        {
            if (beerTime.TimeOfDay.Ticks < afterNoon.TimeOfDay.Ticks && beerTime.TimeOfDay.Ticks > afterMidnight.TimeOfDay.Ticks)
            {
                Console.WriteLine("non-beer time");
            }
            else
            {
                Console.WriteLine("beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}
