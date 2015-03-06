/*
Problem 3. Decimal to hexadecimal

Write a program to convert decimal numbers to their hexadecimal representation.
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} = {1}", number, DecimalToHexadecimal(number));
    }

    static string DecimalToHexadecimal(int number)
    {
        string hex = "";
        if (number == 0)
        {
            hex = "0";
        }
        else
        {
            while (number > 0)
            {
                switch (number % 16)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        hex = number % 16 + hex;
                        break;
                    case 10:
                        hex = "A" + hex;
                        break;
                    case 11:
                        hex = "B" + hex;
                        break;
                    case 12:
                        hex = "C" + hex;
                        break;
                    case 13:
                        hex = "D" + hex;
                        break;
                    case 14:
                        hex = "E" + hex;
                        break;
                    case 15:
                        hex = "F" + hex;
                        break;
                }
                number /= 16;
            }
        }
        return hex;
    }
}
