// Problem 12. Null Values Arithmetic
   
// Create a program that assigns null values to an integer and to a double variable.
// Try to print these variables at the console.
// Try to add some number or the null literal to these variables and print the result.

using System;

class NullValues
{
    static void Main()
    {
        int? nullInt = new int();
        double? nullDouble = new double();
        Console.WriteLine("Int: {0}\r\nDouble: {1}", nullInt, nullDouble);
        nullInt = null;
        nullDouble = null;
        Console.WriteLine("Int: {0}\r\nDouble: {1}", nullInt, nullDouble);
        nullInt = 12345;
        nullDouble = 12345.12345;
        Console.WriteLine("Int: {0}\r\nDouble: {1}", nullInt, nullDouble);
    }
}

