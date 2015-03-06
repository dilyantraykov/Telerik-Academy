/*
Problem 3. Line numbers

Write a program that reads a text file and inserts line numbers in front of each of its lines.
The result should be written to another text file.
*/

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../input.txt");
        StreamWriter writer = new StreamWriter("../../output.txt");
        string line = reader.ReadLine();
        int lineNumber = 1;
        Console.WriteLine("Output file content:");
        while (line != null)
        {
            string newLine = String.Format("{0} - {1}", lineNumber, line);
            Console.WriteLine(newLine);
            writer.WriteLine(newLine);
            lineNumber++;
            line = reader.ReadLine();
        }
        writer.Close();
        reader.Close();
    }
}
