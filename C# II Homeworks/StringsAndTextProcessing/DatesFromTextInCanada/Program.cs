/*
Problem 19. Dates from text in Canada

Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
Display them in the standard date format for Canada.
*/

using System;
using System.Globalization;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Some text with random dates: 22.01.2015, 23.12.2013, 32.01.2000, 20.07.2016, 29.02.2015.";
        var matches = Regex.Matches(text, @"\b[0-9]{1,2}.[0-9]{1,2}.[0-9]{2,4}");
        foreach (Match match in matches)
        {
            DateTime date;
            if (DateTime.TryParseExact(match.Value, "d.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
        }
    }
}
