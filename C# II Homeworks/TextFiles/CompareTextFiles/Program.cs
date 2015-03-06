/*
Problem 4. Compare text files

Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
Assume the files have equal number of lines.
*/

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader reader1 = new StreamReader("../../file1.txt");
        StreamReader reader2 = new StreamReader("../../file2.txt");
        string line1 = reader1.ReadLine();
        string line2 = reader2.ReadLine();
        int sameCount = 0;
        int totalCount = 0;
        while (line1 != null) // * Assume the files have equal number of lines.
        {
            if (line1 == line2)
            {
                sameCount++;
            }
            Console.WriteLine("{0} ?= {1} -> {2}", line1, line2, line1 == line2);
            line1 = reader1.ReadLine();
            line2 = reader2.ReadLine();
            totalCount++;
        }
        reader1.Close();
        reader2.Close();
        Console.WriteLine(new string('=', 25));
        Console.WriteLine("Identic lines: {0}", sameCount);
        Console.WriteLine("Different lines: {0}", totalCount - sameCount);
    }
}
