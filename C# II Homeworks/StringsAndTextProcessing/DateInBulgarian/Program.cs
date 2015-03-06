/*
Problem 17. Date in Bulgarian

Write a program that reads a date and time given in the format: day.month.year hour:minute:second and
prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
*/

using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        DateTime date;
        var culture = new CultureInfo("bg-BG");
        bool validDate = DateTime.TryParseExact(Console.ReadLine(), "d.M.yyyy HH:mm:ss", culture, DateTimeStyles.None, out date);
        if (validDate)
        {
            date = date.AddHours(6.5);
            string dayOfWeek = CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(date.DayOfWeek);
            Console.WriteLine("{0:d.M.yyyy HH:mm:ss} {1}", date, dayOfWeek);
        }
        else
        {
            Console.WriteLine("Invalid date!");
        }
    }
}
