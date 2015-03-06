/*
Problem 25. Extract text from HTML

Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
Example input:

<html>
  <head><title>News</title></head>
  <body><p><a href="http://academy.telerik.com">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skilful .NET software engineers.</p></body>
</html>
Output:

Title: News

Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.
*/

using System;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">TelerikAcademy</a>aims to provide free real-world practicaltraining for young people who want to turn intoskilful .NET software engineers.</p></body></html>";

            string head = Regex.Match(text, @"<\s*head\s*>.*?<\s*/\s*head\s*>").ToString();
            if (head == String.Empty || !head.Contains("title"))
            {
                head = string.Empty;
            }

            string title = Regex.Match(head, @"<\s*title\s*>.*?<\s*/\s*title\s*>").ToString();
            title = Regex.Replace(title, @"<\s*title\s*>", String.Empty);
            title = Regex.Replace(title, @"<\s*/\s*title\s*>", String.Empty);

            if (String.IsNullOrWhiteSpace(title))
            {
                title = "No Title";
            }
            
            string body = Regex.Match(text, @"<\s*body\s*>.*?<\s*/\s*body\s*>").ToString();
            body = Regex.Replace(body, @"<.*?>", String.Empty);
            Console.WriteLine(@"Title: {0}
Text: {1}", title, body);
    }
}
