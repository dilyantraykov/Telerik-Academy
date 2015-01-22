// Problem 14.* Print the ASCII Table

// Find online more information about ASCII (American Standard Code for Information Interchange)
// and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).

using System;

class PrintASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        for (int i = 0; i < 256; i++)
        {
            Console.WriteLine(i + " -> " + (char)i);
        }
    }
}