// Problem 11.* Number as Words

// Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;

class NumbersAsWords
{
    static string Capitalize(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return string.Empty;
        }
        return char.ToUpper(s[0]) + s.Substring(1);
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string numberAsWord = null;
        string[] underTwenty = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] twentyToNinety = new[] { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string hundred = "hundred";
        if (n >= 0 && n <= 19)
        {
            numberAsWord = Capitalize(underTwenty[n]);
        }
        else if (n >= 20 && n <= 99)
        {
            numberAsWord = Capitalize(twentyToNinety[(n / 10) - 2]);
            if (n % 10 != 0)
            {
                numberAsWord += " " + underTwenty[n % 10];
            }
        }
        else if (n >= 100 && n <= 999)
        {
            numberAsWord = Capitalize(underTwenty[n / 100]) + " " + hundred;
            if (n % 100 != 0)
            {
                numberAsWord += " and ";
                if (n % 100 >= 1 && n % 100 <= 19)
                {
                    numberAsWord += underTwenty[n % 100];
                }
                else
                {
                    numberAsWord += twentyToNinety[(n % 100) / 10 - 2];
                    if ((n % 100) / 10 != 0)
                    {
                        numberAsWord += " " + underTwenty[(n % 100) % 10];
                    }
                }
            }
        }
        Console.WriteLine(numberAsWord);
    }
}

