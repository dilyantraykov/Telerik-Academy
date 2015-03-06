/*
Problem 1. Odd lines

Write a program that reads a text file and prints on the console its odd lines.
*/

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader textFile = new StreamReader(@"../../test.txt");
        using (textFile)
        {
            int lineNumber = 1;
            string line = textFile.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 == 1)
                {
                    Console.WriteLine(line);
                }
                line = textFile.ReadLine();
                lineNumber++;
            }
        }
    }
}
