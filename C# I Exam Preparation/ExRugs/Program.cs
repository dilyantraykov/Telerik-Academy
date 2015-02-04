using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());
        int width = 2 * N + 1;
        int outsideDots = 0;
        int sharpCount = 1 + D / 2;
        int insideDots = width - (sharpCount * 2) - 2;
        if (D == width - 2)
        {
            for (int i = 0; i < width; i++)
            {
                if (i == width / 2)
                {
                    Console.Write('X');
                    Console.Write(new string('#', width - 2));
                    Console.Write('X');
                }
                else
                {
                    Console.Write(new string('#', width / 2));
                    if (i == 0 || i == width - 1)
                    {
                        Console.Write('X');
                    }
                    else
                    {
                        Console.Write('#');
                    }
                    Console.Write(new string('#', width / 2));
                }
                Console.WriteLine();

            }
        }
        else if (D < width - 2)
        {
            for (int i = 0; i < width / 2; i++)
            {
                if (outsideDots > 0)
                {
                    Console.Write(new string('.', outsideDots - 1));
                    Console.Write('\\');
                }
                if (insideDots > 0)
                {
                    Console.Write(new string('#', sharpCount));
                    Console.Write('\\');
                    Console.Write(new string('.', insideDots));
                    Console.Write('/');
                    Console.Write(new string('#', sharpCount));
                }
                else if (insideDots == -1)
                {
                    Console.Write(new string('#', sharpCount));
                    Console.Write(new string('X', Math.Abs(insideDots)));
                    Console.Write(new string('#', sharpCount));
                }
                else
                {
                    Console.Write(new string('#', sharpCount + insideDots + 1));
                    Console.Write(new string('#', Math.Abs(insideDots)));
                    Console.Write(new string('#', sharpCount + insideDots + 1));
                }
                if (outsideDots > 0)
                {
                    Console.Write('/');
                    Console.Write(new string('.', outsideDots - 1));
                }
                if (sharpCount < D)
                {
                    sharpCount++;
                }
                else if (sharpCount >= D)
                {
                    outsideDots++;
                }
                insideDots -= 2;
                Console.WriteLine();
            }

            outsideDots = (width - D - 2) / 2;
            Console.Write(new string('.', outsideDots));
            Console.Write('X');
            Console.Write(new string('#', D));
            Console.Write('X');
            Console.WriteLine(new string('.', outsideDots));

            outsideDots = (width - D - 2) / 2;
            insideDots = -D;
            sharpCount = D;
            for (int i = 0; i < width / 2; i++)
            {
                if (outsideDots > 0)
                {
                    Console.Write(new string('.', outsideDots - 1));
                    Console.Write('/');
                }
                if (insideDots > 0)
                {
                    if (outsideDots < 0)
                    {
                        Console.Write(new string('#', sharpCount + outsideDots));
                        Console.Write('/');
                        Console.Write(new string('.', insideDots));
                        Console.Write('\\');
                        Console.Write(new string('#', sharpCount + outsideDots));
                    }
                    else
                    {
                        Console.Write(new string('#', sharpCount));
                        Console.Write('/');
                        Console.Write(new string('.', insideDots));
                        Console.Write('\\');
                        Console.Write(new string('#', sharpCount));
                    }
                }
                else if (insideDots == -1 || insideDots == -2)
                {
                    if (outsideDots >= 0)
                    {
                        Console.Write(new string('#', sharpCount));
                        Console.Write(new string('X', Math.Abs(insideDots)));
                        Console.Write(new string('#', sharpCount));
                    }
                    else
                    {
                        Console.Write(new string('#', width / 2));
                        Console.Write('X');
                        Console.Write(new string('#', width / 2));
                    }
                }
                else
                {
                    if (outsideDots < 0)
                    {
                        Console.Write(new string('#', width));
                    }
                    else
                    {
                        Console.Write(new string('#', sharpCount + insideDots + 1));
                        Console.Write(new string('#', Math.Abs(insideDots)));
                        Console.Write(new string('#', sharpCount + insideDots + 1));
                    }
                }
                if (outsideDots > 0)
                {
                    Console.Write('\\');
                    Console.Write(new string('.', outsideDots - 1));
                }
                //Console.Write("sharpCount:{0}, outsideDots:{1}, insideDots:{2}", sharpCount, outsideDots, insideDots);
                if (sharpCount < D)
                {
                    sharpCount++;
                }
                else if (sharpCount >= D)
                {
                    outsideDots--;
                }
                insideDots += 2;
                Console.WriteLine();
            }
        }
        else
        {
            for (int i = 0; i < width; i++)
            {
                if (D == width - 2 && i == N)
                {
                    Console.Write('X');
                    Console.Write(new string('#', width - 2));
                    Console.WriteLine('X');
                }
                else
                {
                    Console.WriteLine(new string('#', width));
                }
            }
        }
        Console.ReadLine();
    }
}

