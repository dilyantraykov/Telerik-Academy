using System;

class Flag
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int insideDots = N / 2 - 1;
        int outsideDots = 0;
        for (int i = 0; i < N / 2; i++)
        {
            Console.Write(new string('.', outsideDots));
            Console.Write('\\');
            Console.Write(new string('.', insideDots));
            Console.Write('|');
            Console.Write(new string('.', insideDots));
            Console.Write('/');
            Console.Write(new string('.', outsideDots));
            insideDots--;
            outsideDots++;
            Console.WriteLine();
        }
        for (int i = 0; i < N; i++)
        {
            if (i == N / 2)
            {
                Console.Write('*');
            }
            else
            {
                Console.Write('-');
            }
        }
        Console.WriteLine();
        insideDots = 0;
        outsideDots = N / 2 - 1;
        for (int i = 0; i < N / 2; i++)
        {
            Console.Write(new string('.', outsideDots));
            Console.Write('/');
            Console.Write(new string('.', insideDots));
            Console.Write('|');
            Console.Write(new string('.', insideDots));
            Console.Write('\\');
            Console.Write(new string('.', outsideDots));
            insideDots++;
            outsideDots--;
            Console.WriteLine();
        }
    }
}
