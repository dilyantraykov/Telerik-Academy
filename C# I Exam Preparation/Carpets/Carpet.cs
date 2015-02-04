using System;

class Carpet
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int outerDots = N / 2 - 1;
        int innerSymbols = 0;
        for (int i = 0; i < N / 2; i++)
        {
            Console.Write(new string('.', outerDots));
            Console.Write('/');
            for (int j = 0; j < innerSymbols; j++)
            {
                if (j % 2 == 1)
                {
                    Console.Write('/');
                }
                else
                {
                    Console.Write(' ');
                }
            }
            for (int j = 0; j < innerSymbols; j++)
            {
                if (i % 2 == 1)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('\\');
                    }
                }
                else
                {
                    if (j % 2 == 1)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('\\');
                    }
                }
            }
            Console.Write('\\');
            Console.Write(new string('.', outerDots));
            Console.WriteLine();
            outerDots--;
            innerSymbols++;
        }
        outerDots = 0;
        innerSymbols = N / 2 - 1;
        for (int i = N / 2 - 1; i < N - 1; i++)
        {
            Console.Write(new string('.', outerDots));
            Console.Write('\\');
            for (int j = 0; j < innerSymbols; j++)
            {
                if (j % 2 == 1)
                {
                    Console.Write('\\');
                }
                else
                {
                    Console.Write(' ');
                }
            }
            for (int j = 0; j < innerSymbols; j++)
            {
                if (i % 2 == 0)
                {
                    if (j % 2 == 1)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('/');
                    }
                }
                else
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('/');
                    }
                }
            }
            Console.Write('/');
            Console.Write(new string('.', outerDots));
            Console.WriteLine();
            outerDots++;
            innerSymbols--;
        }
    }
}
