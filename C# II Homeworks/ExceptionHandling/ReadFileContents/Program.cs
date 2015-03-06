/*
Problem 3. Read file contents

Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages.
*/

using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string filePath = Console.ReadLine(); // try ../../test.txt

            string readText = File.ReadAllText(filePath);
            Console.WriteLine(readText);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You don't have the necessary rights to acces this file/directory!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Entered non-existing path!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Please enter non-empty string!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
