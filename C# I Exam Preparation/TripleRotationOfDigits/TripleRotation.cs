using System;

class TripleRotation
{
    static void Main()
    {
        string K = Console.ReadLine();
        for (int i = 0; i < 3; i++)
        {
            char lastDigit = K[K.Length - 1];
            string newString = "";
            if (lastDigit != '0')
            {
                newString += lastDigit;
            }
            for (int j = 0; j < K.Length - 1; j++)
            {
                    newString += K[j];
            }
            K = newString;
        }
        Console.WriteLine(K);
    }
}
