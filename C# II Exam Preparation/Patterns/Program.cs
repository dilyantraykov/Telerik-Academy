using System;
using System.IO;

class Program
{
    static void Main()
    {
        // StreamReader reader = new StreamReader("..\\..\\sample-input.txt");
        // Console.SetIn(reader);

        int N = int.Parse(Console.ReadLine());
        int[,] numbers = new int[N,N];
        for (int row = 0; row < N; row++)
        {
            string[] input = Console.ReadLine().Split(' ');
            for (int col = 0; col < input.Length; col++)
            {
                numbers[row, col] = Convert.ToInt32(input[col]);
            }
        }
        long patternSum = 0;
        bool foundPattern = false;
        for (int row = 0; row < N - 2; row++)
        {
            for (int col = 0; col < N - 4; col++)
            {
                if (numbers[row, col] == numbers[row, col + 1] - 1)
                {
                    if (numbers[row, col + 1] == numbers[row, col + 2] - 1)
                    {
                        if (numbers[row, col + 2] == numbers[row + 1, col + 2] - 1)
                        {
                            if (numbers[row + 1, col + 2] == numbers[row + 2, col + 2] - 1)
                            {
                                if (numbers[row + 2, col + 2] == numbers[row + 2, col + 3] - 1)
                                {
                                    if (numbers[row + 2, col + 3] == numbers[row + 2, col + 4] - 1)
                                    {
                                        foundPattern = true;
                                        int tempSum = (numbers[row, col] + numbers[row, col + 1] + numbers[row, col + 2] + 
                                            numbers[row + 1, col + 2] + numbers[row + 2, col + 2] + numbers[row + 2, col + 3] + numbers[row + 2, col + 4]);
                                        if (tempSum > patternSum) 
                                        {
                                            patternSum = tempSum;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (foundPattern)
        {
            Console.WriteLine("YES {0}", patternSum);
        }
        else
        {
            patternSum = 0;
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (row == col)
                    {
                        patternSum += numbers[row, col];
                    }
                }
            }
            Console.WriteLine("NO {0}", patternSum);
        }
        //for (int i = 0; i < N; i++)
        //{
        //    for (int j = 0; j < N; j++)
        //    {
        //        Console.Write(numbers[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
    }
}
