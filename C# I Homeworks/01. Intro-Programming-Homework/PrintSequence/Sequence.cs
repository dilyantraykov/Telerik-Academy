// Problem 9. Print a Sequence
   
// Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class Sequence
{
    static void Main()
    {
        // This for loop goes over each number between 2 and 11 inclusively
        // Check out "For Loop" if you're interested
        for (int i = 2; i < 12; i++)
        {
            // If the number is even it prints out the positive value of i
            // If the number is odd it prints out the negative value of i
            // ((i % 2 == 0) ? i : -i) is called a "Ternary Operator" - check it out
            Console.WriteLine((i % 2 == 0) ? i : -i);
        }
    }
}
