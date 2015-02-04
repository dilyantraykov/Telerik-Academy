using System;

class Trolls
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int width = N * 2 + 1;
        int height = (6 + ((N - 3) / 2) * 3);
        int outsideDots = N / 2 + 1;
        Console.Write(new string('.', outsideDots));
        Console.Write(new string('*', N));
        Console.Write(new string('.', outsideDots));
        Console.WriteLine();
        outsideDots--;

        outsideDots = N / 2;
        int insideDots = N / 2;
        for (int i = 0; i < N / 2; i++)
        {
            Console.Write(new string('.', outsideDots));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', insideDots));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', insideDots));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', outsideDots));
            Console.WriteLine();
            insideDots++;
            outsideDots--;
        }

        Console.WriteLine(new string('*', width));

        outsideDots = 1;
        insideDots--;
        for (int i = 0; i < N - 1; i++)
        {
            Console.Write(new string('.', outsideDots));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', insideDots));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', insideDots));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', outsideDots));
            Console.WriteLine();
            insideDots--;
            outsideDots++;
        }
        Console.Write(new string('.', outsideDots));
        Console.Write(new string('*', 1));
        Console.Write(new string('.', outsideDots));
    }
}

