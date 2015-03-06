/*
Problem 3. Correct brackets

Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
*/

using System;

class Program
{
    static void Main()
    {

    }

    static bool CheckBrackets(string expression)
    {
        bool openBracket = false;
        for (int i = 0; i < expression.Length; i++)
        {
            if (!openBracket && expression[i] == '(')
            {
                openBracket = true;
            }
            else if (openBracket && expression[i] == ')')
            {
                openBracket = false;
            }
        }
    }
}
