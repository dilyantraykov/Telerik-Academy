/*
Problem 7. Encode/decode

Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
*/

using System;

class Program
{
    static void Main()
    {
        string cipher = "thistaskisboring";
        string input = Console.ReadLine();
        int cipherIndex = 0;
        string encodedString = "";
        for (int i = 0; i < input.Length; i++)
        {
            encodedString += (char)(cipher[cipherIndex] ^ input[i]);
            cipherIndex++;
            if (cipher.Length >= cipherIndex)
            {
                cipherIndex = 0;
            }
        }
        Console.WriteLine("Encoded string: {0}", encodedString);
        string decodedString = "";
        cipherIndex = 0;
        for (int i = 0; i < input.Length; i++)
        {
            decodedString += (char)(cipher[cipherIndex] ^ encodedString[i]);
            cipherIndex++;
            if (cipher.Length >= cipherIndex)
            {
                cipherIndex = 0;
            }
        }
        Console.WriteLine("Decoded string: {0}", decodedString);
    }
}
