/*
Problem 10. Extract text from XML

Write a program that extracts from given XML file all the text without the tags.
Example:

<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>
*/

using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        var reader = new StreamReader("../../input.xml");
        string text = reader.ReadToEnd();
        text = Regex.Replace(text, @"<[^>]*>", "");
        Console.WriteLine(text);
        reader.Close();
    }
}
