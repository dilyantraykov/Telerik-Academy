/*
Problem 7. Replace sub-string

Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
Ensure it will work with large files (e.g. 100 MB).
*/

using System;
using System.IO;

class Program
{
    static void Main()
    {
        var writer = new StreamWriter("../../input.txt");
        for (int i = 0; i < 10000000; i++) // makes a ~230 MB file - ensure you have enough space
        {
            writer.Write("From start to finish...");
        }
        writer.Close();

        var reader = new StreamReader("../../input.txt");
        string text = reader.ReadToEnd();
        text = text.Replace("start", "finish");
        reader.Close();

        var rewriter = new StreamWriter("../../input.txt");
        rewriter.Write(text);
        rewriter.Close();
    }
}
