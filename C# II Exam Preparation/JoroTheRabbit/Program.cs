/*
Condition
*/

using System;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
        var length = input.Length;
        int[] terrain = new int[length];
        for (int i = 0; i < length; i++)
        {
            terrain[i] = int.Parse(input[i]);
        }
        int bestPathCount = 1;
        for (int position = 0; position < length; position++)
        {
            for (int step = 1; step < length; step++)
            {
                int currentPathCount = 1;
                int currentIndex = position;
                int nextPosition = (position + step) % length;
                while (terrain[nextPosition] < terrain[currentIndex])
                {
                    currentIndex = nextPosition;
                    nextPosition = currentIndex + step;
                    if (nextPosition >= length)
                    {
                        nextPosition = nextPosition - length;
                    }
                    currentPathCount++;
                }
                if (currentPathCount > bestPathCount)
                {
                    bestPathCount = currentPathCount;
                }
            }
        }
        Console.WriteLine(bestPathCount);
    }
}
