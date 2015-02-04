using System;

class Quadronacci
{
    static void Main()
    {
        long[] numbers = new long[4];
        for (int i = 0; i < 4; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }
        int R = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        for (int i = 0; i < R; i++)
        {
            for (int j = 0; j < C; j++)
            {
                Console.Write(numbers[0] + (j == C - 1 ? "" : " "));
                long temp = numbers[0] + numbers[1] + numbers[2] + numbers[3];
                numbers[0] = numbers[1];
                numbers[1] = numbers[2];
                numbers[2] = numbers[3];
                numbers[3] = temp;
            }
            Console.WriteLine();
        }
    }
}
