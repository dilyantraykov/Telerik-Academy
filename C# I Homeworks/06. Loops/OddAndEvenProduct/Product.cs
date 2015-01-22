// Problem 10. Odd and Even Product

// You are given n integers (given in a single line, separated by a space).
// Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
// Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;

class Product
{
    static void Main()
    {
        Console.WriteLine("Insert numbers separated by spaces:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        int even_product = 1;
        int odd_product = 1;
        for (int i = 0; i <= numbers.Length - 1; i+=2)
        {
            odd_product *= int.Parse(numbers[i]);
        }
        for (int i = 1; i <= numbers.Length - 1; i += 2)
        {
            even_product *= int.Parse(numbers[i]);
        }
        Console.WriteLine("odd_product: " + odd_product);
        Console.WriteLine("even_product: " + even_product);
        Console.WriteLine("Is the product of the odd numbers equal to\nthe product of the even elements? " + (odd_product == even_product ? "Yes!" : "No!"));
    }
}

