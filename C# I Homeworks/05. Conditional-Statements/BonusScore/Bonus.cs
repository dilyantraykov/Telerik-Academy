// Problem 2. Bonus Score

// Write a program that applies bonus score to given score in the range [1…9] by the following rules:
// - If the score is between 1 and 3, the program multiplies it by 10.
// - If the score is between 4 and 6, the program multiplies it by 100.
// - If the score is between 7 and 9, the program multiplies it by 1000.
// - If the score is 0 or more than 9, the program prints “invalid score”.

using System;

class Bonus
{
    static void Main()
    {
        Console.WriteLine("Insert score: ");
        int score = int.Parse(Console.ReadLine());
        if (score >= 1 && score <= 3)
        {
            score *= 10;
            Console.WriteLine(score);
        }
        else if (score >= 4 && score <= 6)
        {
            score *= 100;
            Console.WriteLine(score);
        }
        else if (score >= 7 && score <= 9)
        {
            score *= 1000;
            Console.WriteLine(score);
        }
        else
        {
            Console.WriteLine("invalid score");
        }
    }
}

