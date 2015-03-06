/*
Problem 1. Say Hello

Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.
*/

using System;

class Program
{
    static void Main()
    {
        SayHello();
    }

    static void SayHello()
    {
        Console.WriteLine("What's your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
    }
}
