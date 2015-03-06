/*
Problem 9. Delete odd lines

Write a program that deletes from given text file all odd lines.
The result should be in the same file.
*/

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        var writer = new StreamWriter("../../input.txt");
        for (int i = 1; i <= 1000000; i++)
        {
            if (i % 2 == 1)
            {
                writer.WriteLine("This is an odd line!");
            }
            else
            {
                writer.WriteLine("This is an even line!");
            }
        }
        writer.Close();

        List<string> lines = new List<string>();

        var reader = new StreamReader("../../input.txt");
        string line = reader.ReadLine();
        int linesNumber = 0;
        while(line != null)
        {
            if (linesNumber % 2 == 0)
            {
                lines.Add(line);
            }
            linesNumber++;
            line = reader.ReadLine();
        }
        reader.Close();

        var rewriter = new StreamWriter("../../input.txt");
        foreach (string item in lines)
        {
            rewriter.WriteLine(item);
        }
        rewriter.Close();
    }
}
