/*
Problem 6. Save sorted names

Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
Example:

input.txt	output.txt
Ivan        George 
Peter       Ivan 
Maria       Maria 
George	    Peter
*/

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        var reader = new StreamReader("../../input.txt");
        List<string> listOfStrings = new List<string>();
        string line = reader.ReadLine();
        while (line != null)
        {
            listOfStrings.Add(line);
            line = reader.ReadLine();
        }
        reader.Close();
        listOfStrings.Sort();
        var writer = new StreamWriter("../../output.txt");
        Console.WriteLine("Writing to output.txt...");
        foreach (var item in listOfStrings)
        {
            Console.WriteLine(item);
            writer.WriteLine(item);
        }
        writer.Close();
    }
}
