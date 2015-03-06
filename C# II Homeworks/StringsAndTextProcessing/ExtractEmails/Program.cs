/*
Problem 18. Extract e-mails

Write a program for extracting all email addresses from given text.
All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
*/

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "This text has some emails. For example, myEmail@abv.bg goshosMail@gmail.com & someEmail@yahoo.com are valid emails. abc@bg is not.";
        string regex = @"\b[A-Z0-9._%+-]+@(?:[A-Z0-9-]+\.)+[A-Z]{2,4}\b";
        var matches = Regex.Matches(text, regex, RegexOptions.IgnoreCase);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
