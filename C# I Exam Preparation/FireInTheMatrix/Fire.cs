using System;

class Fire
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int outsideDots = width / 2 - 1;
        int insideDots = 0;

        for (int i = 0; i < width / 2; i++)
        {
            Console.Write(new string('.', outsideDots));
            Console.Write('#');
            Console.Write(new string('.', insideDots));
            Console.Write(new string('.', insideDots));
            Console.Write('#');
            Console.Write(new string('.', outsideDots));
            outsideDots--;
            insideDots++;
            Console.WriteLine();
        }
        outsideDots = 0;
        insideDots = width / 2 - 1;
        for (int i = 0; i < width / 4; i++)
        {
            Console.Write(new string('.', outsideDots));
            Console.Write('#');
            Console.Write(new string('.', insideDots));
            Console.Write(new string('.', insideDots));
            Console.Write('#');
            Console.Write(new string('.', outsideDots));
            outsideDots++;
            insideDots--;
            Console.WriteLine();
        }
        for (int i = 0; i < width; i++)
        {
            Console.Write('-');
        }
        Console.WriteLine();
        int slashCount = width / 2;
        outsideDots = 0;
        for (int i = 0; i < width / 2; i++)
        {
            Console.Write(new string('.', outsideDots));
            Console.Write(new string('\\', slashCount));
            Console.Write(new string('/', slashCount));
            Console.Write(new string('.', outsideDots));
            outsideDots++;
            slashCount--;
            Console.WriteLine();
        }
    }
}

