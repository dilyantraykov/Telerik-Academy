/*
Problem 5. Parse tags

You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.
Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
*/

using System;
using System.Text;

class Program
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine(ParseTags(text));
    }

    static string ParseTags(string text)
    {
        StringBuilder parsedText = new StringBuilder(text.Length);
        parsedText.Append(text);
        int startIndex = text.IndexOf("<upcase>");
        int endIndex = text.IndexOf("</upcase>");
        int tagLength = "<upcase>".Length;
        while (startIndex >= 0)
        {
            for (int i = startIndex + tagLength; i < endIndex; i++)
            {
                parsedText[i] = Char.ToUpper(parsedText[i]);
            }
            startIndex = text.IndexOf("<upcase>", startIndex + 1);
            endIndex = text.IndexOf("</upcase>", endIndex + 1);
        }
        parsedText.Replace("<upcase>", "");
        parsedText.Replace("</upcase>", "");
        return parsedText.ToString();
    }
}
