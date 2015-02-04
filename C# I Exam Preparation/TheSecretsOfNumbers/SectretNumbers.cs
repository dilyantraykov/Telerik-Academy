using System;
using System.Numerics;

class SectretNumbers
{
    static void Main()
    {
        /*string N = Console.ReadLine();
        BigInteger specialSum = 0;
        int count = 1;
        for (int i = N.Length-1; i >= 0; i--)
        {
            if (N[i] != '-')
            {
                int digit = int.Parse(N[i].ToString());
                if (count % 2 == 0)
                {
                    specialSum += digit * digit * count;
                }
                else
                {
                    specialSum += digit * count * count;
                }
                count++;
            }
        }
        Console.WriteLine(specialSum);
        int remainder = (int)(specialSum % 26);
        int sequenceLength = (int)(specialSum % 10);
        if (sequenceLength == 0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence", N);
        }
        else
        {
            int letter = remainder + 1;
            for (int i = 0; i < sequenceLength; i++)
            {
                Console.Write((char)(64 + letter));
                letter++;
                if (64 + letter == 91)
                {
                    letter = 1;
                }
            }
        }*/
        string N = Console.ReadLine();
        int counter = 1;
        BigInteger sum = 0;
        int length = 0;
        int r = 0;


        for (int i = N.Length - 1; i >= 0; i--)
        {
            char number = N[i];
            if (number != '-')
            {
                if (counter % 2 == 1)
                {
                    sum += (number - '0') * counter * counter;
                }
                else if (counter % 2 == 0)
                {
                    sum += (number - '0') * (number - '0') * counter;
                }
                counter++;
            }
        }

        Console.WriteLine(sum);

        length = (int)(sum % 10);
        r = (int)(sum % 26);

        if (length == 0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence", N);
        }
        else if (length > 0)
        {
            int letter = r + 65;
            for (int i = 0; i < length; i++)
            {
                Console.Write((char)(letter));
                letter++;
                if (letter == 91)
                {
                    letter = 65;
                }
            }
        }      
    }
}
