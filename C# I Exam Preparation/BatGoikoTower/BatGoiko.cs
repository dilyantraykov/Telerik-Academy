using System;

class BatGoiko
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        int outsideDots = height - 1;
        int dashesOrDotsCount = 0;
        int crossbeamCount = 1;
        int lastCrossBeam = 0;
        for (int i = 0; i < height; i++)
        {
            Console.Write(new string('.', outsideDots));
            Console.Write(new string('/', 1));
            if (i == lastCrossBeam + crossbeamCount)
            {
                Console.Write(new string('-', dashesOrDotsCount));
                crossbeamCount++;
                lastCrossBeam = i;
            }
            else
            {
                Console.Write(new string('.', dashesOrDotsCount));
            }
            Console.Write(new string('\\', 1));
            Console.Write(new string('.', outsideDots));
            Console.WriteLine();
            outsideDots--;
            dashesOrDotsCount += 2;
        }
    }
}
