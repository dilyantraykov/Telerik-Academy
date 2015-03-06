/*
Problem 2. Concatenate text files

Write a program that concatenates two text files into another text file.
*/

using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            StreamReader file1 = new StreamReader("../../textFile1.txt");
            string file1Content;
            StreamReader file2 = new StreamReader("../../textFile2.txt");
            string file2Content;
            StreamWriter outputFile = new StreamWriter("../../output.txt");

            Console.WriteLine("Reading file #1...");
            using (file1)
            {
                file1Content = file1.ReadToEnd();
            }
            Console.WriteLine("Reading file #2...");
            using (file2)
            {
                file2Content = file2.ReadToEnd();
            }
            Console.WriteLine("Writing to output file...");
            using (outputFile)
            {
                outputFile.WriteLine(file1Content);
                outputFile.WriteLine(file2Content);
            }
            Console.WriteLine("Output file content:");
            Console.WriteLine(file1Content);
            Console.WriteLine(file2Content);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
