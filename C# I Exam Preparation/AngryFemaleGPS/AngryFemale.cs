using System;

class AngryFemale
{
    static void Main()
    {
        string N = (Console.ReadLine());
        long evenSum = 0;
        long oddSum = 0;
        for (int i = 0; i < N.Length; i++)
        {
            int digit;
            bool number = int.TryParse(N[i].ToString(), out digit);
            if (number)
            {
                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }
                else
                {
                    oddSum += digit;
                }
            }
        }
        if (oddSum == evenSum)
        {
            Console.Write("straight ");
        }
        else if (oddSum > evenSum)
        {
            Console.Write("left ");
        }
        else
        {
            Console.Write("right ");
        }
        Console.Write(oddSum > evenSum ? oddSum : evenSum);
    }
}

