/*
Problem 2. IEnumerable extensions

Implement a set of extension methods for IEnumerable<T> that implement the following group functions:
sum, product, min, max, average.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public static class IEnumerableExtension
{
    public static T Sum<T>(this IEnumerable<T> collection)
    {
        var sum = default(T);
        foreach (var item in collection)
        {
            sum += (dynamic)item;
        }
        return sum;
    }

    public static T Product<T>(this IEnumerable<T> collection)
    {
        T product = (dynamic)1;
        foreach (var item in collection)
        {
            product *= (dynamic)item;
        }
        return product;
    }

    public static T Max<T>(this IEnumerable<T> collection)
        where T : IComparable
    {
        T max = collection.First();
        foreach (var item in collection)
        {
            if (item.CompareTo(max) > 0)
            {
                max = item;
            }
        }
        return max;
    }

    public static T Min<T>(this IEnumerable<T> collection)
    where T : IComparable
    {
        T min = collection.First();
        foreach (var item in collection)
        {
            if (item.CompareTo(min) < 0)
            {
                min = item;
            }
        }
        return min;
    }
}

namespace IEnumerableExtensions
{
    public class TestExtensions
    {
        private static void Main()
        {
            var myList = new List<int>() {1, 2, 3, 4, 5};

            Console.WriteLine("The sum of the elements:");
            Console.WriteLine(myList.Sum());
            Console.WriteLine();

            Console.WriteLine("The product of the elements:");
            Console.WriteLine(myList.Product());
            Console.WriteLine();

            Console.WriteLine("The max of the elements:");
            Console.WriteLine(myList.Max());
            Console.WriteLine();

            Console.WriteLine("The min of the elements:");
            Console.WriteLine(myList.Min());

        }
    }
}

