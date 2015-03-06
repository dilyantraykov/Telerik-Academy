/*
Problem 6. Binary to hexadecimal

Write a program to convert binary numbers to hexadecimal numbers (directly).
*/

using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string binaryNumber = Console.ReadLine();
        Console.WriteLine("{0} = {1}", binaryNumber, BinaryToHexadecimal(binaryNumber));
    }

    public static StringBuilder BinaryToHexadecimal(string binNumber)
    {
        var sb = new StringBuilder(binNumber);
        int remainder = 0;

        if (binNumber.Length % 4 != 0)
        {
            remainder = binNumber.Length % 4;

            for (int i = 0; i < 4 - remainder; i++)
            {
                sb.Insert(0, 0);
            }
        }

        char[] section = new char[4]; 
        var hex = new StringBuilder();

        while (sb.Length >= 4)
        {
            for (int i = 0; i < 4; i++)
            {
                section[i] = sb[0];
                sb.Remove(0, 1);
            }
            string sectionString = new string(section);

            switch (sectionString)
            {
                #region
                case "0000": hex.Append("0"); break;
                case "0001": hex.Append("1"); break;
                case "0010": hex.Append("2"); break;
                case "0011": hex.Append("3"); break;
                case "0100": hex.Append("4"); break;
                case "0101": hex.Append("5"); break;
                case "0110": hex.Append("6"); break;
                case "0111": hex.Append("7"); break;
                case "1000": hex.Append("8"); break;
                case "1001": hex.Append("9"); break;
                case "1010": hex.Append("A"); break;
                case "1011": hex.Append("B"); break;
                case "1100": hex.Append("C"); break;
                case "1101": hex.Append("D"); break;
                case "1110": hex.Append("E"); break;
                case "1111": hex.Append("F"); break;
                #endregion
            }
        }
        return hex;
    }
}
