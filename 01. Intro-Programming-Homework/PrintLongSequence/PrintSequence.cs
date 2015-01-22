// Problem 16.* Print Long Sequence
// 
// Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
// You might need to learn how to use loops in C# (search in Internet).

using System;

class PrintSequence
{
    static void Main()
    {
        // This for loop goes over each number between 2 and 1001 inclusively
        // Check out "For Loop" if you're interested
        for (int i = 2; i < 1002; i++)
        {
            // If the number is even it prints out the positive value of i
            // If the number is odd it prints out the negative value of i
            // ((i % 2 == 0) ? i : -i) is called a "Ternary Operator" - check it out
            Console.WriteLine((i % 2 == 0) ? i : -i);
        }
    }
}
