/*
Problem 11. Prefix "test"

Write a program that deletes from a text file all words that start with the prefix test.
Words contain only the symbols 0…9, a…z, A…Z, _.
*/

using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        var writer = new StreamWriter("../../input.txt");
        for (int i = 0; i < 1000; i++) 
        {
            writer.WriteLine("Some test text to test with testing purpose...");
        }
        writer.Close();

        var reader = new StreamReader("../../input.txt");
        string text = reader.ReadToEnd();
        text = Regex.Replace(text, @"\btest[A-Za-z0-9]*", "");
        reader.Close();

        var rewriter = new StreamWriter("../../input.txt");
        rewriter.Write(text);
        rewriter.Close();
    }
}
